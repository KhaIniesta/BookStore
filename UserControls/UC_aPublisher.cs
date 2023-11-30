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
    public partial class UC_aPublisher : UserControl
    {
        public UC_aPublisher()
        {
            InitializeComponent();
            con = kn.GetConnection();

        }
        DatabaseConnection kn = new DatabaseConnection();
        private SqlConnection con;
        private SqlCommand cmd;
        private String dieuKhien = "trong";

        private void ResetButton()
        {
            txt_name.Enabled = false;
            txt_maNXB.Enabled = false;
            txt_diaChi.Enabled = false;
            txt_lienHe.Enabled = false;
            btn_sua.Enabled = true;
            btn_themPu.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
        }

        private void Clear()
        {
            txt_name.ResetText();
            txt_diaChi.ResetText();
            txt_lienHe.ResetText();
            txt_maNXB.ResetText();
        }

        private void LoadDataNXB()
        {
            kn.Open();
            string sql = "Select * from NhaXuatBan";
            dtg_nxb.DataSource = kn.GetTable(sql);
            kn.Close();
            ResetButton();
            Clear();
        }

        private void UC_aPublisher_Load(object sender, EventArgs e)
        {
            LoadDataNXB();

        }

        private void dtg_nxb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_name.Text = Convert.ToString(dtg_nxb.CurrentRow.Cells["col_tenNXB"].Value);
                txt_maNXB.Text = Convert.ToString(dtg_nxb.CurrentRow.Cells["col_maNXB"].Value);
                txt_diaChi.Text = Convert.ToString(dtg_nxb.CurrentRow.Cells["col_diaChi"].Value);
                txt_lienHe.Text = Convert.ToString(dtg_nxb.CurrentRow.Cells["col_lienHe"].Value);
            }
        }

        private void btn_themPu_Click(object sender, EventArgs e)
        {
            Clear();
            dieuKhien = "them";
            txt_maNXB.Enabled = true;
            txt_diaChi.Enabled = true;
            txt_lienHe.Enabled = true;
            txt_name.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dieuKhien = "capnhat";
            txt_maNXB.Enabled = false;
            txt_diaChi.Enabled = true;
            txt_lienHe.Enabled = true;
            txt_name.Enabled = true;
            btn_luu.Enabled=false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("Proc_XoaNhaXuatBan", con);
                    kn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNXB", SqlDbType.NChar).Value = txt_maNXB.Text.Trim();

                    int count = cmd.ExecuteNonQuery();
                    kn.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadDataNXB();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa hoặc mã NXB không tồn tại");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                kn.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Clear();
            ResetButton();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (dieuKhien == "them")
            {
                try
                {

                    cmd = new SqlCommand("Proc_ThemNhaXuatBan", con);
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNXB", SqlDbType.NChar).Value = txt_maNXB.Text.Trim();
                    cmd.Parameters.Add("@TenNXB", SqlDbType.NVarChar).Value = txt_name.Text.Trim();
                    cmd.Parameters.Add("@DiaChiNXB", SqlDbType.NVarChar).Value = txt_diaChi.Text.Trim();
                    cmd.Parameters.Add("@LienHe", SqlDbType.NVarChar).Value = txt_lienHe.Text.Trim();

                    // Execute the stored procedure
                    int count = cmd.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadDataNXB();
                        txt_name.Text = "";
                        txt_name.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm mới");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                con.Close();
            }

            else if (dieuKhien == "capnhat")
            {
                try
                {
                    cmd = new SqlCommand("Proc_SuaNhaXuatBan", con);
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaNXB", txt_maNXB.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@TenNXB", txt_name.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@DiaChiNXB", txt_diaChi.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@LienHe", txt_lienHe.Text);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("Sua thanh cong");
                        LoadDataNXB();

                    }
                    else
                    {
                        MessageBox.Show("khong the sua");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);

                }
                con.Close();

            }
        }
    }


}
