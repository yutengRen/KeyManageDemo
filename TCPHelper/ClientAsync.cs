using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPHelper
{
    public class ClientAsync
    {
        private TcpClient client;
        /// <summary>
        /// 客户端连接完成、发送完成、连接异常或者服务端关闭触发的事件
        /// </summary>
        public event Action<TcpClient, EnSocketAction> Completed;
        /// <summary>
        /// 客户端接收消息触发的事件
        /// </summary>
        public event Action<string, string> Received;
        /// <summary>
        /// 用于控制异步接收消息
        /// </summary>
        private ManualResetEvent doReceive = new ManualResetEvent(false);
        //标识客户端是否关闭
        private bool isClose = false;
        public ClientAsync()
        {
            client = new TcpClient();
        }

        /// <summary>
        /// 获取TCP客户端的连接状态
        /// </summary>
        public bool GetConnState()
        {
            //get { return client.Connected; }
            try
            {
                return client.Connected;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 清理发送和接收事件
        /// </summary>
        public void clear()
        {
            Completed = null;
            Received = null;
        }
        /// <summary>
        /// 异步连接
        /// </summary>
        /// <param name="ip">要连接的服务器的ip地址</param>
        /// <param name="port">要连接的服务器的端口</param>
        public bool ConnectAsync(string ip, int port)
        {
            try
            {
                IPAddress ipAddress = null;
                try
                {
                    ipAddress = IPAddress.Parse(ip);
                }
                catch (Exception)
                {
                    IPHostEntry hostInfo = Dns.GetHostEntry(ip);
                    ipAddress = hostInfo.AddressList[0];
                    //throw new Exception("ip地址格式不正确，请使用正确的ip地址！");
                }
                IAsyncResult result = client.BeginConnect(ipAddress, port, ConnectCallBack, client);
                //return result.
                //return client.Connected;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 异步连接，连接ip地址为127.0.0.1
        /// </summary>
        /// <param name="port">要连接服务端的端口</param>
        public void ConnectAsync(int port)
        {
            ConnectAsync("127.0.0.1", port);
        }
        /// <summary>
        /// 异步接收消息
        /// </summary>
        private void ReceiveAsync()
        {
            doReceive.Reset();
            StateObject obj = new StateObject();
            obj.Client = client;

            client.Client.BeginReceive(obj.ListData, 0, obj.ListData.Length, SocketFlags.None, ReceiveCallBack, obj);
            //int strLen = getLen(obj.ListData);
            //client.Client.BeginReceive(obj.ListData, 4, strLen, SocketFlags.None, ReceiveCallBack, obj);
            doReceive.WaitOne();
        }
        /// <summary>
        /// 异步发送消息
        /// </summary>
        /// <param name="msg"></param>
        public bool SendAsync(string msg)
        {
            try
            {
                if (isClose)
                {
                    return false;
                }
                byte[] listData = getSendByte(msg);
                client.Client.BeginSend(getSendByte(msg), 0, listData.Length, SocketFlags.None, SendCallBack, client);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        /// <summary>
        /// 异步连接的回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void ConnectCallBack(IAsyncResult ar)
        {
            try
            {
                TcpClient client = ar.AsyncState as TcpClient;
                client.EndConnect(ar);
                OnComplete(client, EnSocketAction.Connect);
            }
            catch
            {

            }
        }
        /// <summary>
        /// 异步接收消息的回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void ReceiveCallBack(IAsyncResult ar)
        {
            try
            {
                StateObject obj = ar.AsyncState as StateObject;
                try
                {
                    //StateObject obj = ar.AsyncState as StateObject;
                    int count = -1;
                    try
                    {
                        count = obj.Client.Client.EndReceive(ar);
                        doReceive.Set();
                    }
                    catch (Exception)
                    {
                        //如果发生异常，说明客户端失去连接，触发关闭事件
                        Close();
                        OnComplete(obj.Client, EnSocketAction.Close);
                    }
                    if (count > 0)
                    {
                        //string msg = Encoding.UTF8.GetString(obj.ListData, 0, count);

                        int strLen = getLen(obj.ListData);
                        string msg = Encoding.UTF8.GetString(obj.ListData, 4, strLen);   //这里报错

                        if (!string.IsNullOrEmpty(msg))
                        {
                            if (Received != null)
                            {
                                IPEndPoint iep = obj.Client.Client.RemoteEndPoint as IPEndPoint;
                                string key = string.Format("{0}:{1}", iep.Address, iep.Port);
                                Received(key, msg);
                            }
                        }
                    }
                }
                catch
                {
                    //如果发生异常，说明客户端失去连接，触发关闭事件
                    Close();
                    OnComplete(obj.Client, EnSocketAction.Close);
                }
            }
            catch (Exception)
            {

            }

        }
        private void SendCallBack(IAsyncResult ar)
        {
            TcpClient client = ar.AsyncState as TcpClient;
            try
            {
                client.Client.EndSend(ar);
                OnComplete(client, EnSocketAction.SendMsg);
            }
            catch (Exception ex)
            {
                //如果发生异常，说明客户端失去连接，触发关闭事件
                Close();
                OnComplete(client, EnSocketAction.Close);
            }
        }
        public virtual void OnComplete(TcpClient client, EnSocketAction enAction)
        {
            if (Completed != null)
                Completed(client, enAction);
            if (enAction == EnSocketAction.Connect)//建立连接后，开始接收数据
            {
                System.Threading.ThreadPool.QueueUserWorkItem(x =>
                {
                    while (!isClose)
                    {
                        try
                        {
                            Thread.Sleep(20);
                            ReceiveAsync();
                            Thread.Sleep(20);
                        }
                        catch (Exception)
                        {
                            Close();
                            OnComplete(client, EnSocketAction.Close);
                        }
                    }
                });
            }
        }

        /// <summary>
        /// 计算发送端的字节长度
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static byte[] getSendByte(string str)
        {
            byte[] a = Encoding.UTF8.GetBytes(str);
            int aa = a.Length;

            byte b3 = (byte)((aa >> 24) & 0xff);
            byte b2 = (byte)((aa >> 16) & 0xff);
            byte b1 = (byte)((aa >> 8) & 0xff);
            byte b0 = (byte)(aa & 0xff);
            byte[] req = new byte[aa + 4];
            req[0] = b0;
            req[1] = b1;
            req[2] = b2;
            req[3] = b3;
            System.Array.Copy(a, 0, req, 4, aa);
            return req;
        }

        /// <summary>
        /// 计算接收的字节长度
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        private static int getLen(byte[] by)
        {
            int length = 0;
            length += ((by[0]) & 0xff);
            length += ((by[1] & 0xff) << 8);
            length += ((by[2] & 0xff) << 16);
            length += ((by[3] & 0xff) << 24);
            return length;
        }

        public void Close()
        {
            isClose = true;
            //if (client != null)
            //{
            //    client.Close();
            //    client = null;
            //}
        }

        public void Dispose()
        {
            client.Close();
            try
            {
                if (client.Connected)
                {
                    client.Client = null;
                    client = null;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
