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

        string cardno = "abcde";

        /// <summary>
        /// 借出钥匙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            JObject jo = new JObject();
            jo["cardNo"] = cardno;
            jo["empowerCardNo"] = "";
            jo["lockerCode"] = txtSgName.Name;
            jo["XPosition"] = txtCol.Text;
            jo["YPosition"] = txtRow.Text;

            string str = "1006" + jo.ToString();
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
            jo["cardNo"] = cardno;
            jo["lockerCode"] = txtSgName.Name;
            jo["XPosition"] = txtCol.Text;
            jo["YPosition"] = txtRow.Text;
            jo["keyCode"] = "1234";

            string str = "1008" + jo.ToString();
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

        private void btnSendSgName_Click(object sender, EventArgs e)
        {
            JObject jo = new JObject();
            jo["KeyTableRows"] = txtRowCount.Text;
            jo["KeyTableColumns"] = txtColCount.Text;
            jo["lockerCode"] = txtSgName.Text;

            string str = "1005" + jo.ToString();
            client.SendAsync(str);
        }
    }
}
