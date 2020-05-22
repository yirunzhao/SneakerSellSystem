namespace SneakerSellSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.tsTask = new System.Windows.Forms.ToolStrip();
            this.tsBtnMemInfo = new System.Windows.Forms.ToolStripButton();
            this.tsLblMemInfo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnExpInfo = new System.Windows.Forms.ToolStripButton();
            this.tsLblExpInfo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnHistory = new System.Windows.Forms.ToolStripButton();
            this.tsLblHistory = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnLottery = new System.Windows.Forms.ToolStripButton();
            this.tsLblLottery = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAdmin = new System.Windows.Forms.ToolStripDropDownButton();
            this.查看信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新物流信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看商品库存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLblAdmin = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.tsLblHelp = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsLblExit = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssBlank1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUserDisp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssBlank2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssBlank3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTimeDisp = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlBuy = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLater = new System.Windows.Forms.Label();
            this.lblFormer = new System.Windows.Forms.Label();
            this.lblCata2 = new System.Windows.Forms.Label();
            this.lblCata1 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.btnBuy2 = new System.Windows.Forms.Button();
            this.btnBuy1 = new System.Windows.Forms.Button();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsTask.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // tsTask
            // 
            this.tsTask.BackColor = System.Drawing.Color.Transparent;
            this.tsTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsTask.BackgroundImage")));
            this.tsTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsTask.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnMemInfo,
            this.tsLblMemInfo,
            this.toolStripSeparator1,
            this.tsBtnExpInfo,
            this.tsLblExpInfo,
            this.toolStripSeparator2,
            this.tsBtnHistory,
            this.tsLblHistory,
            this.toolStripSeparator3,
            this.tsBtnLottery,
            this.tsLblLottery,
            this.toolStripSeparator4,
            this.tsBtnAdmin,
            this.tsLblAdmin,
            this.toolStripSeparator5,
            this.tsBtnHelp,
            this.tsLblHelp,
            this.toolStripSeparator6,
            this.tsBtnExit,
            this.tsLblExit});
            this.tsTask.Location = new System.Drawing.Point(0, 0);
            this.tsTask.Name = "tsTask";
            this.tsTask.Size = new System.Drawing.Size(85, 563);
            this.tsTask.TabIndex = 0;
            this.tsTask.Text = "toolStrip1";
            // 
            // tsBtnMemInfo
            // 
            this.tsBtnMemInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnMemInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMemInfo.Image")));
            this.tsBtnMemInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnMemInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMemInfo.Name = "tsBtnMemInfo";
            this.tsBtnMemInfo.Size = new System.Drawing.Size(82, 47);
            this.tsBtnMemInfo.Text = "我的信息";
            this.tsBtnMemInfo.Click += new System.EventHandler(this.tsBtnMemInfo_Click);
            // 
            // tsLblMemInfo
            // 
            this.tsLblMemInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.tsLblMemInfo.Name = "tsLblMemInfo";
            this.tsLblMemInfo.Size = new System.Drawing.Size(82, 20);
            this.tsLblMemInfo.Text = "我的信息";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(82, 6);
            // 
            // tsBtnExpInfo
            // 
            this.tsBtnExpInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnExpInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExpInfo.Image")));
            this.tsBtnExpInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnExpInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExpInfo.Name = "tsBtnExpInfo";
            this.tsBtnExpInfo.Size = new System.Drawing.Size(82, 48);
            this.tsBtnExpInfo.Text = "物流信息";
            this.tsBtnExpInfo.Click += new System.EventHandler(this.tsBtnExpInfo_Click);
            // 
            // tsLblExpInfo
            // 
            this.tsLblExpInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.tsLblExpInfo.Name = "tsLblExpInfo";
            this.tsLblExpInfo.Size = new System.Drawing.Size(82, 20);
            this.tsLblExpInfo.Text = "物流信息";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(82, 6);
            // 
            // tsBtnHistory
            // 
            this.tsBtnHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnHistory.Image")));
            this.tsBtnHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHistory.Name = "tsBtnHistory";
            this.tsBtnHistory.Size = new System.Drawing.Size(82, 48);
            this.tsBtnHistory.Text = "购买记录";
            this.tsBtnHistory.Click += new System.EventHandler(this.tsBtnHistory_Click);
            // 
            // tsLblHistory
            // 
            this.tsLblHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.tsLblHistory.Name = "tsLblHistory";
            this.tsLblHistory.Size = new System.Drawing.Size(82, 20);
            this.tsLblHistory.Text = "购买记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(82, 6);
            // 
            // tsBtnLottery
            // 
            this.tsBtnLottery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnLottery.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLottery.Image")));
            this.tsBtnLottery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnLottery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLottery.Name = "tsBtnLottery";
            this.tsBtnLottery.Size = new System.Drawing.Size(82, 48);
            this.tsBtnLottery.Text = "抽奖活动";
            this.tsBtnLottery.Click += new System.EventHandler(this.tsBtnLottery_Click);
            // 
            // tsLblLottery
            // 
            this.tsLblLottery.ForeColor = System.Drawing.SystemColors.Control;
            this.tsLblLottery.Name = "tsLblLottery";
            this.tsLblLottery.Size = new System.Drawing.Size(82, 20);
            this.tsLblLottery.Text = "抽奖活动";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(82, 6);
            // 
            // tsBtnAdmin
            // 
            this.tsBtnAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看信息ToolStripMenuItem,
            this.更新物流信息ToolStripMenuItem,
            this.查看商品库存ToolStripMenuItem});
            this.tsBtnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAdmin.Image")));
            this.tsBtnAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdmin.Name = "tsBtnAdmin";
            this.tsBtnAdmin.Size = new System.Drawing.Size(82, 48);
            this.tsBtnAdmin.Text = "管理员设置";
            // 
            // 查看信息ToolStripMenuItem
            // 
            this.查看信息ToolStripMenuItem.Name = "查看信息ToolStripMenuItem";
            this.查看信息ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.查看信息ToolStripMenuItem.Text = "查看所有会员信息";
            this.查看信息ToolStripMenuItem.Click += new System.EventHandler(this.查看信息ToolStripMenuItem_Click);
            // 
            // 更新物流信息ToolStripMenuItem
            // 
            this.更新物流信息ToolStripMenuItem.Name = "更新物流信息ToolStripMenuItem";
            this.更新物流信息ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.更新物流信息ToolStripMenuItem.Text = "更新物流信息";
            this.更新物流信息ToolStripMenuItem.Click += new System.EventHandler(this.更新物流信息ToolStripMenuItem_Click);
            // 
            // 查看商品库存ToolStripMenuItem
            // 
            this.查看商品库存ToolStripMenuItem.Name = "查看商品库存ToolStripMenuItem";
            this.查看商品库存ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.查看商品库存ToolStripMenuItem.Text = "查看商品库存";
            this.查看商品库存ToolStripMenuItem.Click += new System.EventHandler(this.查看商品库存ToolStripMenuItem_Click);
            // 
            // tsLblAdmin
            // 
            this.tsLblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.tsLblAdmin.Name = "tsLblAdmin";
            this.tsLblAdmin.Size = new System.Drawing.Size(82, 20);
            this.tsLblAdmin.Text = "管理员设置";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(82, 6);
            // 
            // tsBtnHelp
            // 
            this.tsBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnHelp.Image")));
            this.tsBtnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHelp.Name = "tsBtnHelp";
            this.tsBtnHelp.Size = new System.Drawing.Size(82, 47);
            this.tsBtnHelp.Text = "帮助";
            this.tsBtnHelp.Click += new System.EventHandler(this.tsBtnHelp_Click);
            // 
            // tsLblHelp
            // 
            this.tsLblHelp.ForeColor = System.Drawing.SystemColors.Control;
            this.tsLblHelp.Name = "tsLblHelp";
            this.tsLblHelp.Size = new System.Drawing.Size(82, 20);
            this.tsLblHelp.Text = "帮助";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(82, 6);
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExit.Image")));
            this.tsBtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(82, 47);
            this.tsBtnExit.Text = "退出";
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // tsLblExit
            // 
            this.tsLblExit.ForeColor = System.Drawing.SystemColors.Control;
            this.tsLblExit.Name = "tsLblExit";
            this.tsLblExit.Size = new System.Drawing.Size(82, 20);
            this.tsLblExit.Text = "退出";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUser,
            this.tssBlank1,
            this.tssUserDisp,
            this.tssBlank2,
            this.tssTime,
            this.tssBlank3,
            this.tssTimeDisp});
            this.statusStrip1.Location = new System.Drawing.Point(85, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(857, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUser
            // 
            this.tssUser.Name = "tssUser";
            this.tssUser.Size = new System.Drawing.Size(77, 20);
            this.tssUser.Text = "当前用户 :";
            // 
            // tssBlank1
            // 
            this.tssBlank1.Name = "tssBlank1";
            this.tssBlank1.Size = new System.Drawing.Size(57, 20);
            this.tssBlank1.Text = "            ";
            // 
            // tssUserDisp
            // 
            this.tssUserDisp.Name = "tssUserDisp";
            this.tssUserDisp.Size = new System.Drawing.Size(40, 20);
            this.tssUserDisp.Text = "user";
            // 
            // tssBlank2
            // 
            this.tssBlank2.Name = "tssBlank2";
            this.tssBlank2.Size = new System.Drawing.Size(205, 20);
            this.tssBlank2.Text = "                                                 ";
            // 
            // tssTime
            // 
            this.tssTime.Name = "tssTime";
            this.tssTime.Size = new System.Drawing.Size(77, 20);
            this.tssTime.Text = "当前时间 :";
            // 
            // tssBlank3
            // 
            this.tssBlank3.Name = "tssBlank3";
            this.tssBlank3.Size = new System.Drawing.Size(53, 20);
            this.tssBlank3.Text = "           ";
            // 
            // tssTimeDisp
            // 
            this.tssTimeDisp.Name = "tssTimeDisp";
            this.tssTimeDisp.Size = new System.Drawing.Size(42, 20);
            this.tssTimeDisp.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlBuy
            // 
            this.pnlBuy.BackColor = System.Drawing.Color.White;
            this.pnlBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBuy.Controls.Add(this.label2);
            this.pnlBuy.Controls.Add(this.label1);
            this.pnlBuy.Controls.Add(this.lblLater);
            this.pnlBuy.Controls.Add(this.lblFormer);
            this.pnlBuy.Controls.Add(this.lblCata2);
            this.pnlBuy.Controls.Add(this.lblCata1);
            this.pnlBuy.Controls.Add(this.lblPrice2);
            this.pnlBuy.Controls.Add(this.lblName2);
            this.pnlBuy.Controls.Add(this.btnBuy2);
            this.pnlBuy.Controls.Add(this.btnBuy1);
            this.pnlBuy.Controls.Add(this.lblPrice1);
            this.pnlBuy.Controls.Add(this.lblName1);
            this.pnlBuy.Controls.Add(this.pictureBox2);
            this.pnlBuy.Controls.Add(this.pictureBox1);
            this.pnlBuy.Location = new System.Drawing.Point(88, 12);
            this.pnlBuy.Name = "pnlBuy";
            this.pnlBuy.Size = new System.Drawing.Size(842, 511);
            this.pnlBuy.TabIndex = 4;
            this.pnlBuy.Tag = "9999";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(594, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "￥";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(138, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "￥";
            // 
            // lblLater
            // 
            this.lblLater.AutoSize = true;
            this.lblLater.BackColor = System.Drawing.Color.White;
            this.lblLater.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLater.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLater.Location = new System.Drawing.Point(734, 471);
            this.lblLater.Name = "lblLater";
            this.lblLater.Size = new System.Drawing.Size(54, 20);
            this.lblLater.TabIndex = 11;
            this.lblLater.Tag = "";
            this.lblLater.Text = "下一页";
            this.lblLater.Click += new System.EventHandler(this.lblLater_Click);
            this.lblLater.MouseEnter += new System.EventHandler(this.lblLater_MouseEnter);
            this.lblLater.MouseLeave += new System.EventHandler(this.lblLater_MouseLeave);
            // 
            // lblFormer
            // 
            this.lblFormer.AutoSize = true;
            this.lblFormer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFormer.Location = new System.Drawing.Point(26, 471);
            this.lblFormer.Name = "lblFormer";
            this.lblFormer.Size = new System.Drawing.Size(54, 20);
            this.lblFormer.TabIndex = 10;
            this.lblFormer.Text = "上一页";
            this.lblFormer.Click += new System.EventHandler(this.lblFormer_Click);
            this.lblFormer.MouseEnter += new System.EventHandler(this.lblFormer_MouseEnter);
            this.lblFormer.MouseLeave += new System.EventHandler(this.lblFormer_MouseLeave);
            // 
            // lblCata2
            // 
            this.lblCata2.AutoSize = true;
            this.lblCata2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCata2.Location = new System.Drawing.Point(600, 327);
            this.lblCata2.Name = "lblCata2";
            this.lblCata2.Size = new System.Drawing.Size(69, 20);
            this.lblCata2.TabIndex = 9;
            this.lblCata2.Text = "篮球鞋";
            // 
            // lblCata1
            // 
            this.lblCata1.AutoSize = true;
            this.lblCata1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCata1.Location = new System.Drawing.Point(151, 327);
            this.lblCata1.Name = "lblCata1";
            this.lblCata1.Size = new System.Drawing.Size(69, 20);
            this.lblCata1.TabIndex = 8;
            this.lblCata1.Text = "篮球鞋";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice2.Location = new System.Drawing.Point(620, 368);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(49, 20);
            this.lblPrice2.TabIndex = 7;
            this.lblPrice2.Text = "3000";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName2.Location = new System.Drawing.Point(539, 292);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(189, 20);
            this.lblName2.TabIndex = 6;
            this.lblName2.Text = "Air Jordan1 小闪电";
            // 
            // btnBuy2
            // 
            this.btnBuy2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBuy2.Location = new System.Drawing.Point(576, 408);
            this.btnBuy2.Name = "btnBuy2";
            this.btnBuy2.Size = new System.Drawing.Size(114, 34);
            this.btnBuy2.TabIndex = 5;
            this.btnBuy2.Tag = "";
            this.btnBuy2.Text = "购买";
            this.btnBuy2.UseVisualStyleBackColor = true;
            this.btnBuy2.Click += new System.EventHandler(this.btnBuy2_Click);
            // 
            // btnBuy1
            // 
            this.btnBuy1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBuy1.Location = new System.Drawing.Point(131, 408);
            this.btnBuy1.Name = "btnBuy1";
            this.btnBuy1.Size = new System.Drawing.Size(114, 34);
            this.btnBuy1.TabIndex = 4;
            this.btnBuy1.Text = "购买";
            this.btnBuy1.UseVisualStyleBackColor = true;
            this.btnBuy1.Click += new System.EventHandler(this.btnBuy1_Click);
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice1.Location = new System.Drawing.Point(161, 368);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(49, 20);
            this.lblPrice1.TabIndex = 3;
            this.lblPrice1.Text = "1900";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName1.Location = new System.Drawing.Point(92, 292);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(209, 20);
            this.lblName1.TabIndex = 2;
            this.lblName1.Text = "Air Jordan1 体育画报";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(456, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(942, 563);
            this.Controls.Add(this.pnlBuy);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySneaker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tsTask.ResumeLayout(false);
            this.tsTask.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlBuy.ResumeLayout(false);
            this.pnlBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStrip tsTask;
        private System.Windows.Forms.ToolStripButton tsBtnMemInfo;
        private System.Windows.Forms.ToolStripLabel tsLblMemInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnExpInfo;
        private System.Windows.Forms.ToolStripLabel tsLblExpInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnHistory;
        private System.Windows.Forms.ToolStripLabel tsLblHistory;
        private System.Windows.Forms.ToolStripButton tsBtnLottery;
        private System.Windows.Forms.ToolStripLabel tsLblLottery;
        private System.Windows.Forms.ToolStripLabel tsLblAdmin;
        private System.Windows.Forms.ToolStripDropDownButton tsBtnAdmin;
        private System.Windows.Forms.ToolStripMenuItem 查看信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新物流信息ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssUser;
        private System.Windows.Forms.ToolStripStatusLabel tssBlank1;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.ToolStripLabel tsLblExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsBtnHelp;
        private System.Windows.Forms.ToolStripLabel tsLblHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel tssUserDisp;
        private System.Windows.Forms.ToolStripStatusLabel tssBlank2;
        private System.Windows.Forms.ToolStripStatusLabel tssTime;
        private System.Windows.Forms.ToolStripStatusLabel tssBlank3;
        private System.Windows.Forms.ToolStripStatusLabel tssTimeDisp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlBuy;
        private System.Windows.Forms.ToolStripMenuItem 查看商品库存ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Button btnBuy2;
        private System.Windows.Forms.Button btnBuy1;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblCata2;
        private System.Windows.Forms.Label lblCata1;
        private System.Windows.Forms.Label lblLater;
        private System.Windows.Forms.Label lblFormer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}