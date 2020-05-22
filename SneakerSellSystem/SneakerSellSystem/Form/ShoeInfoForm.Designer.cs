namespace SneakerSellSystem
{
    partial class ShoeInfoForm
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
            this.dgvShoes = new System.Windows.Forms.DataGridView();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShoes
            // 
            this.dgvShoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoes.Location = new System.Drawing.Point(8, 10);
            this.dgvShoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvShoes.Name = "dgvShoes";
            this.dgvShoes.RowTemplate.Height = 27;
            this.dgvShoes.Size = new System.Drawing.Size(553, 339);
            this.dgvShoes.TabIndex = 0;
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
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(8, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(553, 31);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "更新信息";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ShoeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 397);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvShoes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShoeInfoForm";
            this.Text = "库存信息";
            this.Load += new System.EventHandler(this.ShoeInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShoes;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnUpdate;
    }
}