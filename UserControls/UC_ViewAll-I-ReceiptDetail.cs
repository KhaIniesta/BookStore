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

            cb_bookID.DisplayMember = "MaSach";
            cb_bookID.ValueMember = "MaSach";
            cb_bookID.DataSource = dataCon.GetTable($"SELECT * FROM Sach s\r\nINNER JOIN PhieuNhap pn ON s.MaNXB = pn.MaNXB\r\nWHERE pn.MaPhieuNhap = '{cb_receiptID.Text}'");

            cb_publisherID.DisplayMember = "MaNXB";
            cb_publisherID.ValueMember = "MaNXB";
            cb_publisherID.DataSource = dataCon.GetTable("SELECT MaNXB FROM NhaXuatBan");

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
            cb_bookID.Text = string.Empty;
            txt_quantity.Text = string.Empty;
            cb_publisherID.Text = string.Empty;
            dtp_date.Text = string.Empty;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string newMaPhieuNhap = cb_receiptID.SelectedValue.ToString();
            string newMaNXB = cb_publisherID.SelectedValue.ToString();
            DateTime newNgayNhap = dtp_date.Value;
            string newMaSach = cb_bookID.SelectedValue.ToString();
            int newSoLuongNhap = Convert.ToInt32(txt_quantity.Text);

            string insertQueryPhieuNhap = $"INSERT INTO PhieuNhap (MaPhieuNhap, MaNXB, NgayNhap) VALUES ('{newMaPhieuNhap}', '{newMaNXB}', '{newNgayNhap.ToString("yyyy-MM-dd")}')";

            string insertQueryChiTiet = $"INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaSach, SoLuongNhap) VALUES ('{newMaPhieuNhap}', '{newMaSach}', {newSoLuongNhap})";
            ExecuteNonQuery(insertQueryPhieuNhap);
            ExecuteNonQuery(insertQueryChiTiet);
            ResetData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string updatedMaPhieuNhap = cb_receiptID.SelectedValue.ToString();
            string updatedMaNXB = cb_publisherID.SelectedValue.ToString();
            DateTime updatedNgayNhap = dtp_date.Value; 
            string updatedMaSach = cb_bookID.SelectedValue.ToString();
            int updatedSoLuongNhap = Convert.ToInt32(txt_quantity.Text);
            string updateQueryChiTiet = $"UPDATE ChiTietPhieuNhap SET SoLuongNhap = {updatedSoLuongNhap} WHERE MaPhieuNhap = '{updatedMaPhieuNhap}' AND MaSach = '{updatedMaSach}'";
            ExecuteNonQuery(updateQueryChiTiet);          
            ResetData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string delectedMaPhieuNhap = cb_receiptID.SelectedValue.ToString();
            string deletedMaSach = cb_bookID.SelectedValue.ToString();
            string deleteQueryChiTiet = $"DELETE FROM ChiTietPhieuNhap WHERE MaPhieuNhap = '{delectedMaPhieuNhap}' AND MaSach = '{deletedMaSach}'";
            ExecuteNonQuery(deleteQueryChiTiet);
            ResetData();
        }
        private void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
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
    }
}
