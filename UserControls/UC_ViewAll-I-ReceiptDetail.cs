using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.UserControls
{
    public partial class UC_ViewAll_I_ReceiptDetail : UserControl
    {
        public UC_ViewAll_I_ReceiptDetail()
        {
            InitializeComponent();
        }
        private DatabaseConnection dataCon = new DatabaseConnection();


        private void ResetData()
        {
            string sql = "SELECT * FROM V_ChiTietCacPhieuNhap";
            dtg_viewallreceipt.DataSource = dataCon.GetTable(sql);

            cb_receiptID.Enabled = false;
            cb_bookID.Enabled = false;
            txt_quantity.Enabled = false;
            cb_publisherID.Enabled = false;
            dtp_date.Enabled = false;
            clearInput();

            cb_receiptID.DisplayMember = "MaPhieuNhap";
            cb_receiptID.ValueMember = "MaPhieuNhap";
            cb_receiptID.DataSource = dataCon.GetTable("SELECT MaPhieuNhap FROM PhieuNhap");
            cb_publisherID.DisplayMember = "MaNXB";
            cb_publisherID.ValueMember = "MaNXB";
            cb_publisherID.DataSource = dataCon.GetTable("SELECT MaNXB FROM NhaXuatBan");

            cb_receiptID.SelectedIndex = -1;
            cb_bookID.SelectedIndex = -1;
            cb_publisherID.SelectedIndex = -1;
        }
        private void UpdateBookIDDataSource(string selectedReceiptID)
        {
            string sql = $"SELECT * FROM Sach s INNER JOIN PhieuNhap pn ON s.MaNXB = pn.MaNXB WHERE pn.MaPhieuNhap = '{selectedReceiptID}'";
            cb_bookID.DisplayMember = "MaSach";
            cb_bookID.ValueMember = "MaSach";
            cb_bookID.DataSource = dataCon.GetTable(sql);
        }
        private void UC_ViewAll_I_ReceiptDetail_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            UC_I_Receipt ucReceipt = new UC_I_Receipt();
            this.Controls.Clear();
            this.Controls.Add(ucReceipt);
        }
        private void clearInput()
        {
            cb_receiptID.Text = string.Empty;
            cb_receiptID.SelectedIndex = -1;
            cb_bookID.Text = string.Empty;
            cb_bookID.SelectedIndex = -1;
            txt_quantity.Text = string.Empty;
            cb_publisherID.Text = string.Empty;
            cb_publisherID.SelectedIndex = -1;
            dtp_date.Text = string.Empty;
        }

        private void dtg_viewallreceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dtg_viewallreceipt.DataSource;
            int chiSo = dtg_viewallreceipt.SelectedCells[0].RowIndex;
            DataRow dr = dt.Rows[chiSo];

            cb_receiptID.Text = dr["MaPhieuNhap"].ToString();
            cb_publisherID.Text = dr["MaNXB"].ToString();          
            dtp_date.Text = dr["NgayNhap"].ToString();
            cb_bookID.Text = dr["MaSach"].ToString();
            txt_quantity.Text = dr["SoLuongNhap"].ToString();
        }

        private void cb_receiptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBookIDDataSource(cb_receiptID.Text);
        }
    }
}
