namespace SneakerSellSystem
{
    partial class MyInfoForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMid = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbMid = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.tbBal = new System.Windows.Forms.TextBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.tbPoint = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnKe = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(24, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "用户名";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(24, 126);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(52, 27);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblAddr.Location = new System.Drawing.Point(24, 186);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(52, 27);
            this.lblAddr.TabIndex = 2;
            this.lblAddr.Text = "地址";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblPhone.Location = new System.Drawing.Point(24, 242);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(92, 27);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "联系电话";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblEmail.Location = new System.Drawing.Point(24, 299);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 27);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "邮箱";
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMid.Location = new System.Drawing.Point(24, 25);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(72, 27);
            this.lblMid.TabIndex = 5;
            this.lblMid.Text = "会员号";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(340, 517);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 37);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "更新信息";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbMid
            // 
            this.tbMid.Enabled = false;
            this.tbMid.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMid.Location = new System.Drawing.Point(131, 25);
            this.tbMid.Name = "tbMid";
            this.tbMid.Size = new System.Drawing.Size(320, 29);
            this.tbMid.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbName.Location = new System.Drawing.Point(131, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(320, 29);
            this.tbName.TabIndex = 8;
            // 
            // tbPwd
            // 
            this.tbPwd.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbPwd.Location = new System.Drawing.Point(131, 131);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(320, 29);
            this.tbPwd.TabIndex = 9;
            // 
            // tbAddr
            // 
            this.tbAddr.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbAddr.Location = new System.Drawing.Point(131, 186);
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.Size = new System.Drawing.Size(320, 29);
            this.tbAddr.TabIndex = 10;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbPhone.Location = new System.Drawing.Point(131, 240);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(320, 29);
            this.tbPhone.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbEmail.Location = new System.Drawing.Point(131, 297);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(320, 29);
            this.tbEmail.TabIndex = 12;
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
            // tbLevel
            // 
            this.tbLevel.Enabled = false;
            this.tbLevel.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbLevel.Location = new System.Drawing.Point(131, 357);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(320, 29);
            this.tbLevel.TabIndex = 14;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblLevel.Location = new System.Drawing.Point(24, 357);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(92, 27);
            this.lblLevel.TabIndex = 13;
            this.lblLevel.Text = "会员等级";
            // 
            // tbBal
            // 
            this.tbBal.Enabled = false;
            this.tbBal.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbBal.Location = new System.Drawing.Point(131, 410);
            this.tbBal.Name = "tbBal";
            this.tbBal.Size = new System.Drawing.Size(320, 29);
            this.tbBal.TabIndex = 16;
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblBal.Location = new System.Drawing.Point(24, 410);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(52, 27);
            this.lblBal.TabIndex = 15;
            this.lblBal.Text = "余额";
            // 
            // tbPoint
            // 
            this.tbPoint.Enabled = false;
            this.tbPoint.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbPoint.Location = new System.Drawing.Point(131, 468);
            this.tbPoint.Name = "tbPoint";
            this.tbPoint.Size = new System.Drawing.Size(320, 29);
            this.tbPoint.TabIndex = 18;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblPoint.Location = new System.Drawing.Point(24, 468);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(92, 27);
            this.lblPoint.TabIndex = 17;
            this.lblPoint.Text = "会员积分";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(29, 517);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(87, 37);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "注销账号";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnKe
            // 
            this.btnKe.Location = new System.Drawing.Point(131, 517);
            this.btnKe.Name = "btnKe";
            this.btnKe.Size = new System.Drawing.Size(96, 37);
            this.btnKe.TabIndex = 20;
            this.btnKe.Text = "氪金1000元";
            this.btnKe.UseVisualStyleBackColor = true;
            this.btnKe.Click += new System.EventHandler(this.btnKe_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(233, 517);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(101, 37);
            this.btnRef.TabIndex = 21;
            this.btnRef.Text = "刷新信息";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // MyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 566);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnKe);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbPoint);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.tbBal);
            this.Controls.Add(this.lblBal);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbAddr);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblMid);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Name = "MyInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的信息";
            this.Load += new System.EventHandler(this.MyInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbMid;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox tbBal;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.TextBox tbPoint;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnKe;
        private System.Windows.Forms.Button btnRef;
    }
}