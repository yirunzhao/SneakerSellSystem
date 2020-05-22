namespace SneakerSellSystem
{
    partial class ExpForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbBuyer = new System.Windows.Forms.TextBox();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.tbShoe = new System.Windows.Forms.TextBox();
            this.lblShoe = new System.Windows.Forms.Label();
            this.cbbShoe = new System.Windows.Forms.ComboBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.tbExp = new System.Windows.Forms.TextBox();
            this.lblExp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.Location = new System.Drawing.Point(19, 65);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "交易状态";
            // 
            // tbStatus
            // 
            this.tbStatus.Enabled = false;
            this.tbStatus.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStatus.Location = new System.Drawing.Point(106, 62);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(190, 27);
            this.tbStatus.TabIndex = 1;
            // 
            // tbBuyer
            // 
            this.tbBuyer.Enabled = false;
            this.tbBuyer.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbBuyer.Location = new System.Drawing.Point(105, 124);
            this.tbBuyer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBuyer.Name = "tbBuyer";
            this.tbBuyer.Size = new System.Drawing.Size(190, 27);
            this.tbBuyer.TabIndex = 3;
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyer.Location = new System.Drawing.Point(18, 126);
            this.lblBuyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(69, 20);
            this.lblBuyer.TabIndex = 2;
            this.lblBuyer.Text = "买家账号";
            // 
            // tbShoe
            // 
            this.tbShoe.Enabled = false;
            this.tbShoe.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShoe.Location = new System.Drawing.Point(105, 191);
            this.tbShoe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbShoe.Name = "tbShoe";
            this.tbShoe.Size = new System.Drawing.Size(190, 24);
            this.tbShoe.TabIndex = 7;
            // 
            // lblShoe
            // 
            this.lblShoe.AutoSize = true;
            this.lblShoe.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShoe.Location = new System.Drawing.Point(18, 194);
            this.lblShoe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShoe.Name = "lblShoe";
            this.lblShoe.Size = new System.Drawing.Size(54, 20);
            this.lblShoe.TabIndex = 6;
            this.lblShoe.Text = "商品名";
            // 
            // cbbShoe
            // 
            this.cbbShoe.FormattingEnabled = true;
            this.cbbShoe.Location = new System.Drawing.Point(22, 19);
            this.cbbShoe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbShoe.Name = "cbbShoe";
            this.cbbShoe.Size = new System.Drawing.Size(273, 20);
            this.cbbShoe.TabIndex = 8;
            this.cbbShoe.SelectedIndexChanged += new System.EventHandler(this.cbbShoe_SelectedIndexChanged);
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
            // tbExp
            // 
            this.tbExp.Enabled = false;
            this.tbExp.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExp.Location = new System.Drawing.Point(106, 255);
            this.tbExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbExp.Name = "tbExp";
            this.tbExp.Size = new System.Drawing.Size(190, 24);
            this.tbExp.TabIndex = 10;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExp.Location = new System.Drawing.Point(19, 258);
            this.lblExp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(69, 20);
            this.lblExp.TabIndex = 9;
            this.lblExp.Text = "物流公司";
            // 
            // ExpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 305);
            this.Controls.Add(this.tbExp);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.cbbShoe);
            this.Controls.Add(this.tbShoe);
            this.Controls.Add(this.lblShoe);
            this.Controls.Add(this.tbBuyer);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lblStatus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物流信息";
            this.Load += new System.EventHandler(this.ExpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbBuyer;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.TextBox tbShoe;
        private System.Windows.Forms.Label lblShoe;
        private System.Windows.Forms.ComboBox cbbShoe;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TextBox tbExp;
        private System.Windows.Forms.Label lblExp;
    }
}