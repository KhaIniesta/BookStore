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
    public partial class UC_Author : UserControl
    {
        public UC_Author()
        {
            con = kn.GetConnection();
            InitializeComponent();
        }
        DatabaseConnection kn = new DatabaseConnection();
        private SqlConnection con;
        private SqlCommand cmd;
        private String dieuKhien = "trong";

        private void ResetButton()
        {
            txt_name.Enabled = false;
            txt_maTG.Enabled = false;
            txt_lienHe.Enabled = false;
            cb_maNXB.Enabled = false;
            btn_sua.Enabled = true;
            btn_themAu.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
        }

        private void Clear()
        {
            txt_name.Clear();
            txt_lienHe.Clear();
            txt_maTG.Clear();
            cb_maNXB.SelectedIndex = -1;
        }

        private void LoadDataTG()
        {
            kn.Open();
            string sql = "Select * from TacGia";
            dtg_tacgia.DataSource = kn.GetTable(sql);

            cb_maNXB.DataSource = kn.GetTable("SELECT MaNXB FROM NhaXuatBan");
            cb_maNXB.DisplayMember = "MaNXB";
            cb_maNXB.ValueMember = "MaNXB";
            kn.Close();
            ResetButton();
            Clear();
        }
        private void UC_Author_Load(object sender, EventArgs e)
        {
            LoadDataTG();
            
        }
        private bool 
        ()
        {
            if (txt_name.Text.Trim() == "")
            {
                MessageBox.Show("Tên tác giả không được trống!");
                return false;
            }
            if (cb_maNXB.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhà xuất bản không được trống!");
                return false;

            }
            if (txt_maTG.Text.Trim() == "")
            {
                MessageBox.Show("Mã tác giả không được trống!");
                return false;

            }
            if (int.TryParse(txt_maTG.Text, out int maTG) && maTG < 0)
            {
                MessageBox.Show("Mã tác giả không được nhập số âm!");
                return false;
            }
            if (int.TryParse(txt_name.Text, out _))
            {
                MessageBox.Show("Tên tác giả không được nhập số!");
                return false;
            }
            if (int.TryParse(txt_lienHe.Text, out int lienHe) && lienHe < 0)
            {
                MessageBox.Show("Liên hệ không được nhập số âm!");
                return false;
            }
            return true;
        }
        private void dtg_tacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_maNXB.SelectedIndex = -1;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_maTG.Text = Convert.ToString(dtg_tacgia.CurrentRow.Cells["col_MaTG"].Value);
                cb_maNXB.Text = Convert.ToString(dtg_tacgia.CurrentRow.Cells["col_MaNXBAu"].Value);
                txt_name.Text = Convert.ToString(dtg_tacgia.CurrentRow.Cells["col_TenTG"].Value);
                txt_lienHe.Text = Convert.ToString(dtg_tacgia.CurrentRow.Cells["col_LienHeAu"].Value);

            }
        }

        private void btn_themAu_Click(object sender, EventArgs e)
        {
            Clear();
            dieuKhien = "them";
            cb_maNXB.Enabled = true;
            txt_maTG.Enabled = true;
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
            cb_maNXB.Enabled = true;
            txt_maTG.Enabled = false;
            txt_lienHe.Enabled = true;
            txt_name.Enabled = true;
            btn_sua.Enabled = false;
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("XoaTacGia", con);
                kn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaTG", txt_maTG.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                kn.Close();
                if (count > 0)
                {
                    MessageBox.Show("Xóa tác giả thành công!!");
                    LoadDataTG();                    
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực thi câu lệnh SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            kn.Close();
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Sử dụng biểu thức chính quy để kiểm tra số điện thoại
            // Đơn giản cho mục đích ví dụ, bạn có thể điều chỉnh để phù hợp với định dạng số điện thoại thực tế
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^\S+@\S+\.\S+$");
        }

        private bool IsValidLienHe()
        {
            string lienHe = txt_lienHe.Text.Trim();
            // Kiểm tra nếu là số điện thoại
            if (IsValidPhoneNumber(lienHe))
            {
                return true;
            }
            // Kiểm tra nếu là email
            else if (IsValidEmail(lienHe))
            {
                return true;
            }
            // Nếu không phải số điện thoại hoặc email, trả về false
            else
            {
                return false;
            }
        }
        private bool IsValidName()
        {
            string name = txt_name.Text.Trim();
            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[\p{L}\s\p{M}]+$");
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string errormessage = "";
            bool haserror = false;
            if (IsValidName() == false)
            {
                errormessage += "Nhập sai tên. \n";
                haserror = true;
                
            }
            if (IsValidLienHe() == false)
            {
                errormessage += "       Nhập sai số điện thoại hoặc email. \n";
                haserror = true;
            }
            if (haserror == true)
            {
                MessageBox.Show("Lỗi: " + errormessage);
            }
            else if (dieuKhien == "them")

            if (!CheckInputData())
            {
                ResetText();
                return;
            }
            if (dieuKhien == "them")
            {
                try
                {
                    cmd = new SqlCommand("ThemTacGia", con);
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaTG", SqlDbType.NChar).Value = txt_maTG.Text.Trim();
                    cmd.Parameters.Add("@MaNXB", SqlDbType.NChar).Value = cb_maNXB.Text.Trim();
                    cmd.Parameters.Add("@TenTG", SqlDbType.NVarChar).Value = txt_name.Text.Trim();
                    cmd.Parameters.Add("@LienHe", SqlDbType.NChar).Value = txt_lienHe.Text.Trim();

                    int count = cmd.ExecuteNonQuery();
                    con.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Thêm tác giả thành công!!");
                        LoadDataTG();
                        txt_maTG.Text = "";
                        txt_maTG.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm tác giả mới!!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                con.Close();


            }

            else if (dieuKhien == "capnhat")
            {

                cmd = new SqlCommand("CapNhatTacGia", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTG", txt_maTG.Text);
                cmd.Parameters.AddWithValue("@MaNXB", cb_maNXB.Text);
                cmd.Parameters.AddWithValue("@TenTG", txt_name.Text);
                cmd.Parameters.AddWithValue("@LienHe", txt_lienHe.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật tác giả thành công!!");
                    txt_maTG.Text = "";
                    txt_maTG.Focus();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi thực thi câu lệnh SQL: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                LoadDataTG();
                con.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Clear();
            ResetButton();
        }

        
    }
}
