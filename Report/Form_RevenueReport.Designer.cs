namespace BookStore.Report
{
    partial class Form_RevenueReport
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
            this.cachedreport_ReceiptDetail1 = new BookStore.Report.Cachedreport_ReceiptDetail();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpt_revenue = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // rpt_revenue
            // 
            this.rpt_revenue.ActiveViewIndex = -1;
            this.rpt_revenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_revenue.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_revenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_revenue.Location = new System.Drawing.Point(0, 0);
            this.rpt_revenue.Name = "rpt_revenue";
            this.rpt_revenue.Size = new System.Drawing.Size(800, 450);
            this.rpt_revenue.TabIndex = 1;
            // 
            // Form_RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpt_revenue);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form_RevenueReport";
            this.Text = "Form_RevenueReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Cachedreport_ReceiptDetail cachedreport_ReceiptDetail1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_revenue;
    }
}