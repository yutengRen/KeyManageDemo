﻿namespace KeyManager
{
    partial class FrmTcpTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtRe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSgName = new System.Windows.Forms.TextBox();
            this.btnSendSgName = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtColCount = new System.Windows.Forms.TextBox();
            this.txtRowCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKeyNo = new System.Windows.Forms.TextBox();
            this.btnSuccessBor = new System.Windows.Forms.Button();
            this.btnSuccessBack = new System.Windows.Forms.Button();
            this.btnSkList = new System.Windows.Forms.Button();
            this.btnUpLoadUserInfo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 297);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 143);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "发送输入框消息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "要发送的数据";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(568, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "连接状态";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 141);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 41);
            this.button3.TabIndex = 1;
            this.button3.Text = "发送申请借出命令";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(582, 141);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 41);
            this.button4.TabIndex = 1;
            this.button4.Text = "发送归还命令";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtRe
            // 
            this.txtRe.Location = new System.Drawing.Point(437, 297);
            this.txtRe.Margin = new System.Windows.Forms.Padding(2);
            this.txtRe.Multiline = true;
            this.txtRe.Name = "txtRe";
            this.txtRe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRe.Size = new System.Drawing.Size(394, 143);
            this.txtRe.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "收到的数据";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(723, 198);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 41);
            this.button5.TabIndex = 1;
            this.button5.Text = "发送心跳";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(719, 454);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 41);
            this.button6.TabIndex = 1;
            this.button6.Text = "清除";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(28, 22);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(77, 12);
            this.lblIp.TabIndex = 3;
            this.lblIp.Text = "请输入ip地址";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(111, 19);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 21);
            this.txtIp.TabIndex = 4;
            this.txtIp.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "请输入端口号";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(312, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8099";
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(445, 17);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 5;
            this.btnConn.Text = "连接服务器";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "请输入锁柜名称";
            // 
            // txtSgName
            // 
            this.txtSgName.Location = new System.Drawing.Point(111, 64);
            this.txtSgName.Name = "txtSgName";
            this.txtSgName.Size = new System.Drawing.Size(100, 21);
            this.txtSgName.TabIndex = 4;
            this.txtSgName.Text = "一号柜";
            // 
            // btnSendSgName
            // 
            this.btnSendSgName.Location = new System.Drawing.Point(18, 141);
            this.btnSendSgName.Name = "btnSendSgName";
            this.btnSendSgName.Size = new System.Drawing.Size(111, 41);
            this.btnSendSgName.TabIndex = 5;
            this.btnSendSgName.Text = "上传锁柜信息";
            this.btnSendSgName.UseVisualStyleBackColor = true;
            this.btnSendSgName.Click += new System.EventHandler(this.btnSendSgName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "请输入第几列";
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(111, 101);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(100, 21);
            this.txtCol.TabIndex = 4;
            this.txtCol.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "请输入第几行";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(312, 101);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(100, 21);
            this.txtRow.TabIndex = 4;
            this.txtRow.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "请输入总列数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "请输入总行数";
            // 
            // txtColCount
            // 
            this.txtColCount.Location = new System.Drawing.Point(312, 64);
            this.txtColCount.Name = "txtColCount";
            this.txtColCount.Size = new System.Drawing.Size(100, 21);
            this.txtColCount.TabIndex = 4;
            this.txtColCount.Text = "8";
            // 
            // txtRowCount
            // 
            this.txtRowCount.Location = new System.Drawing.Point(525, 64);
            this.txtRowCount.Name = "txtRowCount";
            this.txtRowCount.Size = new System.Drawing.Size(100, 21);
            this.txtRowCount.TabIndex = 4;
            this.txtRowCount.Text = "8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(431, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "请输入员工卡号";
            // 
            // txtIc
            // 
            this.txtIc.Location = new System.Drawing.Point(525, 101);
            this.txtIc.Name = "txtIc";
            this.txtIc.Size = new System.Drawing.Size(100, 21);
            this.txtIc.TabIndex = 4;
            this.txtIc.Text = "ABCDE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "请输入钥匙卡号";
            // 
            // txtKeyNo
            // 
            this.txtKeyNo.Location = new System.Drawing.Point(731, 101);
            this.txtKeyNo.Name = "txtKeyNo";
            this.txtKeyNo.Size = new System.Drawing.Size(100, 21);
            this.txtKeyNo.TabIndex = 4;
            this.txtKeyNo.Text = "AD57ERF";
            // 
            // btnSuccessBor
            // 
            this.btnSuccessBor.Location = new System.Drawing.Point(441, 141);
            this.btnSuccessBor.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuccessBor.Name = "btnSuccessBor";
            this.btnSuccessBor.Size = new System.Drawing.Size(111, 41);
            this.btnSuccessBor.TabIndex = 1;
            this.btnSuccessBor.Text = "发送成功借出命令";
            this.btnSuccessBor.UseVisualStyleBackColor = true;
            this.btnSuccessBor.Click += new System.EventHandler(this.btnSuccessBor_Click);
            // 
            // btnSuccessBack
            // 
            this.btnSuccessBack.Location = new System.Drawing.Point(723, 141);
            this.btnSuccessBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuccessBack.Name = "btnSuccessBack";
            this.btnSuccessBack.Size = new System.Drawing.Size(111, 41);
            this.btnSuccessBack.TabIndex = 1;
            this.btnSuccessBack.Text = "发送成功归还命令";
            this.btnSuccessBack.UseVisualStyleBackColor = true;
            this.btnSuccessBack.Click += new System.EventHandler(this.btnSuccessBack_Click);
            // 
            // btnSkList
            // 
            this.btnSkList.Location = new System.Drawing.Point(159, 141);
            this.btnSkList.Margin = new System.Windows.Forms.Padding(2);
            this.btnSkList.Name = "btnSkList";
            this.btnSkList.Size = new System.Drawing.Size(111, 41);
            this.btnSkList.TabIndex = 1;
            this.btnSkList.Text = "上传锁孔列表";
            this.btnSkList.UseVisualStyleBackColor = true;
            this.btnSkList.Click += new System.EventHandler(this.btnSkList_Click);
            // 
            // btnUpLoadUserInfo
            // 
            this.btnUpLoadUserInfo.Location = new System.Drawing.Point(18, 198);
            this.btnUpLoadUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpLoadUserInfo.Name = "btnUpLoadUserInfo";
            this.btnUpLoadUserInfo.Size = new System.Drawing.Size(111, 41);
            this.btnUpLoadUserInfo.TabIndex = 1;
            this.btnUpLoadUserInfo.Text = "上传用户信息";
            this.btnUpLoadUserInfo.UseVisualStyleBackColor = true;
            this.btnUpLoadUserInfo.Click += new System.EventHandler(this.btnUpLoadUserInfo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(636, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "请输入用户昵称";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(731, 64);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(100, 21);
            this.txtNickName.TabIndex = 4;
            this.txtNickName.Text = "张三";
            // 
            // FrmTcpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 509);
            this.Controls.Add(this.btnSendSgName);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.txtKeyNo);
            this.Controls.Add(this.txtIc);
            this.Controls.Add(this.txtRowCount);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.txtColCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSgName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnUpLoadUserInfo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSkList);
            this.Controls.Add(this.btnSuccessBack);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSuccessBor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtRe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTcpTest";
            this.Text = "客户端模拟demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtRe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSgName;
        private System.Windows.Forms.Button btnSendSgName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtColCount;
        private System.Windows.Forms.TextBox txtRowCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKeyNo;
        private System.Windows.Forms.Button btnSuccessBor;
        private System.Windows.Forms.Button btnSuccessBack;
        private System.Windows.Forms.Button btnSkList;
        private System.Windows.Forms.Button btnUpLoadUserInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNickName;
    }
}