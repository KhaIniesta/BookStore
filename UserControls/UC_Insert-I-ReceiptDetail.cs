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
    public partial class UC_Insert_I_ReceiptDetail : UserControl
    {
        public UC_Insert_I_ReceiptDetail()
        {
            InitializeComponent();
        }
        private DatabaseConnection dataCon = new DatabaseConnection();
        private string control = "empty";
        private void clearInput()
        {
            cb_receiptID.Text = string.Empty;
            cb_receiptID.SelectedIndex = -1;
            cb_bookID.Text = string.Empty;
            cb_bookID.SelectedIndex = -1;
            txt_quantity.Text = string.Empty;
        }
        public void ResetButton()
        {
            cb_receiptID.Enabled = false;
            cb_bookID.Enabled = false;
            txt_quantity.Enabled = false;
            btn_insert.Enabled = true;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            btn_cancel.Enabled = false;
        }
        private void ResetData()
        {
            string sql = "SELECT * FROM ChiTietPhieuNhap";
            dtg_insertreceiptdetail.DataSource = dataCon.GetTable(sql);

            cb_receiptID.Enabled = false;
            cb_bookID.Enabled = false;
            txt_quantity.Enabled = false;

            cb_receiptID.DisplayMember = "MaPhieuNhap";
            cb_receiptID.ValueMember = "MaPhieuNhap";
            cb_receiptID.DataSource = dataCon.GetTable("SELECT MaPhieuNhap FROM PhieuNhap");

            control = "empty";
            clearInput();
            cb_receiptID.SelectedIndex = -1;
            cb_bookID.SelectedIndex = -1;
            ResetButton();
        }

        private void UpdateBookIDDataSource(string selectedReceiptID)
        {
            string sql = $"SELECT * FROM Sach s INNER JOIN PhieuNhap pn ON s.MaNXB = pn.MaNXB WHERE pn.MaPhieuNhap = '{selectedReceiptID}'";
            cb_bookID.DisplayMember = "MaSach";
            cb_bookID.ValueMember = "MaSach";
            cb_bookID.DataSource = dataCon.GetTable(sql);
        }
        private void UC_Insert_I_ReceiptDetail_Load(object sender, EventArgs e)
        {
            ResetData();
        }


        private bool IsInsertData()
        {
            if (cb_receiptID.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được trống!");
                return false;
            }
            if (cb_bookID.Text.Trim() == "")
            {
                MessageBox.Show("Mã sách không được trống!");
                return false;
            }
            if (txt_quantity.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng nhập không được trống!");
                return false;
            }
            if (!int.TryParse(txt_quantity.Text, out int quantity))
            {
                MessageBox.Show("Số lượng nhập phải là số!");
                return false;
            }
            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng nhập phải là số nguyên dương!");
                return false;
            }
            return true;
        }

        private void dtg_insertreceiptdetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dtg_insertreceiptdetail.DataSource;
            int chiSo = dtg_insertreceiptdetail.SelectedCells[0].RowIndex;
            DataRow dr = dt.Rows[chiSo];

            cb_receiptID.Text = dr["MaPhieuNhap"].ToString();
            cb_bookID.Text = dr["MaSach"].ToString();
            txt_quantity.Text = dr["SoLuongNhap"].ToString();
        }

        private void cb_receiptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBookIDDataSource(cb_receiptID.Text);

        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            cb_receiptID.Enabled = true;
            txt_quantity.Enabled = true;
            cb_bookID.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
            clearInput();
            control = "insert";
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            control = "delete";
            dataCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dataCon.GetConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Proc_XoaChiTietPhieuNhap";

            String maPhieuNhap = cb_receiptID.Text.Trim();
            String maSach = cb_bookID.Text.Trim();

            cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
            cmd.Parameters.AddWithValue("@MaSach", maSach);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa chi tiết phiếu nhập thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ResetData();
            dataCon.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cb_receiptID.Enabled = false;
            txt_quantity.Enabled = true;
            cb_bookID.Enabled = false;
            btn_insert.Enabled = false;
            btn_delete.Enabled = false;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
            control = "update";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearInput();
            ResetButton();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (IsInsertData() == false)
            {
                ResetData();
                return;
            }
            dataCon.Open();
            if (control == "insert")
            {
                dataCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dataCon.GetConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Proc_ThemChiTietPhieuNhap";

                try
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", cb_receiptID.Text);
                    cmd.Parameters.AddWithValue("@MaSach", cb_bookID.Text);
                    cmd.Parameters.AddWithValue("@SoLuongNhap", int.Parse(txt_quantity.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm chi tiết phiếu nhập thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (control == "update")
            {
                dataCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dataCon.GetConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Proc_SuaChiTietPhieuNhap";

                try
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", cb_receiptID.Text);
                    cmd.Parameters.AddWithValue("@MaSach", cb_bookID.Text);
                    cmd.Parameters.AddWithValue("@SoLuongNhap", int.Parse(txt_quantity.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã sửa chi tiết phiếu nhập thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ResetData();
            dataCon.Close();

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            UC_I_Receipt ucReceipt = new UC_I_Receipt();
            this.Controls.Clear();
            this.Controls.Add(ucReceipt);
        }
    }
}
