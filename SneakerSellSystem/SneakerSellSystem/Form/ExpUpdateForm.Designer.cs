namespace SneakerSellSystem
{
    partial class ExpUpdateForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.dgvExp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.btnUpdate.Location = new System.Drawing.Point(16, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(572, 31);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // dgvExp
            // 
            this.dgvExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExp.Location = new System.Drawing.Point(16, 33);
            this.dgvExp.Name = "dgvExp";
            this.dgvExp.RowTemplate.Height = 27;
            this.dgvExp.Size = new System.Drawing.Size(571, 356);
            this.dgvExp.TabIndex = 2;
            // 
            // ExpUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 452);
            this.Controls.Add(this.dgvExp);
            this.Controls.Add(this.btnUpdate);
            this.Name = "ExpUpdateForm";
            this.Text = "ExpUpdateForm";
            this.Load += new System.EventHandler(this.ExpUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.DataGridView dgvExp;
    }
}