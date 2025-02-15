﻿namespace PlcClient.Controls
{
    partial class Net2Client
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cbx_localip = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbx_mode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cbx_remoteIp = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbx_remotePort = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_conn = new System.Windows.Forms.ToolStripButton();
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cbx_code = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_send = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_hexSend = new System.Windows.Forms.CheckBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clearSend = new System.Windows.Forms.Button();
            this.nd_num = new System.Windows.Forms.NumericUpDown();
            this.nd_step = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_received = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbx_time = new System.Windows.Forms.CheckBox();
            this.cbx_hex = new System.Windows.Forms.CheckBox();
            this.btn_clearCallback = new System.Windows.Forms.Button();
            this.cbx_string = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nd_step)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.cbx_localip,
            this.toolStripLabel1,
            this.cbx_mode,
            this.toolStripLabel3,
            this.cbx_remoteIp,
            this.toolStripLabel2,
            this.tbx_remotePort,
            this.toolStripSeparator2,
            this.btn_conn,
            this.btn_close,
            this.toolStripSeparator1,
            this.toolStripLabel4,
            this.cbx_code});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel5.Text = "本地IP";
            // 
            // cbx_localip
            // 
            this.cbx_localip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_localip.Items.AddRange(new object[] {
            "0.0.0.0"});
            this.cbx_localip.Name = "cbx_localip";
            this.cbx_localip.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "模式";
            // 
            // cbx_mode
            // 
            this.cbx_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mode.DropDownWidth = 121;
            this.cbx_mode.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.cbx_mode.Name = "cbx_mode";
            this.cbx_mode.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel3.Text = "远程IP";
            // 
            // cbx_remoteIp
            // 
            this.cbx_remoteIp.Name = "cbx_remoteIp";
            this.cbx_remoteIp.Size = new System.Drawing.Size(120, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel2.Text = "远程端口";
            // 
            // tbx_remotePort
            // 
            this.tbx_remotePort.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tbx_remotePort.MaxLength = 5;
            this.tbx_remotePort.Name = "tbx_remotePort";
            this.tbx_remotePort.Size = new System.Drawing.Size(50, 25);
            this.tbx_remotePort.Text = "7979";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_conn
            // 
            this.btn_conn.Image = global::PlcClient.Properties.Resources.Play;
            this.btn_conn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(52, 22);
            this.btn_conn.Text = "连接";
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // btn_close
            // 
            this.btn_close.Image = global::PlcClient.Properties.Resources.Stop;
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(52, 22);
            this.btn_close.Text = "断开";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel4.Text = "字符编码";
            // 
            // cbx_code
            // 
            this.cbx_code.Items.AddRange(new object[] {
            "Default",
            "UTF-8",
            "GBK",
            "Unicode",
            "ASCII"});
            this.cbx_code.Name = "cbx_code";
            this.cbx_code.Size = new System.Drawing.Size(80, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_send);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据发送";
            // 
            // tbx_send
            // 
            this.tbx_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_send.Location = new System.Drawing.Point(3, 17);
            this.tbx_send.Multiline = true;
            this.tbx_send.Name = "tbx_send";
            this.tbx_send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_send.Size = new System.Drawing.Size(500, 163);
            this.tbx_send.TabIndex = 4;
            this.tbx_send.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbx_hexSend);
            this.panel1.Controls.Add(this.btn_send);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_clearSend);
            this.panel1.Controls.Add(this.nd_num);
            this.panel1.Controls.Add(this.nd_step);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(515, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 183);
            this.panel1.TabIndex = 4;
            // 
            // cbx_hexSend
            // 
            this.cbx_hexSend.AutoSize = true;
            this.cbx_hexSend.Location = new System.Drawing.Point(3, 46);
            this.cbx_hexSend.Name = "cbx_hexSend";
            this.cbx_hexSend.Size = new System.Drawing.Size(72, 16);
            this.cbx_hexSend.TabIndex = 8;
            this.cbx_hexSend.Text = "发送 HEX";
            this.cbx_hexSend.UseVisualStyleBackColor = true;
            this.cbx_hexSend.CheckedChanged += new System.EventHandler(this.cbx_hexSend_CheckedChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(3, 17);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "发送数据";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "次数";
            // 
            // btn_clearSend
            // 
            this.btn_clearSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clearSend.Location = new System.Drawing.Point(3, 157);
            this.btn_clearSend.Name = "btn_clearSend";
            this.btn_clearSend.Size = new System.Drawing.Size(75, 23);
            this.btn_clearSend.TabIndex = 9;
            this.btn_clearSend.Text = "清空";
            this.btn_clearSend.UseVisualStyleBackColor = true;
            this.btn_clearSend.Click += new System.EventHandler(this.btn_clearSend_Click);
            // 
            // nd_num
            // 
            this.nd_num.Location = new System.Drawing.Point(3, 68);
            this.nd_num.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nd_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nd_num.Name = "nd_num";
            this.nd_num.Size = new System.Drawing.Size(75, 21);
            this.nd_num.TabIndex = 6;
            this.nd_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nd_step
            // 
            this.nd_step.Location = new System.Drawing.Point(3, 95);
            this.nd_step.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nd_step.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nd_step.Name = "nd_step";
            this.nd_step.Size = new System.Drawing.Size(75, 21);
            this.nd_step.TabIndex = 7;
            this.nd_step.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "ms/次间隔";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_received);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收";
            // 
            // tbx_received
            // 
            this.tbx_received.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_received.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_received.Location = new System.Drawing.Point(3, 17);
            this.tbx_received.Name = "tbx_received";
            this.tbx_received.ReadOnly = true;
            this.tbx_received.Size = new System.Drawing.Size(500, 163);
            this.tbx_received.TabIndex = 1;
            this.tbx_received.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbx_time);
            this.panel2.Controls.Add(this.cbx_hex);
            this.panel2.Controls.Add(this.btn_clearCallback);
            this.panel2.Controls.Add(this.cbx_string);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(515, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 183);
            this.panel2.TabIndex = 5;
            // 
            // cbx_time
            // 
            this.cbx_time.AutoSize = true;
            this.cbx_time.Checked = true;
            this.cbx_time.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_time.Location = new System.Drawing.Point(3, 19);
            this.cbx_time.Name = "cbx_time";
            this.cbx_time.Size = new System.Drawing.Size(72, 16);
            this.cbx_time.TabIndex = 6;
            this.cbx_time.Text = "显示时间";
            this.cbx_time.UseVisualStyleBackColor = true;
            // 
            // cbx_hex
            // 
            this.cbx_hex.AutoSize = true;
            this.cbx_hex.Location = new System.Drawing.Point(3, 63);
            this.cbx_hex.Name = "cbx_hex";
            this.cbx_hex.Size = new System.Drawing.Size(72, 16);
            this.cbx_hex.TabIndex = 8;
            this.cbx_hex.Text = "显示 HEX";
            this.cbx_hex.UseVisualStyleBackColor = true;
            // 
            // btn_clearCallback
            // 
            this.btn_clearCallback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clearCallback.Location = new System.Drawing.Point(3, 157);
            this.btn_clearCallback.Name = "btn_clearCallback";
            this.btn_clearCallback.Size = new System.Drawing.Size(75, 23);
            this.btn_clearCallback.TabIndex = 3;
            this.btn_clearCallback.Text = "清空";
            this.btn_clearCallback.UseVisualStyleBackColor = true;
            this.btn_clearCallback.Click += new System.EventHandler(this.btn_clearCallback_Click);
            // 
            // cbx_string
            // 
            this.cbx_string.AutoSize = true;
            this.cbx_string.Checked = true;
            this.cbx_string.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_string.Location = new System.Drawing.Point(3, 41);
            this.cbx_string.Name = "cbx_string";
            this.cbx_string.Size = new System.Drawing.Size(72, 16);
            this.cbx_string.TabIndex = 7;
            this.cbx_string.Text = "显示字符";
            this.cbx_string.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 378);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Net2Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Net2Client";
            this.Size = new System.Drawing.Size(842, 430);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nd_step)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbx_remotePort;
        private System.Windows.Forms.ToolStripButton btn_conn;
        private System.Windows.Forms.ToolStripButton btn_close;
        private System.Windows.Forms.ToolStripComboBox cbx_mode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_clearSend;
        private System.Windows.Forms.Button btn_clearCallback;
        private System.Windows.Forms.RichTextBox tbx_received;
        private System.Windows.Forms.TextBox tbx_send;
        private System.Windows.Forms.CheckBox cbx_string;
        private System.Windows.Forms.ToolStripComboBox cbx_remoteIp;
        private System.Windows.Forms.CheckBox cbx_hex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.CheckBox cbx_hexSend;
        private System.Windows.Forms.CheckBox cbx_time;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cbx_code;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cbx_localip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nd_num;
        private System.Windows.Forms.NumericUpDown nd_step;
        private System.Windows.Forms.Label label1;
    }
}
