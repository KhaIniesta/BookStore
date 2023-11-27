namespace BookStore.UserControls
{
    partial class UC_ViewAll_I_ReceiptDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Lbl.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl.Location = new System.Drawing.Point(530, 271);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(415, 36);
            this.Lbl.TabIndex = 4;
            this.Lbl.Text = "UC_ViewAll-I-ReceiptDetail";
            // 
            // UC_ViewAll_I_ReceiptDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl);
            this.Name = "UC_ViewAll_I_ReceiptDetail";
            this.Size = new System.Drawing.Size(1222, 578);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl;
    }
}
