namespace CSharpRabbitMQExample.WinForm;

partial class Form1
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
        components = new System.ComponentModel.Container();
        groupBox1 = new GroupBox();
        btnConnect = new Button();
        txtConnectionString = new TextBox();
        label1 = new Label();
        groupBox2 = new GroupBox();
        btnDeclareQueue = new Button();
        txtDeclareQueueName = new TextBox();
        label2 = new Label();
        groupBox3 = new GroupBox();
        btnDeclareExchange = new Button();
        cbDeclareExchangeType = new ComboBox();
        label4 = new Label();
        txtDeclareExchangeName = new TextBox();
        label3 = new Label();
        groupBox4 = new GroupBox();
        btnBindQueue = new Button();
        txtDeclareQueueRoutingKey = new TextBox();
        label5 = new Label();
        pnlMain = new Panel();
        label9 = new Label();
        btnPublish = new Button();
        checkBoxCounter = new CheckBox();
        numericRepeatCount = new NumericUpDown();
        label6 = new Label();
        txtMessage = new RichTextBox();
        txtRoutingKey = new TextBox();
        label8 = new Label();
        txtExchangeName = new TextBox();
        label7 = new Label();
        txtLog = new RichTextBox();
        contextMenuStrip1 = new ContextMenuStrip(components);
        gbQueueExchange = new Panel();
        statusStrip1 = new StatusStrip();
        tsLblConnectionStatus = new ToolStripStatusLabel();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        pnlMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericRepeatCount).BeginInit();
        gbQueueExchange.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnConnect);
        groupBox1.Controls.Add(txtConnectionString);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(661, 90);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Connection";
        // 
        // btnConnect
        // 
        btnConnect.Location = new Point(472, 42);
        btnConnect.Name = "btnConnect";
        btnConnect.Size = new Size(139, 29);
        btnConnect.TabIndex = 8;
        btnConnect.Text = "Connect";
        btnConnect.UseVisualStyleBackColor = true;
        btnConnect.Click += btnConnect_Click;
        // 
        // txtConnectionString
        // 
        txtConnectionString.Location = new Point(143, 42);
        txtConnectionString.Name = "txtConnectionString";
        txtConnectionString.Size = new Size(307, 27);
        txtConnectionString.TabIndex = 7;
        txtConnectionString.Text = "amqp://guest:guest@localhost:5672";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 45);
        label1.Name = "label1";
        label1.Size = new Size(131, 20);
        label1.TabIndex = 6;
        label1.Text = "Connection String ";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnDeclareQueue);
        groupBox2.Controls.Add(txtDeclareQueueName);
        groupBox2.Controls.Add(label2);
        groupBox2.Location = new Point(3, 3);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(309, 171);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Queue / Exchange Declare && Bind";
        // 
        // btnDeclareQueue
        // 
        btnDeclareQueue.Location = new Point(48, 123);
        btnDeclareQueue.Name = "btnDeclareQueue";
        btnDeclareQueue.Size = new Size(182, 29);
        btnDeclareQueue.TabIndex = 10;
        btnDeclareQueue.Text = "Declare";
        btnDeclareQueue.UseVisualStyleBackColor = true;
        btnDeclareQueue.Click += btnDeclareQueue_Click;
        // 
        // txtDeclareQueueName
        // 
        txtDeclareQueueName.Location = new Point(110, 61);
        txtDeclareQueueName.Name = "txtDeclareQueueName";
        txtDeclareQueueName.Size = new Size(182, 27);
        txtDeclareQueueName.TabIndex = 9;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 64);
        label2.Name = "label2";
        label2.Size = new Size(96, 20);
        label2.TabIndex = 8;
        label2.Text = "Queue Name";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(btnDeclareExchange);
        groupBox3.Controls.Add(cbDeclareExchangeType);
        groupBox3.Controls.Add(label4);
        groupBox3.Controls.Add(txtDeclareExchangeName);
        groupBox3.Controls.Add(label3);
        groupBox3.Location = new Point(318, 3);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(340, 171);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Declare Exchange";
        // 
        // btnDeclareExchange
        // 
        btnDeclareExchange.Location = new Point(90, 123);
        btnDeclareExchange.Name = "btnDeclareExchange";
        btnDeclareExchange.Size = new Size(230, 29);
        btnDeclareExchange.TabIndex = 14;
        btnDeclareExchange.Text = "Declare";
        btnDeclareExchange.UseVisualStyleBackColor = true;
        btnDeclareExchange.Click += btnDeclareExchange_Click;
        // 
        // cbDeclareExchangeType
        // 
        cbDeclareExchangeType.FormattingEnabled = true;
        cbDeclareExchangeType.Location = new Point(90, 70);
        cbDeclareExchangeType.Name = "cbDeclareExchangeType";
        cbDeclareExchangeType.Size = new Size(230, 28);
        cbDeclareExchangeType.TabIndex = 13;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(19, 70);
        label4.Name = "label4";
        label4.Size = new Size(40, 20);
        label4.TabIndex = 12;
        label4.Text = "Type";
        // 
        // txtDeclareExchangeName
        // 
        txtDeclareExchangeName.Location = new Point(90, 26);
        txtDeclareExchangeName.Name = "txtDeclareExchangeName";
        txtDeclareExchangeName.Size = new Size(230, 27);
        txtDeclareExchangeName.TabIndex = 11;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(19, 29);
        label3.Name = "label3";
        label3.Size = new Size(49, 20);
        label3.TabIndex = 10;
        label3.Text = "Name";
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btnBindQueue);
        groupBox4.Controls.Add(txtDeclareQueueRoutingKey);
        groupBox4.Controls.Add(label5);
        groupBox4.Location = new Point(127, 180);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(386, 117);
        groupBox4.TabIndex = 3;
        groupBox4.TabStop = false;
        groupBox4.Text = "Bind Queue && Exchange";
        // 
        // btnBindQueue
        // 
        btnBindQueue.Location = new Point(17, 71);
        btnBindQueue.Name = "btnBindQueue";
        btnBindQueue.Size = new Size(348, 33);
        btnBindQueue.TabIndex = 12;
        btnBindQueue.Text = "Bind Queue";
        btnBindQueue.UseVisualStyleBackColor = true;
        btnBindQueue.Click += btnBindQueue_Click;
        // 
        // txtDeclareQueueRoutingKey
        // 
        txtDeclareQueueRoutingKey.Location = new Point(119, 30);
        txtDeclareQueueRoutingKey.Name = "txtDeclareQueueRoutingKey";
        txtDeclareQueueRoutingKey.Size = new Size(246, 27);
        txtDeclareQueueRoutingKey.TabIndex = 11;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(17, 33);
        label5.Name = "label5";
        label5.Size = new Size(89, 20);
        label5.TabIndex = 10;
        label5.Text = "Routing Key";
        // 
        // pnlMain
        // 
        pnlMain.Controls.Add(label9);
        pnlMain.Controls.Add(btnPublish);
        pnlMain.Controls.Add(checkBoxCounter);
        pnlMain.Controls.Add(numericRepeatCount);
        pnlMain.Controls.Add(label6);
        pnlMain.Controls.Add(txtMessage);
        pnlMain.Controls.Add(txtRoutingKey);
        pnlMain.Controls.Add(label8);
        pnlMain.Controls.Add(txtExchangeName);
        pnlMain.Controls.Add(label7);
        pnlMain.Location = new Point(12, 414);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new Size(661, 336);
        pnlMain.TabIndex = 4;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(87, 268);
        label9.Name = "label9";
        label9.Size = new Size(56, 20);
        label9.TabIndex = 23;
        label9.Text = "Repeat";
        // 
        // btnPublish
        // 
        btnPublish.Location = new Point(389, 285);
        btnPublish.Name = "btnPublish";
        btnPublish.Size = new Size(156, 36);
        btnPublish.TabIndex = 22;
        btnPublish.Text = "Publish";
        btnPublish.UseVisualStyleBackColor = true;
        btnPublish.Click += btnPublish_Click;
        // 
        // checkBoxCounter
        // 
        checkBoxCounter.AutoSize = true;
        checkBoxCounter.Location = new Point(261, 292);
        checkBoxCounter.Name = "checkBoxCounter";
        checkBoxCounter.Size = new Size(111, 24);
        checkBoxCounter.TabIndex = 21;
        checkBoxCounter.Text = "Use Counter";
        checkBoxCounter.UseVisualStyleBackColor = true;
        // 
        // numericRepeatCount
        // 
        numericRepeatCount.Location = new Point(87, 291);
        numericRepeatCount.Name = "numericRepeatCount";
        numericRepeatCount.Size = new Size(150, 27);
        numericRepeatCount.TabIndex = 20;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(87, 112);
        label6.Name = "label6";
        label6.Size = new Size(67, 20);
        label6.TabIndex = 19;
        label6.Text = "Message";
        // 
        // txtMessage
        // 
        txtMessage.Location = new Point(87, 135);
        txtMessage.Name = "txtMessage";
        txtMessage.Size = new Size(458, 120);
        txtMessage.TabIndex = 18;
        txtMessage.Text = "";
        // 
        // txtRoutingKey
        // 
        txtRoutingKey.Location = new Point(261, 68);
        txtRoutingKey.Name = "txtRoutingKey";
        txtRoutingKey.Size = new Size(284, 27);
        txtRoutingKey.TabIndex = 17;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(159, 71);
        label8.Name = "label8";
        label8.Size = new Size(89, 20);
        label8.TabIndex = 16;
        label8.Text = "Routing Key";
        // 
        // txtExchangeName
        // 
        txtExchangeName.Location = new Point(261, 25);
        txtExchangeName.Name = "txtExchangeName";
        txtExchangeName.Size = new Size(284, 27);
        txtExchangeName.TabIndex = 15;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(87, 28);
        label7.Name = "label7";
        label7.Size = new Size(161, 20);
        label7.TabIndex = 14;
        label7.Text = "Exchange Name / Type";
        // 
        // txtLog
        // 
        txtLog.BackColor = Color.Black;
        txtLog.ForeColor = Color.DarkGreen;
        txtLog.Location = new Point(12, 756);
        txtLog.Name = "txtLog";
        txtLog.Size = new Size(661, 223);
        txtLog.TabIndex = 5;
        txtLog.Text = "";
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.ImageScalingSize = new Size(20, 20);
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // gbQueueExchange
        // 
        gbQueueExchange.Controls.Add(groupBox3);
        gbQueueExchange.Controls.Add(groupBox4);
        gbQueueExchange.Controls.Add(groupBox2);
        gbQueueExchange.Location = new Point(12, 108);
        gbQueueExchange.Name = "gbQueueExchange";
        gbQueueExchange.Size = new Size(661, 300);
        gbQueueExchange.TabIndex = 6;
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new Size(20, 20);
        statusStrip1.Items.AddRange(new ToolStripItem[] { tsLblConnectionStatus });
        statusStrip1.Location = new Point(0, 983);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(685, 26);
        statusStrip1.TabIndex = 7;
        statusStrip1.Text = "statusStrip1";
        // 
        // tsLblConnectionStatus
        // 
        tsLblConnectionStatus.Name = "tsLblConnectionStatus";
        tsLblConnectionStatus.Size = new Size(229, 20);
        tsLblConnectionStatus.Text = "Connection State: Not Connected";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685, 1009);
        Controls.Add(statusStrip1);
        Controls.Add(gbQueueExchange);
        Controls.Add(txtLog);
        Controls.Add(pnlMain);
        Controls.Add(groupBox1);
        Name = "Form1";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        pnlMain.ResumeLayout(false);
        pnlMain.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericRepeatCount).EndInit();
        gbQueueExchange.ResumeLayout(false);
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private TextBox txtConnectionString;
    private Label label1;
    private Panel pnlMain;
    private RichTextBox txtLog;
    private Button btnConnect;
    private Button btnDeclareQueue;
    private TextBox txtDeclareQueueName;
    private Label label2;
    private ComboBox cbDeclareExchangeType;
    private Label label4;
    private TextBox txtDeclareExchangeName;
    private Label label3;
    private ContextMenuStrip contextMenuStrip1;
    private Button btnDeclareExchange;
    private Button btnBindQueue;
    private TextBox txtDeclareQueueRoutingKey;
    private Label label5;
    private TextBox txtRoutingKey;
    private Label label8;
    private TextBox txtExchangeName;
    private Label label7;
    private Label label9;
    private Button btnPublish;
    private CheckBox checkBoxCounter;
    private NumericUpDown numericRepeatCount;
    private Label label6;
    private RichTextBox txtMessage;
    private Panel gbQueueExchange;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel tsLblConnectionStatus;
}
