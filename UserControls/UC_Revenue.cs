﻿using BookStore.Report;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore.UserControls
{
    public partial class UC_Revenue : UserControl
    {
        public UC_Revenue()
        {
            InitializeComponent();
        }
        private DatabaseConnection DBC = new DatabaseConnection();
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234");
        SqlCommand cmd = null;
        private decimal SumRevenue = 0;

        public event EventHandler ChangeUCClicked;
        UC_AllReceiptDetail UC_AllRecDetail;

        private void UC_Revenue_Load(object sender, EventArgs e)
        {
            Btn_Month_Click(sender, e);
        }
        private void ResetChart()
        {
            foreach (var series in Chart_Revenue.Series)
            {
                series.Points.Clear();
            }
        }
        private double MonthRevenue(int Month, int Year)
        {
            conn.Open();
            cmd = new SqlCommand($"select dbo.func_tinhDoanhThuThang(@thang,@nam)", conn);
            cmd.Parameters.Add("@thang", SqlDbType.Int).Value = Month.ToString();
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = Year.ToString();
            double dtthang = (double)cmd.ExecuteScalar();
            conn.Close();
            return dtthang;
        }
        private double DayRevenue(int Day, int Month, int Year)
        {
            conn.Open();
            cmd = new SqlCommand($"select dbo.func_tinhDoanhThuNgay(@ngay, @thang,@nam)", conn);
            cmd.Parameters.Add("@ngay", SqlDbType.Int).Value = Day.ToString();
            cmd.Parameters.Add("@thang", SqlDbType.Int).Value = Month.ToString();
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = Year.ToString();
            double dtngay = (double)cmd.ExecuteScalar();
            conn.Close();
            return dtngay;
        }
        private void Btn_Day_Click(object sender, EventArgs e)
        {
            ResetChart();
            string sql = "select " +
               "MaHD as 'Receipt ID'," +
               "Nam as 'Year'," +
               "Thang as 'Month'," +
               "Ngay as 'Day'," +
               "TongHD as 'Total'" +
               $"from V_DTNgay where Ngay = {DateTimePicker.Value.Day} and Thang = {DateTimePicker.Value.Month} and Nam = {DateTimePicker.Value.Year}";
            DG_RevenueDetail.DataSource = DBC.GetTable(sql);
            SumOfRevenue(DG_RevenueDetail, SumRevenue);
        }

        private void Btn_Month_Click(object sender, EventArgs e)
        {
            ResetChart();
            string sql = "select " +
            "MaHD as 'Receipt ID'," +
            "Nam as 'Year'," +
            "Thang as 'Month'," +
            "Ngay as 'Day'," +
            "TongHD as 'Total'" +
            $"from V_DTThang where Thang = {DateTimePicker.Value.Month} and Nam = {DateTimePicker.Value.Year}";
            DG_RevenueDetail.DataSource = DBC.GetTable(sql);
            int NumOfDays = 30;
            for (int i = 1; i <= NumOfDays; ++i)
            {
                Chart_Revenue.Series["Revenue"].Points.AddXY(i, DayRevenue(i, DateTimePicker.Value.Month, DateTimePicker.Value.Year));
            }
            SumOfRevenue(DG_RevenueDetail, SumRevenue);
        }

        private void Btn_Year_Click(object sender, EventArgs e)
        {
            ResetChart();
            string sql = "select " +
                "MaHD as 'Receipt ID'," +
                "Nam as 'Year'," +
                "Thang as 'Month'," +
                "Ngay as 'Day'," +
                "TongHD as 'Total'" +
                $" from V_DTThang where Nam = {DateTimePicker.Value.Year}";
            DG_RevenueDetail.DataSource = DBC.GetTable(sql);

            int NumOfMonths = 12;
            for (int i = 1; i <= NumOfMonths; ++i)
            {
                Chart_Revenue.Series["Revenue"].Points.AddXY(i, MonthRevenue(i, DateTimePicker.Value.Year));
            }
            SumOfRevenue(DG_RevenueDetail, SumRevenue);
        }

        private void Btn_Details_Click(object sender, EventArgs e)
        {
            ChangeUCClicked?.Invoke(this, EventArgs.Empty); // change UC
            int selectedrowindex = DG_RevenueDetail.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DG_RevenueDetail.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Receipt ID"].Value);
            UC_AllRecDetail?.ShowDetails(cellValue);
        }

        private void DG_RevenueDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Details.Enabled = true;
        }

        public void SetUC_AllRecDetail_Reference(UC_AllReceiptDetail UC)
        {
            this.UC_AllRecDetail = UC;
        }

        private void btn_printRevenue(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in DG_RevenueDetail.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in DG_RevenueDetail.Rows)
            {
                DataRow dataRow = dt.NewRow();
                if (row.Cells[0].Value == null)
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        dataRow[i] = row.Cells[i].Value;
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("Revenue.xml");

            // Gán dữ liệu cho report
            report_Revenue reportRevenue = new report_Revenue();
            reportRevenue.SetDataSource(dt);
            // Gán các label vào report
            TextObject sumofrevenue_obj = (TextObject)reportRevenue.ReportDefinition.Sections["Section3"].ReportObjects["sumofrevenue"];
            sumofrevenue_obj.Text = txt_sumrevenue.Text;

            // Hiển thị báo cáo
            Form_RevenueReport f = new Form_RevenueReport();
            f.rpt_revenue.ReportSource = reportRevenue;
            f.ShowDialog();

        }

        private void SumOfRevenue(DataGridView dg, decimal sumrevenue)
        {
            foreach (DataGridViewRow row in DG_RevenueDetail.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    break;
                }
                else
                {
                    sumrevenue += (decimal)row.Cells[4].Value;
                }
            }
            txt_sumrevenue.Text = sumrevenue.ToString();
        }
    }
}
