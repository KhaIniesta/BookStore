namespace BookStore.Report
{
    partial class Form_ReceiptDetailReport
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
            this.rpt_Receipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpt_Receipt
            // 
            this.rpt_Receipt.ActiveViewIndex = -1;
            this.rpt_Receipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_Receipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_Receipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_Receipt.Location = new System.Drawing.Point(0, 0);
            this.rpt_Receipt.Name = "rpt_Receipt";
            this.rpt_Receipt.Size = new System.Drawing.Size(1121, 651);
            this.rpt_Receipt.TabIndex = 0;
            // 
            // Form_ReceiptDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 651);
            this.Controls.Add(this.rpt_Receipt);
            this.Name = "Form_ReceiptDetailReport";
            this.Text = "Form_ReceiptDetailReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_Receipt;
    }
}