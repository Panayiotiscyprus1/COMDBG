namespace COMDBG
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comListCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baudRateCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBitsCbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stopBitsCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parityCbx = new System.Windows.Forms.ComboBox();
            this.openCloseSpbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recHexRadiobtn = new System.Windows.Forms.RadioButton();
            this.autoReplyCbx = new System.Windows.Forms.CheckBox();
            this.recStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.addCRCcbx = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sendIntervalTimetbx = new System.Windows.Forms.TextBox();
            this.autoSendcbx = new System.Windows.Forms.CheckBox();
            this.sendHexRadiobtn = new System.Windows.Forms.RadioButton();
            this.sendStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.clearReceivebtn = new System.Windows.Forms.Button();
            this.clearSendbtn = new System.Windows.Forms.Button();
            this.receivetbx = new System.Windows.Forms.TextBox();
            this.sendtbx = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusRx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTx = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statustimer = new System.Windows.Forms.Timer(this.components);
            this.autoSendtimer = new System.Windows.Forms.Timer(this.components);
            this.refreshbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.handshakingcbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.requestButton = new System.Windows.Forms.Button();
            this.Decrypted = new System.Windows.Forms.GroupBox();
            this.orTimeBox = new System.Windows.Forms.TextBox();
            this.operationTime = new System.Windows.Forms.TextBox();
            this.flowTemp = new System.Windows.Forms.TextBox();
            this.reverseFlow = new System.Windows.Forms.TextBox();
            this.normalFlow = new System.Windows.Forms.TextBox();
            this.manufacturerId = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.header_label = new System.Windows.Forms.Label();
            this.deviceNumberBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.send3 = new System.Windows.Forms.Button();
            this.send1 = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelPrimary = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.primaryAddress = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Decrypted.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comListCbx
            // 
            this.comListCbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comListCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comListCbx.FormattingEnabled = true;
            this.comListCbx.Location = new System.Drawing.Point(21, 53);
            this.comListCbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comListCbx.Name = "comListCbx";
            this.comListCbx.Size = new System.Drawing.Size(109, 26);
            this.comListCbx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Baud Rate:";
            // 
            // baudRateCbx
            // 
            this.baudRateCbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.baudRateCbx.FormattingEnabled = true;
            this.baudRateCbx.Location = new System.Drawing.Point(21, 113);
            this.baudRateCbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baudRateCbx.Name = "baudRateCbx";
            this.baudRateCbx.Size = new System.Drawing.Size(109, 26);
            this.baudRateCbx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Bits:";
            // 
            // dataBitsCbx
            // 
            this.dataBitsCbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataBitsCbx.FormattingEnabled = true;
            this.dataBitsCbx.Location = new System.Drawing.Point(21, 173);
            this.dataBitsCbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataBitsCbx.Name = "dataBitsCbx";
            this.dataBitsCbx.Size = new System.Drawing.Size(109, 26);
            this.dataBitsCbx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stop Bits:";
            // 
            // stopBitsCbx
            // 
            this.stopBitsCbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stopBitsCbx.FormattingEnabled = true;
            this.stopBitsCbx.Location = new System.Drawing.Point(21, 233);
            this.stopBitsCbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopBitsCbx.Name = "stopBitsCbx";
            this.stopBitsCbx.Size = new System.Drawing.Size(109, 26);
            this.stopBitsCbx.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Parity:";
            // 
            // parityCbx
            // 
            this.parityCbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.parityCbx.FormattingEnabled = true;
            this.parityCbx.Location = new System.Drawing.Point(21, 293);
            this.parityCbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parityCbx.Name = "parityCbx";
            this.parityCbx.Size = new System.Drawing.Size(109, 26);
            this.parityCbx.TabIndex = 15;
            // 
            // openCloseSpbtn
            // 
            this.openCloseSpbtn.BackColor = System.Drawing.Color.Aqua;
            this.openCloseSpbtn.Enabled = false;
            this.openCloseSpbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openCloseSpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCloseSpbtn.Location = new System.Drawing.Point(21, 467);
            this.openCloseSpbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openCloseSpbtn.Name = "openCloseSpbtn";
            this.openCloseSpbtn.Size = new System.Drawing.Size(111, 54);
            this.openCloseSpbtn.TabIndex = 17;
            this.openCloseSpbtn.Text = "Open";
            this.openCloseSpbtn.UseVisualStyleBackColor = false;
            this.openCloseSpbtn.Click += new System.EventHandler(this.openCloseSpbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.autoReplyCbx);
            this.groupBox1.Controls.Add(this.addCRCcbx);
            this.groupBox1.Controls.Add(this.requestButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.sendIntervalTimetbx);
            this.groupBox1.Controls.Add(this.autoSendcbx);
            this.groupBox1.Controls.Add(this.sendHexRadiobtn);
            this.groupBox1.Controls.Add(this.sendStrRadiobtn);
            this.groupBox1.Controls.Add(this.clearReceivebtn);
            this.groupBox1.Controls.Add(this.clearSendbtn);
            this.groupBox1.Controls.Add(this.receivetbx);
            this.groupBox1.Controls.Add(this.sendtbx);
            this.groupBox1.Controls.Add(this.sendbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(163, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(550, 533);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // recHexRadiobtn
            // 
            this.recHexRadiobtn.AutoSize = true;
            this.recHexRadiobtn.Checked = true;
            this.recHexRadiobtn.Location = new System.Drawing.Point(76, 6);
            this.recHexRadiobtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recHexRadiobtn.Name = "recHexRadiobtn";
            this.recHexRadiobtn.Size = new System.Drawing.Size(55, 22);
            this.recHexRadiobtn.TabIndex = 15;
            this.recHexRadiobtn.TabStop = true;
            this.recHexRadiobtn.Text = "Hex";
            this.recHexRadiobtn.UseVisualStyleBackColor = true;
            this.recHexRadiobtn.CheckedChanged += new System.EventHandler(this.recHexRadiobtn_CheckedChanged);
            // 
            // autoReplyCbx
            // 
            this.autoReplyCbx.AutoSize = true;
            this.autoReplyCbx.Enabled = false;
            this.autoReplyCbx.Location = new System.Drawing.Point(21, 502);
            this.autoReplyCbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autoReplyCbx.Name = "autoReplyCbx";
            this.autoReplyCbx.Size = new System.Drawing.Size(97, 22);
            this.autoReplyCbx.TabIndex = 25;
            this.autoReplyCbx.Text = "AutoReply";
            this.autoReplyCbx.UseVisualStyleBackColor = true;
            // 
            // recStrRadiobtn
            // 
            this.recStrRadiobtn.AutoSize = true;
            this.recStrRadiobtn.Location = new System.Drawing.Point(1, 6);
            this.recStrRadiobtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recStrRadiobtn.Name = "recStrRadiobtn";
            this.recStrRadiobtn.Size = new System.Drawing.Size(67, 22);
            this.recStrRadiobtn.TabIndex = 14;
            this.recStrRadiobtn.Text = "String";
            this.recStrRadiobtn.UseVisualStyleBackColor = true;
            this.recStrRadiobtn.CheckedChanged += new System.EventHandler(this.recStrRadiobtn_CheckedChanged);
            // 
            // addCRCcbx
            // 
            this.addCRCcbx.AutoSize = true;
            this.addCRCcbx.Enabled = false;
            this.addCRCcbx.Location = new System.Drawing.Point(279, 469);
            this.addCRCcbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCRCcbx.Name = "addCRCcbx";
            this.addCRCcbx.Size = new System.Drawing.Size(92, 22);
            this.addCRCcbx.TabIndex = 24;
            this.addCRCcbx.Text = "Add CRC";
            this.addCRCcbx.UseVisualStyleBackColor = true;
            this.addCRCcbx.CheckedChanged += new System.EventHandler(this.addCRCcbx_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 474);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "ms";
            // 
            // sendIntervalTimetbx
            // 
            this.sendIntervalTimetbx.Location = new System.Drawing.Point(123, 468);
            this.sendIntervalTimetbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendIntervalTimetbx.MaxLength = 9;
            this.sendIntervalTimetbx.Name = "sendIntervalTimetbx";
            this.sendIntervalTimetbx.Size = new System.Drawing.Size(64, 24);
            this.sendIntervalTimetbx.TabIndex = 22;
            this.sendIntervalTimetbx.Text = "1000";
            this.sendIntervalTimetbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendIntervalTimetbx_KeyPress);
            // 
            // autoSendcbx
            // 
            this.autoSendcbx.AutoSize = true;
            this.autoSendcbx.Enabled = false;
            this.autoSendcbx.Location = new System.Drawing.Point(21, 469);
            this.autoSendcbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autoSendcbx.Name = "autoSendcbx";
            this.autoSendcbx.Size = new System.Drawing.Size(94, 22);
            this.autoSendcbx.TabIndex = 21;
            this.autoSendcbx.Text = "AutoSend";
            this.autoSendcbx.UseVisualStyleBackColor = true;
            this.autoSendcbx.CheckedChanged += new System.EventHandler(this.autoSendcbx_CheckedChanged);
            // 
            // sendHexRadiobtn
            // 
            this.sendHexRadiobtn.AutoSize = true;
            this.sendHexRadiobtn.Checked = true;
            this.sendHexRadiobtn.Location = new System.Drawing.Point(381, 280);
            this.sendHexRadiobtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendHexRadiobtn.Name = "sendHexRadiobtn";
            this.sendHexRadiobtn.Size = new System.Drawing.Size(55, 22);
            this.sendHexRadiobtn.TabIndex = 17;
            this.sendHexRadiobtn.TabStop = true;
            this.sendHexRadiobtn.Text = "Hex";
            this.sendHexRadiobtn.UseVisualStyleBackColor = true;
            this.sendHexRadiobtn.CheckedChanged += new System.EventHandler(this.sendHexRadiobtn_CheckedChanged);
            // 
            // sendStrRadiobtn
            // 
            this.sendStrRadiobtn.AutoSize = true;
            this.sendStrRadiobtn.Location = new System.Drawing.Point(304, 280);
            this.sendStrRadiobtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendStrRadiobtn.Name = "sendStrRadiobtn";
            this.sendStrRadiobtn.Size = new System.Drawing.Size(67, 22);
            this.sendStrRadiobtn.TabIndex = 16;
            this.sendStrRadiobtn.Text = "String";
            this.sendStrRadiobtn.UseVisualStyleBackColor = true;
            this.sendStrRadiobtn.CheckedChanged += new System.EventHandler(this.sendStrRadiobtn_CheckedChanged);
            // 
            // clearReceivebtn
            // 
            this.clearReceivebtn.AutoSize = true;
            this.clearReceivebtn.Location = new System.Drawing.Point(442, 17);
            this.clearReceivebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearReceivebtn.Name = "clearReceivebtn";
            this.clearReceivebtn.Size = new System.Drawing.Size(80, 28);
            this.clearReceivebtn.TabIndex = 11;
            this.clearReceivebtn.Text = "Clear";
            this.clearReceivebtn.UseVisualStyleBackColor = true;
            this.clearReceivebtn.Click += new System.EventHandler(this.clearReceivebtn_Click);
            // 
            // clearSendbtn
            // 
            this.clearSendbtn.Location = new System.Drawing.Point(442, 275);
            this.clearSendbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearSendbtn.Name = "clearSendbtn";
            this.clearSendbtn.Size = new System.Drawing.Size(80, 29);
            this.clearSendbtn.TabIndex = 10;
            this.clearSendbtn.Text = "Clear";
            this.clearSendbtn.UseVisualStyleBackColor = true;
            this.clearSendbtn.Click += new System.EventHandler(this.clearSendbtn_Click);
            // 
            // receivetbx
            // 
            this.receivetbx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.receivetbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receivetbx.ForeColor = System.Drawing.SystemColors.Desktop;
            this.receivetbx.Location = new System.Drawing.Point(20, 53);
            this.receivetbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.receivetbx.Multiline = true;
            this.receivetbx.Name = "receivetbx";
            this.receivetbx.ReadOnly = true;
            this.receivetbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivetbx.Size = new System.Drawing.Size(530, 208);
            this.receivetbx.TabIndex = 9;
            this.receivetbx.TabStop = false;
            this.receivetbx.TextChanged += new System.EventHandler(this.receivetbx_TextChanged);
            // 
            // sendtbx
            // 
            this.sendtbx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sendtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendtbx.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sendtbx.Location = new System.Drawing.Point(20, 311);
            this.sendtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendtbx.Multiline = true;
            this.sendtbx.Name = "sendtbx";
            this.sendtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendtbx.Size = new System.Drawing.Size(530, 146);
            this.sendtbx.TabIndex = 8;
            this.sendtbx.Text = "105bfe5916";
            this.sendtbx.TextChanged += new System.EventHandler(this.sendtbx_TextChanged);
            this.sendtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendtbx_KeyPress);
            // 
            // sendbtn
            // 
            this.sendbtn.AutoSize = true;
            this.sendbtn.Enabled = false;
            this.sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.Location = new System.Drawing.Point(431, 467);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(91, 54);
            this.sendbtn.TabIndex = 7;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Received:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Send:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(49, 38);
            this.aboutToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedDataToolStripMenuItem,
            this.sendDataToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 28);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // receivedDataToolStripMenuItem
            // 
            this.receivedDataToolStripMenuItem.Name = "receivedDataToolStripMenuItem";
            this.receivedDataToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.receivedDataToolStripMenuItem.Text = "Received Data...";
            this.receivedDataToolStripMenuItem.Click += new System.EventHandler(this.receivedDataToolStripMenuItem_Click);
            // 
            // sendDataToolStripMenuItem
            // 
            this.sendDataToolStripMenuItem.Name = "sendDataToolStripMenuItem";
            this.sendDataToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.sendDataToolStripMenuItem.Text = "Send Data...";
            this.sendDataToolStripMenuItem.Click += new System.EventHandler(this.sendDataToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(129, 28);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1168, 42);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(71, 38);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 38);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusRx,
            this.toolStripStatusTx,
            this.statusTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1168, 26);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.ActiveLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(382, 20);
            this.statuslabel.Spring = true;
            this.statuslabel.Text = "Not Connected";
            this.statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusRx
            // 
            this.toolStripStatusRx.ActiveLinkColor = System.Drawing.SystemColors.Info;
            this.toolStripStatusRx.Name = "toolStripStatusRx";
            this.toolStripStatusRx.Size = new System.Drawing.Size(382, 20);
            this.toolStripStatusRx.Spring = true;
            this.toolStripStatusRx.Text = "Received:";
            this.toolStripStatusRx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusTx
            // 
            this.toolStripStatusTx.Name = "toolStripStatusTx";
            this.toolStripStatusTx.Size = new System.Drawing.Size(382, 20);
            this.toolStripStatusTx.Spring = true;
            this.toolStripStatusTx.Text = "Sent:";
            this.toolStripStatusTx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTimeLabel
            // 
            this.statusTimeLabel.Name = "statusTimeLabel";
            this.statusTimeLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // statustimer
            // 
            this.statustimer.Enabled = true;
            this.statustimer.Interval = 1000;
            this.statustimer.Tick += new System.EventHandler(this.statustimer_Tick);
            // 
            // autoSendtimer
            // 
            this.autoSendtimer.Interval = 1000;
            this.autoSendtimer.Tick += new System.EventHandler(this.autoSendtimer_Tick);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(21, 401);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(111, 48);
            this.refreshbtn.TabIndex = 22;
            this.refreshbtn.Text = "Refersh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.handshakingcbx);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.refreshbtn);
            this.groupBox2.Controls.Add(this.dataBitsCbx);
            this.groupBox2.Controls.Add(this.comListCbx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.openCloseSpbtn);
            this.groupBox2.Controls.Add(this.baudRateCbx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.parityCbx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.stopBitsCbx);
            this.groupBox2.Location = new System.Drawing.Point(3, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(154, 533);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM";
            // 
            // handshakingcbx
            // 
            this.handshakingcbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.handshakingcbx.FormattingEnabled = true;
            this.handshakingcbx.Location = new System.Drawing.Point(21, 353);
            this.handshakingcbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.handshakingcbx.Name = "handshakingcbx";
            this.handshakingcbx.Size = new System.Drawing.Size(109, 26);
            this.handshakingcbx.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "HandShaking:";
            // 
            // requestButton
            // 
            this.requestButton.Enabled = false;
            this.requestButton.Location = new System.Drawing.Point(154, 17);
            this.requestButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(144, 29);
            this.requestButton.TabIndex = 26;
            this.requestButton.Text = "Get Meter Data";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Decrypted
            // 
            this.Decrypted.Controls.Add(this.orTimeBox);
            this.Decrypted.Controls.Add(this.operationTime);
            this.Decrypted.Controls.Add(this.flowTemp);
            this.Decrypted.Controls.Add(this.reverseFlow);
            this.Decrypted.Controls.Add(this.normalFlow);
            this.Decrypted.Controls.Add(this.manufacturerId);
            this.Decrypted.Controls.Add(this.label25);
            this.Decrypted.Controls.Add(this.label17);
            this.Decrypted.Controls.Add(this.label19);
            this.Decrypted.Controls.Add(this.label21);
            this.Decrypted.Controls.Add(this.label15);
            this.Decrypted.Controls.Add(this.label13);
            this.Decrypted.Controls.Add(this.label11);
            this.Decrypted.Controls.Add(this.label10);
            this.Decrypted.Controls.Add(this.header_label);
            this.Decrypted.Controls.Add(this.deviceNumberBox);
            this.Decrypted.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Decrypted.Location = new System.Drawing.Point(720, 44);
            this.Decrypted.Name = "Decrypted";
            this.Decrypted.Size = new System.Drawing.Size(206, 451);
            this.Decrypted.TabIndex = 29;
            this.Decrypted.TabStop = false;
            this.Decrypted.Text = "Decrypted Data";
            this.Decrypted.Enter += new System.EventHandler(this.Decrypted_Enter);
            // 
            // orTimeBox
            // 
            this.orTimeBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orTimeBox.Location = new System.Drawing.Point(16, 408);
            this.orTimeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orTimeBox.Name = "orTimeBox";
            this.orTimeBox.ReadOnly = true;
            this.orTimeBox.Size = new System.Drawing.Size(178, 30);
            this.orTimeBox.TabIndex = 63;
            // 
            // operationTime
            // 
            this.operationTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.operationTime.Location = new System.Drawing.Point(16, 352);
            this.operationTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operationTime.Name = "operationTime";
            this.operationTime.ReadOnly = true;
            this.operationTime.Size = new System.Drawing.Size(178, 30);
            this.operationTime.TabIndex = 62;
            // 
            // flowTemp
            // 
            this.flowTemp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowTemp.Location = new System.Drawing.Point(15, 292);
            this.flowTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowTemp.Name = "flowTemp";
            this.flowTemp.ReadOnly = true;
            this.flowTemp.Size = new System.Drawing.Size(178, 30);
            this.flowTemp.TabIndex = 61;
            // 
            // reverseFlow
            // 
            this.reverseFlow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reverseFlow.Location = new System.Drawing.Point(14, 232);
            this.reverseFlow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reverseFlow.Name = "reverseFlow";
            this.reverseFlow.ReadOnly = true;
            this.reverseFlow.Size = new System.Drawing.Size(178, 30);
            this.reverseFlow.TabIndex = 60;
            // 
            // normalFlow
            // 
            this.normalFlow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.normalFlow.Location = new System.Drawing.Point(13, 174);
            this.normalFlow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.normalFlow.Name = "normalFlow";
            this.normalFlow.ReadOnly = true;
            this.normalFlow.Size = new System.Drawing.Size(178, 30);
            this.normalFlow.TabIndex = 59;
            // 
            // manufacturerId
            // 
            this.manufacturerId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manufacturerId.Location = new System.Drawing.Point(12, 111);
            this.manufacturerId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manufacturerId.Name = "manufacturerId";
            this.manufacturerId.ReadOnly = true;
            this.manufacturerId.Size = new System.Drawing.Size(178, 30);
            this.manufacturerId.TabIndex = 58;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(12, 387);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 18);
            this.label25.TabIndex = 56;
            this.label25.Text = "Original Time:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 328);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 18);
            this.label17.TabIndex = 55;
            this.label17.Text = "Operation time (h):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 268);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 18);
            this.label19.TabIndex = 54;
            this.label19.Text = "Flow Temperature (C):";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(153, 18);
            this.label21.TabIndex = 53;
            this.label21.Text = "Reverse Flow (m^3):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 18);
            this.label15.TabIndex = 52;
            this.label15.Text = "Normal Flow (m^3):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 18);
            this.label13.TabIndex = 51;
            this.label13.Text = "Manufacturer Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(23, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 18);
            this.label10.TabIndex = 49;
            this.label10.Text = "Device Number:";
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.Location = new System.Drawing.Point(22, 22);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(0, 21);
            this.header_label.TabIndex = 48;
            // 
            // deviceNumberBox
            // 
            this.deviceNumberBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deviceNumberBox.Location = new System.Drawing.Point(12, 55);
            this.deviceNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deviceNumberBox.Name = "deviceNumberBox";
            this.deviceNumberBox.ReadOnly = true;
            this.deviceNumberBox.Size = new System.Drawing.Size(178, 30);
            this.deviceNumberBox.TabIndex = 57;
            this.deviceNumberBox.TextChanged += new System.EventHandler(this.deviceNumberBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker);
            this.groupBox3.Controls.Add(this.send3);
            this.groupBox3.Controls.Add(this.send1);
            this.groupBox3.Controls.Add(this.DateTime);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.labelPrimary);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.primaryAddress);
            this.groupBox3.Location = new System.Drawing.Point(943, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 154);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configure Options";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 115);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(144, 25);
            this.dateTimePicker.TabIndex = 33;
            this.dateTimePicker.Value = new System.DateTime(2011, 9, 1, 13, 42, 0, 0);
            // 
            // send3
            // 
            this.send3.Enabled = false;
            this.send3.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.send3.Location = new System.Drawing.Point(162, 112);
            this.send3.Name = "send3";
            this.send3.Size = new System.Drawing.Size(44, 28);
            this.send3.TabIndex = 78;
            this.send3.Text = "set";
            this.send3.UseVisualStyleBackColor = true;
            this.send3.Click += new System.EventHandler(this.send3_Click);
            // 
            // send1
            // 
            this.send1.Enabled = false;
            this.send1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.send1.Location = new System.Drawing.Point(162, 57);
            this.send1.Name = "send1";
            this.send1.Size = new System.Drawing.Size(44, 26);
            this.send1.TabIndex = 76;
            this.send1.Text = " set";
            this.send1.UseVisualStyleBackColor = true;
            this.send1.Click += new System.EventHandler(this.send1_Click_1);
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.Location = new System.Drawing.Point(8, 90);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(89, 18);
            this.DateTime.TabIndex = 68;
            this.DateTime.Text = "Date - Time";
            this.DateTime.Click += new System.EventHandler(this.label20_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label23.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label23.Location = new System.Drawing.Point(23, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 15);
            this.label23.TabIndex = 66;
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // labelPrimary
            // 
            this.labelPrimary.AutoSize = true;
            this.labelPrimary.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrimary.Location = new System.Drawing.Point(12, 34);
            this.labelPrimary.Name = "labelPrimary";
            this.labelPrimary.Size = new System.Drawing.Size(122, 18);
            this.labelPrimary.TabIndex = 65;
            this.labelPrimary.Text = "Primary Address";
            this.labelPrimary.Click += new System.EventHandler(this.label24_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(22, 24);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 21);
            this.label26.TabIndex = 64;
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // primaryAddress
            // 
            this.primaryAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.primaryAddress.Location = new System.Drawing.Point(12, 57);
            this.primaryAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.primaryAddress.Name = "primaryAddress";
            this.primaryAddress.Size = new System.Drawing.Size(144, 25);
            this.primaryAddress.TabIndex = 73;
            this.primaryAddress.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.statusLabel1);
            this.groupBox4.Location = new System.Drawing.Point(943, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 38);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = true;
            this.statusLabel1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.statusLabel1.Location = new System.Drawing.Point(6, 17);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(16, 15);
            this.statusLabel1.TabIndex = 0;
            this.statusLabel1.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recHexRadiobtn);
            this.panel1.Controls.Add(this.recStrRadiobtn);
            this.panel1.Location = new System.Drawing.Point(304, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 31);
            this.panel1.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1168, 645);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Decrypted);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "COMDBG v1.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Decrypted.ResumeLayout(false);
            this.Decrypted.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comListCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox baudRateCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dataBitsCbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stopBitsCbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox parityCbx;
        private System.Windows.Forms.Button openCloseSpbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton recHexRadiobtn;
        private System.Windows.Forms.RadioButton recStrRadiobtn;
        private System.Windows.Forms.Button clearReceivebtn;
        private System.Windows.Forms.Button clearSendbtn;
        private System.Windows.Forms.TextBox receivetbx;
        private System.Windows.Forms.TextBox sendtbx;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.RadioButton sendHexRadiobtn;
        private System.Windows.Forms.RadioButton sendStrRadiobtn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusRx;
        private System.Windows.Forms.ToolStripStatusLabel statusTimeLabel;
        private System.Windows.Forms.Timer statustimer;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTx;
        private System.Windows.Forms.CheckBox autoSendcbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sendIntervalTimetbx;
        private System.Windows.Forms.Timer autoSendtimer;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox handshakingcbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox addCRCcbx;
        private System.Windows.Forms.CheckBox autoReplyCbx;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.GroupBox Decrypted;
        private System.Windows.Forms.TextBox orTimeBox;
        private System.Windows.Forms.TextBox operationTime;
        private System.Windows.Forms.TextBox flowTemp;
        private System.Windows.Forms.TextBox reverseFlow;
        private System.Windows.Forms.TextBox normalFlow;
        private System.Windows.Forms.TextBox manufacturerId;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.TextBox deviceNumberBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelPrimary;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox primaryAddress;
        private System.Windows.Forms.Button send3;
        private System.Windows.Forms.Button send1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label statusLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}

