namespace SneakerSellSystem
{
    partial class LandForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panelTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandForm));
            this.panelMin = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.PwdTextBox = new System.Windows.Forms.TextBox();
            this.btnLand = new System.Windows.Forms.Button();
            this.btnRigst = new System.Windows.Forms.Button();
            panelTitle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = System.Drawing.Color.Transparent;
            panelTitle.Location = new System.Drawing.Point(1, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new System.Drawing.Size(580, 30);
            panelTitle.TabIndex = 0;
            panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            // 
            // panelMin
            // 
            this.panelMin.BackColor = System.Drawing.Color.Transparent;
            this.panelMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMin.BackgroundImage")));
            this.panelMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMin.Location = new System.Drawing.Point(580, 0);
            this.panelMin.Name = "panelMin";
            this.panelMin.Size = new System.Drawing.Size(35, 30);
            this.panelMin.TabIndex = 1;
            this.panelMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMin_MouseDown);
            this.panelMin.MouseEnter += new System.EventHandler(this.panelMin_MouseEnter);
            this.panelMin.MouseLeave += new System.EventHandler(this.panelMin_MouseLeave);
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClose.BackgroundImage")));
            this.panelClose.Location = new System.Drawing.Point(614, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(36, 30);
            this.panelClose.TabIndex = 2;
            this.panelClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseDown);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(172, 260);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(225, 30);
            this.nameTextBox.TabIndex = 3;
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdTextBox.Location = new System.Drawing.Point(172, 302);
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.PasswordChar = '*';
            this.PwdTextBox.Size = new System.Drawing.Size(225, 30);
            this.PwdTextBox.TabIndex = 4;
            // 
            // btnLand
            // 
            this.btnLand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(181)))), ((int)(((byte)(205)))));
            this.btnLand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(181)))), ((int)(((byte)(205)))));
            this.btnLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLand.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLand.Location = new System.Drawing.Point(172, 348);
            this.btnLand.Name = "btnLand";
            this.btnLand.Size = new System.Drawing.Size(225, 35);
            this.btnLand.TabIndex = 5;
            this.btnLand.Text = "登陆";
            this.btnLand.UseVisualStyleBackColor = false;
            this.btnLand.Click += new System.EventHandler(this.btnLand_Click);
            // 
            // btnRigst
            // 
            this.btnRigst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(181)))), ((int)(((byte)(205)))));
            this.btnRigst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(181)))), ((int)(((byte)(205)))));
            this.btnRigst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRigst.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRigst.Location = new System.Drawing.Point(54, 348);
            this.btnRigst.Name = "btnRigst";
            this.btnRigst.Size = new System.Drawing.Size(102, 35);
            this.btnRigst.TabIndex = 6;
            this.btnRigst.Text = "注册";
            this.btnRigst.UseVisualStyleBackColor = false;
            this.btnRigst.Click += new System.EventHandler(this.btnRigst_Click);
            // 
            // LandForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.btnRigst);
            this.Controls.Add(this.btnLand);
            this.Controls.Add(this.PwdTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.panelClose);
            this.Controls.Add(this.panelMin);
            this.Controls.Add(panelTitle);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LandForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMin;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox PwdTextBox;
        private System.Windows.Forms.Button btnLand;
        private System.Windows.Forms.Button btnRigst;
    }
}

