namespace BookStore.UserControls
{
    partial class UC_Revenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Date = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_Role = new System.Windows.Forms.Label();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Btn_Year = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Month = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Day = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_Chart = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Chart_Revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Panel_Dg = new Guna.UI2.WinForms.Guna2Panel();
            this.DG_RevenueDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Btn_Details = new Guna.UI2.WinForms.Guna2Button();
            this.btn_printReceipt = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ds_receiptdetail1 = new BookStore.Report.ds_receiptdetail();
            this.txt_sumrevenue = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel_Date.SuspendLayout();
            this.Panel_Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Revenue)).BeginInit();
            this.Panel_Dg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_RevenueDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_receiptdetail1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Date
            // 
            this.Panel_Date.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Date.BorderRadius = 12;
            this.Panel_Date.Controls.Add(this.btn_printReceipt);
            this.Panel_Date.Controls.Add(this.Lbl_Role);
            this.Panel_Date.Controls.Add(this.DateTimePicker);
            this.Panel_Date.Controls.Add(this.Btn_Year);
            this.Panel_Date.Controls.Add(this.Btn_Month);
            this.Panel_Date.Controls.Add(this.Btn_Day);
            this.Panel_Date.FillColor = System.Drawing.Color.White;
            this.Panel_Date.Location = new System.Drawing.Point(769, 25);
            this.Panel_Date.Name = "Panel_Date";
            this.Panel_Date.Size = new System.Drawing.Size(429, 263);
            this.Panel_Date.TabIndex = 0;
            // 
            // Lbl_Role
            // 
            this.Lbl_Role.AutoSize = true;
            this.Lbl_Role.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Role.Font = new System.Drawing.Font("Inter SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Role.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Role.Location = new System.Drawing.Point(10, 11);
            this.Lbl_Role.Name = "Lbl_Role";
            this.Lbl_Role.Size = new System.Drawing.Size(188, 34);
            this.Lbl_Role.TabIndex = 6;
            this.Lbl_Role.Text = "Choose date";
            this.Lbl_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DateTimePicker.BorderRadius = 12;
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.FillColor = System.Drawing.Color.Gray;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(45, 120);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(354, 36);
            this.DateTimePicker.TabIndex = 1;
            this.DateTimePicker.Value = new System.DateTime(2023, 9, 3, 0, 0, 0, 0);
            // 
            // Btn_Year
            // 
            this.Btn_Year.BorderRadius = 12;
            this.Btn_Year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Year.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Year.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Year.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Year.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Year.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Btn_Year.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Year.ForeColor = System.Drawing.Color.White;
            this.Btn_Year.Location = new System.Drawing.Point(299, 191);
            this.Btn_Year.Name = "Btn_Year";
            this.Btn_Year.Size = new System.Drawing.Size(100, 40);
            this.Btn_Year.TabIndex = 0;
            this.Btn_Year.Text = "Year";
            this.Btn_Year.Click += new System.EventHandler(this.Btn_Year_Click);
            // 
            // Btn_Month
            // 
            this.Btn_Month.BorderRadius = 12;
            this.Btn_Month.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Month.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Month.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Month.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Month.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Month.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Btn_Month.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Month.ForeColor = System.Drawing.Color.White;
            this.Btn_Month.Location = new System.Drawing.Point(176, 191);
            this.Btn_Month.Name = "Btn_Month";
            this.Btn_Month.Size = new System.Drawing.Size(100, 40);
            this.Btn_Month.TabIndex = 0;
            this.Btn_Month.Text = "Month";
            this.Btn_Month.Click += new System.EventHandler(this.Btn_Month_Click);
            // 
            // Btn_Day
            // 
            this.Btn_Day.BorderRadius = 12;
            this.Btn_Day.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Day.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Day.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Day.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Day.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Day.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Btn_Day.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Day.ForeColor = System.Drawing.Color.White;
            this.Btn_Day.Location = new System.Drawing.Point(45, 191);
            this.Btn_Day.Name = "Btn_Day";
            this.Btn_Day.Size = new System.Drawing.Size(100, 40);
            this.Btn_Day.TabIndex = 0;
            this.Btn_Day.Text = "Day";
            this.Btn_Day.Click += new System.EventHandler(this.Btn_Day_Click);
            // 
            // Panel_Chart
            // 
            this.Panel_Chart.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Chart.BorderRadius = 12;
            this.Panel_Chart.Controls.Add(this.label1);
            this.Panel_Chart.Controls.Add(this.Chart_Revenue);
            this.Panel_Chart.FillColor = System.Drawing.Color.White;
            this.Panel_Chart.Location = new System.Drawing.Point(32, 25);
            this.Panel_Chart.Name = "Panel_Chart";
            this.Panel_Chart.Size = new System.Drawing.Size(718, 263);
            this.Panel_Chart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chart_Revenue
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_Revenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_Revenue.Legends.Add(legend1);
            this.Chart_Revenue.Location = new System.Drawing.Point(0, 27);
            this.Chart_Revenue.Name = "Chart_Revenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.Chart_Revenue.Series.Add(series1);
            this.Chart_Revenue.Size = new System.Drawing.Size(746, 233);
            this.Chart_Revenue.TabIndex = 7;
            this.Chart_Revenue.Text = "Chart";
            title1.Name = "Revenue";
            this.Chart_Revenue.Titles.Add(title1);
            // 
            // Panel_Dg
            // 
            this.Panel_Dg.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Dg.BorderRadius = 12;
            this.Panel_Dg.Controls.Add(this.txt_sumrevenue);
            this.Panel_Dg.Controls.Add(this.DG_RevenueDetail);
            this.Panel_Dg.Controls.Add(this.Btn_Details);
            this.Panel_Dg.FillColor = System.Drawing.Color.White;
            this.Panel_Dg.Location = new System.Drawing.Point(32, 318);
            this.Panel_Dg.Name = "Panel_Dg";
            this.Panel_Dg.Size = new System.Drawing.Size(1166, 236);
            this.Panel_Dg.TabIndex = 0;
            // 
            // DG_RevenueDetail
            // 
            this.DG_RevenueDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DG_RevenueDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_RevenueDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_RevenueDetail.ColumnHeadersHeight = 20;
            this.DG_RevenueDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_RevenueDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_RevenueDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DG_RevenueDetail.Location = new System.Drawing.Point(3, 3);
            this.DG_RevenueDetail.Name = "DG_RevenueDetail";
            this.DG_RevenueDetail.ReadOnly = true;
            this.DG_RevenueDetail.RowHeadersVisible = false;
            this.DG_RevenueDetail.RowHeadersWidth = 51;
            this.DG_RevenueDetail.RowTemplate.Height = 24;
            this.DG_RevenueDetail.Size = new System.Drawing.Size(956, 230);
            this.DG_RevenueDetail.TabIndex = 0;
            this.DG_RevenueDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DG_RevenueDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DG_RevenueDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DG_RevenueDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DG_RevenueDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DG_RevenueDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DG_RevenueDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DG_RevenueDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DG_RevenueDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_RevenueDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG_RevenueDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DG_RevenueDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DG_RevenueDetail.ThemeStyle.HeaderStyle.Height = 20;
            this.DG_RevenueDetail.ThemeStyle.ReadOnly = true;
            this.DG_RevenueDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DG_RevenueDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DG_RevenueDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG_RevenueDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DG_RevenueDetail.ThemeStyle.RowsStyle.Height = 24;
            this.DG_RevenueDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DG_RevenueDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DG_RevenueDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_RevenueDetail_CellClick);
            // 
            // Btn_Details
            // 
            this.Btn_Details.BorderRadius = 12;
            this.Btn_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Details.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Details.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Details.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Details.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Details.Enabled = false;
            this.Btn_Details.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Btn_Details.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Details.ForeColor = System.Drawing.Color.White;
            this.Btn_Details.Location = new System.Drawing.Point(1011, 110);
            this.Btn_Details.Name = "Btn_Details";
            this.Btn_Details.Size = new System.Drawing.Size(100, 40);
            this.Btn_Details.TabIndex = 0;
            this.Btn_Details.Text = "Details";
            this.Btn_Details.Click += new System.EventHandler(this.Btn_Details_Click);
            // 
            // btn_printReceipt
            // 
            this.btn_printReceipt.Animated = true;
            this.btn_printReceipt.AutoRoundedCorners = true;
            this.btn_printReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btn_printReceipt.BorderRadius = 17;
            this.btn_printReceipt.DefaultAutoSize = true;
            this.btn_printReceipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_printReceipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_printReceipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_printReceipt.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_printReceipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_printReceipt.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_printReceipt.ForeColor = System.Drawing.Color.White;
            this.btn_printReceipt.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_printReceipt.Location = new System.Drawing.Point(299, 9);
            this.btn_printReceipt.Name = "btn_printReceipt";
            this.btn_printReceipt.Size = new System.Drawing.Size(98, 36);
            this.btn_printReceipt.TabIndex = 4;
            this.btn_printReceipt.Text = "Export";
            this.btn_printReceipt.Click += new System.EventHandler(this.btn_printRevenue);
            // 
            // ds_receiptdetail1
            // 
            this.ds_receiptdetail1.DataSetName = "ds_receiptdetail";
            this.ds_receiptdetail1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_sumrevenue
            // 
            this.txt_sumrevenue.BackColor = System.Drawing.Color.Transparent;
            this.txt_sumrevenue.BorderRadius = 10;
            this.txt_sumrevenue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sumrevenue.DefaultText = "";
            this.txt_sumrevenue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sumrevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sumrevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sumrevenue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sumrevenue.Enabled = false;
            this.txt_sumrevenue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sumrevenue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sumrevenue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sumrevenue.Location = new System.Drawing.Point(984, 14);
            this.txt_sumrevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sumrevenue.Name = "txt_sumrevenue";
            this.txt_sumrevenue.PasswordChar = '\0';
            this.txt_sumrevenue.PlaceholderText = "";
            this.txt_sumrevenue.SelectedText = "";
            this.txt_sumrevenue.Size = new System.Drawing.Size(152, 36);
            this.txt_sumrevenue.TabIndex = 31;
            // 
            // UC_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.Panel_Dg);
            this.Controls.Add(this.Panel_Chart);
            this.Controls.Add(this.Panel_Date);
            this.Name = "UC_Revenue";
            this.Size = new System.Drawing.Size(1222, 578);
            this.Load += new System.EventHandler(this.UC_Revenue_Load);
            this.Panel_Date.ResumeLayout(false);
            this.Panel_Date.PerformLayout();
            this.Panel_Chart.ResumeLayout(false);
            this.Panel_Chart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Revenue)).EndInit();
            this.Panel_Dg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_RevenueDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_receiptdetail1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel_Date;
        private Guna.UI2.WinForms.Guna2Panel Panel_Chart;
        private Guna.UI2.WinForms.Guna2Panel Panel_Dg;
        private Guna.UI2.WinForms.Guna2Button Btn_Day;
        private Guna.UI2.WinForms.Guna2Button Btn_Year;
        private Guna.UI2.WinForms.Guna2Button Btn_Month;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2DataGridView DG_RevenueDetail;
        private System.Windows.Forms.Label Lbl_Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Revenue;
        private Guna.UI2.WinForms.Guna2Button Btn_Details;
        private Guna.UI2.WinForms.Guna2GradientButton btn_printReceipt;
        private Guna.UI2.WinForms.Guna2TextBox txt_sumrevenue;
        private Report.ds_receiptdetail ds_receiptdetail1;
    }
}
