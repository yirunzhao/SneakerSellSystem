namespace SneakerSellSystem
{
    partial class RegisterForm
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
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbReg = new System.Windows.Forms.GroupBox();
            this.tbPwdC = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnRst = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbReg.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入您的用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入您的地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "请输入您的联系电话";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "请输入您的邮箱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(18, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "请输入您的密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(18, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "请确认密码";
            // 
            // gbReg
            // 
            this.gbReg.Controls.Add(this.tbPwdC);
            this.gbReg.Controls.Add(this.tbPwd);
            this.gbReg.Controls.Add(this.tbEmail);
            this.gbReg.Controls.Add(this.tbPhone);
            this.gbReg.Controls.Add(this.tbAdd);
            this.gbReg.Controls.Add(this.tbName);
            this.gbReg.Controls.Add(this.label6);
            this.gbReg.Controls.Add(this.label5);
            this.gbReg.Controls.Add(this.label4);
            this.gbReg.Controls.Add(this.label3);
            this.gbReg.Controls.Add(this.label2);
            this.gbReg.Controls.Add(this.label1);
            this.gbReg.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbReg.Location = new System.Drawing.Point(23, 21);
            this.gbReg.Name = "gbReg";
            this.gbReg.Size = new System.Drawing.Size(478, 294);
            this.gbReg.TabIndex = 6;
            this.gbReg.TabStop = false;
            this.gbReg.Text = "新用户注册";
            // 
            // tbPwdC
            // 
            this.tbPwdC.Location = new System.Drawing.Point(223, 250);
            this.tbPwdC.Name = "tbPwdC";
            this.tbPwdC.Size = new System.Drawing.Size(193, 24);
            this.tbPwdC.TabIndex = 9;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(223, 205);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(193, 24);
            this.tbPwd.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(223, 156);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(193, 24);
            this.tbEmail.TabIndex = 7;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(223, 112);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(193, 24);
            this.tbPhone.TabIndex = 6;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(223, 65);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(193, 24);
            this.tbAdd.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(223, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 24);
            this.tbName.TabIndex = 4;
            // 
            // btnRst
            // 
            this.btnRst.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRst.Location = new System.Drawing.Point(43, 325);
            this.btnRst.Name = "btnRst";
            this.btnRst.Size = new System.Drawing.Size(146, 39);
            this.btnRst.TabIndex = 11;
            this.btnRst.Text = "重置";
            this.btnRst.UseVisualStyleBackColor = true;
            this.btnRst.Click += new System.EventHandler(this.btnRst_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(246, 326);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(192, 37);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 373);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRst);
            this.Controls.Add(this.gbReg);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.gbReg.ResumeLayout(false);
            this.gbReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbReg;
        private System.Windows.Forms.TextBox tbPwdC;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnRst;
        private System.Windows.Forms.Button btnConfirm;
    }
}