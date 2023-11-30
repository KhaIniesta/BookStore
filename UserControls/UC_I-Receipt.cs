using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.UserControls;
using System.Data.SqlClient;

namespace BookStore.UserControls
{
    public partial class UC_I_Receipt : UserControl
    {

        public UC_I_Receipt()
        {
            InitializeComponent();
        }

        private DatabaseConnection dataCon = new DatabaseConnection();
        private String control = "empty";

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearInput()
        {
            txt_receiptid.Text = string.Empty;
            cb_publisherid.Text = string.Empty;
            cb_publisherid.SelectedIndex = -1;
            dtp_date.Text = string.Empty;
        }
        private void ResetData()
        {
            string sql = "SELECT * FROM dbo.Func_LayBangPhieuNhap()";
            dtg_receipt.DataSource = dataCon.GetTable(sql);

            txt_receiptid.Enabled = false;
            cb_publisherid.Enabled = false;
            dtp_date.Enabled = false;
            cb_publisherid.DisplayMember = "MaNXB";
            cb_publisherid.ValueMember = "MaNXB";
            cb_publisherid.DataSource = dataCon.GetTable("SELECT MaNXB FROM NhaXuatBan");
            control = "empty";
            clearInput();
            cb_publisherid.SelectedIndex = -1;
        }
        private void dtg_receipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_I_Receipt_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            txt_receiptid.Enabled = true;
            cb_publisherid.Enabled = true;
            dtp_date.Enabled = true;
            clearInput();
            control = "insert";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            control = "delete";
            dataCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dataCon.GetConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Proc_XoaPhieuNhap";

            String receiptid = txt_receiptid.Text.Trim();
            cmd.Parameters.AddWithValue("@MaPhieuNhap", receiptid);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa sách thành công");
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    
                    SqlCommand ctpnCmd = new SqlCommand();
                    ctpnCmd.Connection = dataCon.GetConnection();
                    ctpnCmd.CommandType = CommandType.StoredProcedure;
                    ctpnCmd.CommandText = "Proc_XoaChiTietPhieuNhapTheoMaPhieuNhap";
                    ctpnCmd.Parameters.AddWithValue("@MaPhieuNhap", receiptid);
                    try
                    {
                        ctpnCmd.ExecuteNonQuery();
                        MessageBox.Show($"Bạn đã xóa tất cả các CTPN có mã phiếu nhập là {receiptid}");
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa thất bại!");

                    }
                }
            }

            ResetData();
            dataCon.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cb_publisherid.Enabled = true;
            dtp_date.Enabled = true;

            control = "update";
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
                cmd.CommandText = "Proc_ThemPhieuNhap";

                cmd.Parameters.AddWithValue("@MaPhieuNhap", txt_receiptid.Text);
                cmd.Parameters.AddWithValue("@MaNXB", cb_publisherid.Text);
                cmd.Parameters.AddWithValue("@NgayNhap", dtp_date.Value.ToShortDateString());

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm phiếu nhập thành công");
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
                cmd.CommandText = "Proc_SuaPhieuNhap";

                cmd.Parameters.AddWithValue("@MaPhieuNhap", txt_receiptid.Text);
                cmd.Parameters.AddWithValue("@MaNXB", cb_publisherid.Text);
                cmd.Parameters.AddWithValue("@NgayNhap", dtp_date.Value);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã sửa phiếu nhập thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ResetData();
            dataCon.Close();
        }

        private void dtg_receipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataTable dt = (DataTable)dtg_receipt.DataSource;
            int chiSo = dtg_receipt.SelectedCells[0].RowIndex;
            DataRow dr = dt.Rows[chiSo];

            txt_receiptid.Text = dr["MaPhieuNhap"].ToString();
            cb_publisherid.Text = dr["MaNXB"].ToString();
            dtp_date.Text = dr["NgayNhap"].ToString();
        }
        private bool IsInsertData()
        {
            if (txt_receiptid.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được trống!");
                return false;
            }
            if (cb_publisherid.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhà xuất bản nhập không được trống!");
                return false;
            }

            return true;
        }

        private void btn_addbook_Click_1(object sender, EventArgs e)
        {
            if (Controls.Contains(Panel_BookDesc))
            {
                Panel_BookDesc.Hide();
            }
            UC_Insert_I_ReceiptDetail ucInsertIReceiptDetail = new UC_Insert_I_ReceiptDetail();
            if (!Controls.Contains(ucInsertIReceiptDetail))
            {
                Controls.Add(ucInsertIReceiptDetail);
                ucInsertIReceiptDetail.Dock = DockStyle.Fill;
                ucInsertIReceiptDetail.BringToFront();
            }
            ucInsertIReceiptDetail.Show();

        }

        private void btn_viewdetail_Click(object sender, EventArgs e)
        {
            if (Controls.Contains(Panel_BookDesc))
            {
                Panel_BookDesc.Hide();
            }

            UC_ViewAll_I_ReceiptDetail ucViewAllReceipt = new UC_ViewAll_I_ReceiptDetail();
            if (!Controls.Contains(ucViewAllReceipt))
            {
                Controls.Add(ucViewAllReceipt);
                ucViewAllReceipt.Dock = DockStyle.Fill;
                ucViewAllReceipt.BringToFront();
            }

            ucViewAllReceipt.Show();

        }    
     
    }
}
