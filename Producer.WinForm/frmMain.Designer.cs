﻿
namespace Producer.WinForm
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLblConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.numericRepeatCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chUseCounter = new System.Windows.Forms.CheckBox();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbQueueExchange = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBindQueue = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeclareQueueRoutingKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeclareQueue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeclareQueueName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDeclareExchangeType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeclareExchange = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeclareExchangeName = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeatCount)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbQueueExchange.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(132, 29);
            this.txtConnectionString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(291, 27);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.Text = "amqp://guest:guest@localhost:5672";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1020);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(723, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLblConnectionStatus
            // 
            this.tsLblConnectionStatus.Name = "tsLblConnectionStatus";
            this.tsLblConnectionStatus.Size = new System.Drawing.Size(229, 20);
            this.tsLblConnectionStatus.Text = "Connection State: Not Connected";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(436, 28);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 35);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(132, 129);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(464, 148);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "";
            // 
            // btnPublish
            // 
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublish.Location = new System.Drawing.Point(451, 285);
            this.btnPublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(144, 46);
            this.btnPublish.TabIndex = 5;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 811);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 209);
            this.panel1.TabIndex = 7;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLog.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(723, 209);
            this.txtLog.TabIndex = 8;
            this.txtLog.Text = "";
            // 
            // numericRepeatCount
            // 
            this.numericRepeatCount.Location = new System.Drawing.Point(132, 305);
            this.numericRepeatCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericRepeatCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericRepeatCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRepeatCount.Name = "numericRepeatCount";
            this.numericRepeatCount.Size = new System.Drawing.Size(137, 27);
            this.numericRepeatCount.TabIndex = 9;
            this.numericRepeatCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repeat";
            // 
            // chUseCounter
            // 
            this.chUseCounter.AutoSize = true;
            this.chUseCounter.Location = new System.Drawing.Point(288, 306);
            this.chUseCounter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chUseCounter.Name = "chUseCounter";
            this.chUseCounter.Size = new System.Drawing.Size(111, 24);
            this.chUseCounter.TabIndex = 11;
            this.chUseCounter.Text = "Use Counter";
            this.chUseCounter.UseVisualStyleBackColor = true;
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(289, 22);
            this.txtExchangeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(304, 27);
            this.txtExchangeName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Exchange Name/Type";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtMessage);
            this.pnlMain.Controls.Add(this.btnPublish);
            this.pnlMain.Controls.Add(this.txtRoutingKey);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.numericRepeatCount);
            this.pnlMain.Controls.Add(this.chUseCounter);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtExchangeName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 431);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(723, 380);
            this.pnlMain.TabIndex = 16;
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(289, 62);
            this.txtRoutingKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(304, 27);
            this.txtRoutingKey.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Routing Key";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtConnectionString);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnConnect);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(723, 82);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection";
            // 
            // gbQueueExchange
            // 
            this.gbQueueExchange.Controls.Add(this.groupBox3);
            this.gbQueueExchange.Controls.Add(this.groupBox1);
            this.gbQueueExchange.Controls.Add(this.groupBox2);
            this.gbQueueExchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueueExchange.Location = new System.Drawing.Point(0, 82);
            this.gbQueueExchange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbQueueExchange.Name = "gbQueueExchange";
            this.gbQueueExchange.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbQueueExchange.Size = new System.Drawing.Size(723, 349);
            this.gbQueueExchange.TabIndex = 24;
            this.gbQueueExchange.TabStop = false;
            this.gbQueueExchange.Text = "Queue / Exchange Declare && Bind";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBindQueue);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDeclareQueueRoutingKey);
            this.groupBox3.Location = new System.Drawing.Point(144, 198);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(405, 129);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bind Queue && Exchange";
            // 
            // btnBindQueue
            // 
            this.btnBindQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBindQueue.Location = new System.Drawing.Point(36, 68);
            this.btnBindQueue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBindQueue.Name = "btnBindQueue";
            this.btnBindQueue.Size = new System.Drawing.Size(339, 42);
            this.btnBindQueue.TabIndex = 22;
            this.btnBindQueue.Text = "Bind Queue";
            this.btnBindQueue.UseVisualStyleBackColor = true;
            this.btnBindQueue.Click += new System.EventHandler(this.btnBindQueue_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Routing Key";
            // 
            // txtDeclareQueueRoutingKey
            // 
            this.txtDeclareQueueRoutingKey.Location = new System.Drawing.Point(157, 29);
            this.txtDeclareQueueRoutingKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeclareQueueRoutingKey.Name = "txtDeclareQueueRoutingKey";
            this.txtDeclareQueueRoutingKey.Size = new System.Drawing.Size(216, 27);
            this.txtDeclareQueueRoutingKey.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeclareQueue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDeclareQueueName);
            this.groupBox1.Location = new System.Drawing.Point(19, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(339, 158);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Declare Queue";
            // 
            // btnDeclareQueue
            // 
            this.btnDeclareQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeclareQueue.Location = new System.Drawing.Point(233, 38);
            this.btnDeclareQueue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeclareQueue.Name = "btnDeclareQueue";
            this.btnDeclareQueue.Size = new System.Drawing.Size(85, 32);
            this.btnDeclareQueue.TabIndex = 17;
            this.btnDeclareQueue.Text = "Declare";
            this.btnDeclareQueue.UseVisualStyleBackColor = true;
            this.btnDeclareQueue.Click += new System.EventHandler(this.btnDeclareQueue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Queue Name";
            // 
            // txtDeclareQueueName
            // 
            this.txtDeclareQueueName.Location = new System.Drawing.Point(103, 74);
            this.txtDeclareQueueName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeclareQueueName.Name = "txtDeclareQueueName";
            this.txtDeclareQueueName.Size = new System.Drawing.Size(216, 27);
            this.txtDeclareQueueName.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDeclareExchangeType);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnDeclareExchange);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDeclareExchangeName);
            this.groupBox2.Location = new System.Drawing.Point(365, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(339, 158);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Declare Exchange";
            // 
            // cbDeclareExchangeType
            // 
            this.cbDeclareExchangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeclareExchangeType.FormattingEnabled = true;
            this.cbDeclareExchangeType.Location = new System.Drawing.Point(71, 72);
            this.cbDeclareExchangeType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDeclareExchangeType.Name = "cbDeclareExchangeType";
            this.cbDeclareExchangeType.Size = new System.Drawing.Size(248, 28);
            this.cbDeclareExchangeType.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Type";
            // 
            // btnDeclareExchange
            // 
            this.btnDeclareExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeclareExchange.Location = new System.Drawing.Point(71, 117);
            this.btnDeclareExchange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeclareExchange.Name = "btnDeclareExchange";
            this.btnDeclareExchange.Size = new System.Drawing.Size(249, 32);
            this.btnDeclareExchange.TabIndex = 17;
            this.btnDeclareExchange.Text = "Declare";
            this.btnDeclareExchange.UseVisualStyleBackColor = true;
            this.btnDeclareExchange.Click += new System.EventHandler(this.btnDeclareExchange_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name";
            // 
            // txtDeclareExchangeName
            // 
            this.txtDeclareExchangeName.Location = new System.Drawing.Point(71, 34);
            this.txtDeclareExchangeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeclareExchangeName.Name = "txtDeclareExchangeName";
            this.txtDeclareExchangeName.Size = new System.Drawing.Size(248, 27);
            this.txtDeclareExchangeName.TabIndex = 19;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 1046);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbQueueExchange);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabbitMQ Producer Winform App";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeatCount)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbQueueExchange.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ToolStripStatusLabel tsLblConnectionStatus;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.NumericUpDown numericRepeatCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chUseCounter;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gbQueueExchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBindQueue;
        private System.Windows.Forms.TextBox txtDeclareQueueRoutingKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeclareQueue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDeclareQueueName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDeclareExchangeType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeclareExchange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeclareExchangeName;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

