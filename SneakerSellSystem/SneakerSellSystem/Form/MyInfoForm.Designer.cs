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
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(18, 59);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "用户名";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(18, 101);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(42, 21);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblAddr.Location = new System.Drawing.Point(18, 149);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(42, 21);
            this.lblAddr.TabIndex = 2;
            this.lblAddr.Text = "地址";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblPhone.Location = new System.Drawing.Point(18, 194);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 21);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "联系电话";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblEmail.Location = new System.Drawing.Point(18, 239);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 21);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "邮箱";
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMid.Location = new System.Drawing.Point(18, 20);
            this.lblMid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(58, 21);
            this.lblMid.TabIndex = 5;
            this.lblMid.Text = "会员号";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(235, 414);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "更新信息";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbMid
            // 
            this.tbMid.Enabled = false;
            this.tbMid.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMid.Location = new System.Drawing.Point(98, 20);
            this.tbMid.Margin = new System.Windows.Forms.Padding(2);
            this.tbMid.Name = "tbMid";
            this.tbMid.Size = new System.Drawing.Size(241, 24);
            this.tbMid.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbName.Location = new System.Drawing.Point(98, 63);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(241, 24);
            this.tbName.TabIndex = 8;
            // 
            // tbPwd
            // 
            this.tbPwd.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbPwd.Location = new System.Drawing.Point(98, 105);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(2);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(241, 24);
            this.tbPwd.TabIndex = 9;
            // 
            // tbAddr
            // 
            this.tbAddr.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbAddr.Location = new System.Drawing.Point(98, 149);
            this.tbAddr.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.Size = new System.Drawing.Size(241, 24);
            this.tbAddr.TabIndex = 10;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbPhone.Location = new System.Drawing.Point(98, 192);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(241, 24);
            this.tbPhone.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbEmail.Location = new System.Drawing.Point(98, 238);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(241, 24);
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
            this.tbLevel.Location = new System.Drawing.Point(98, 286);
            this.tbLevel.Margin = new System.Windows.Forms.Padding(2);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(241, 24);
            this.tbLevel.TabIndex = 14;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblLevel.Location = new System.Drawing.Point(18, 286);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(74, 21);
            this.lblLevel.TabIndex = 13;
            this.lblLevel.Text = "会员等级";
            // 
            // tbBal
            // 
            this.tbBal.Enabled = false;
            this.tbBal.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbBal.Location = new System.Drawing.Point(98, 328);
            this.tbBal.Margin = new System.Windows.Forms.Padding(2);
            this.tbBal.Name = "tbBal";
            this.tbBal.Size = new System.Drawing.Size(241, 24);
            this.tbBal.TabIndex = 16;
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblBal.Location = new System.Drawing.Point(18, 328);
            this.lblBal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(42, 21);
            this.lblBal.TabIndex = 15;
            this.lblBal.Text = "余额";
            // 
            // tbPoint
            // 
            this.tbPoint.Enabled = false;
            this.tbPoint.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.tbPoint.Location = new System.Drawing.Point(98, 374);
            this.tbPoint.Margin = new System.Windows.Forms.Padding(2);
            this.tbPoint.Name = "tbPoint";
            this.tbPoint.Size = new System.Drawing.Size(241, 24);
            this.tbPoint.TabIndex = 18;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblPoint.Location = new System.Drawing.Point(18, 374);
            this.lblPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(74, 21);
            this.lblPoint.TabIndex = 17;
            this.lblPoint.Text = "会员积分";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(22, 414);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(88, 30);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "注销账号";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnKe
            // 
            this.btnKe.Location = new System.Drawing.Point(126, 414);
            this.btnKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnKe.Name = "btnKe";
            this.btnKe.Size = new System.Drawing.Size(95, 30);
            this.btnKe.TabIndex = 20;
            this.btnKe.Text = "氪金1000元";
            this.btnKe.UseVisualStyleBackColor = true;
            this.btnKe.Click += new System.EventHandler(this.btnKe_Click);
            // 
            // MyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 453);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}