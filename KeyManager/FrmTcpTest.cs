using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using TCPHelper;

namespace KeyManager
{
    public partial class FrmTcpTest : Form
    {
        public FrmTcpTest()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            client.Completed += tcpCompletedMethod;
            client.Received += receiveTcpMessageMethod;
            //client.ConnectAsync(tcpAddress, port);
        }

        string tcpAddress = "127.0.0.1";
        int port = 8099;
        ClientAsync client = new ClientAsync();


        private void btnConn_Click(object sender, EventArgs e)
        {
            client.ConnectAsync(txtIp.Text, Convert.ToInt32(txtPort.Text));
        }

        private void tcpCompletedMethod(TcpClient c, EnSocketAction enAction)
        {
            if (c.Client != null)
            {
                IPEndPoint iep = c.Client.RemoteEndPoint as IPEndPoint;
                string key = string.Format("{0}:{1}", iep.Address.ToString(), iep.Port);
                switch (enAction)
                {
                    case EnSocketAction.Connect:
                        //Console.WriteLine("已经与{0}建立连接", key);
                        label2.Text = string.Format("已经与{0}建立连接", key);
                        break;
                    case EnSocketAction.SendMsg:
                        Console.WriteLine("{0}：向{1}发送了一条消息", DateTime.Now, key);
                        break;
                    case EnSocketAction.Close:
                        client.Close();
                        client = null;
                        Console.WriteLine("服务端连接关闭");
                        this.Close();
                        Application.Exit();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tcp为空");
            }
        }

        private void receiveTcpMessageMethod(string key, string tcpMessage)
        {
            try
            {
                txtRe.Text += string.Format("{0}对我说：{1} \r\n", key, tcpMessage);
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.SendAsync(textBox1.Text);
            textBox1.Text = "";
        }

        /// <summary>
        /// 借出钥匙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            JObject jo = new JObject();
            jo["cardNo"] = txtIc.Text;
            jo["xPosition"] = txtCol.Text;
            jo["yPosition"] = txtRow.Text;
            jo["lockerCode"] = txtSgName.Name;
            jo["operationType"] = 0;

            string str = "1004" + jo.ToString();
            client.SendAsync(str);
        }

        /// <summary>
        /// 成功借出钥匙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuccessBor_Click(object sender, EventArgs e)
        {
            JObject jo = new JObject();
            jo["cardNo"] = txtIc.Text;
            jo["xPosition"] = txtCol.Text;
            jo["yPosition"] = txtRow.Text;
            jo["lockerCode"] = txtSgName.Name;
            jo["operationType"] = 1;

            string str = "1004" + jo.ToString();
            client.SendAsync(str);
        }

        /// <summary>
        /// 归还钥匙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            JObject jo = new JObject();
            jo["cardNo"] = txtIc.Text;
            jo["lockerCode"] = txtSgName.Name;
            jo["keyCode"] = txtKeyNo.Text;
            jo["operationType"] = 0;

            string str = "1005" + jo.ToString();
            client.SendAsync(str);
        }

        /// <summary>
        /// 成功归还钥匙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuccessBack_Click(object sender, EventArgs e)
        {
            JObject jo = new JObject();
            jo["cardNo"] = txtIc.Text;
            jo["lockerCode"] = txtSgName.Name;
            jo["keyCode"] = txtKeyNo.Text;
            jo["operationType"] = 1;

            string str = "1005" + jo.ToString();
            client.SendAsync(str);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            client.SendAsync("1002");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtRe.Text = "";
        }

        /// <summary>
        /// 上传锁柜信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendSgName_Click(object sender, EventArgs e)
        {
            JObject jo = new JObject();
            jo["keyTableRows"] = txtRowCount.Text;
            jo["keyTableColumns"] = txtColCount.Text;
            jo["lockerCode"] = txtSgName.Text;

            string str = "1003" + jo.ToString();
            client.SendAsync(str);
        }

        /// <summary>
        /// 上传锁孔列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkList_Click(object sender, EventArgs e)
        {
            JObject jo = new JObject();
            jo["code"] = 200;
            jo["msg"] = "";

            //list集合的属性
            JObject item1 = new JObject();
            item1["id"] = 1;
            item1["cardNum"] = "ABCDE";
            item1["state"] = 200;
            item1["xPosition"] = 1;
            item1["yPosition"] = 1;

            JObject item2 = new JObject();
            item2["id"] = 2;
            item2["cardNum"] = "WDFGT";
            item2["state"] = 200;
            item2["xPosition"] = 1;
            item2["yPosition"] = 2;

            JArray ja = new JArray();
            ja.Add(item1);
            ja.Add(item2);
            jo["list"] = ja;

            string str = "2001" + jo.ToString();
            client.SendAsync(str);
        }

        /// <summary>
        /// 上传用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpLoadUserInfo_Click(object sender, EventArgs e)
        {
            JObject jo = new JObject();
            jo["id"] = 1;
            jo["cardNo"] = txtIc.Text;
            jo["fingerprint"] = "FSDFWEGVDSDFSDF";      //这个值暂时写死
            jo["nickName"] = txtNickName.Text;

            string str = "3004" + jo.ToString();
            client.SendAsync(str);
        }
    }
}
