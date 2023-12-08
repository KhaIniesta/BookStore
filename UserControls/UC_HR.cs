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
    public partial class UC_HR : UserControl
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();
        private String ControlState = "none";
        public UC_HR()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            if (Txt_Username.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được trống!");
                return false;
            }
            if (Txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được trống!");
                return false;

            }
            if (Txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được trống!");
                return false;

            }
            if (CB_Position.Text.Trim() == "")
            {
                MessageBox.Show("Chức vụ không được trống!");
                return false;
            }

            return true;
        }

        private void clearInput()
        {
            Txt_Username.Text = string.Empty;
            Txt_Password.Text = string.Empty;
            Txt_Name.Text = string.Empty;
            CB_Position.SelectedIndex = -1;
        }

        private void ResetData()
        {
            string sql = "SELECT TenDangNhap, MatKhau, ChucVu, TenNguoiDung, Anh FROM TaiKhoan";
            DataTable dt = DBConnection.GetTable(sql);
            
            DG_AccountDetail.DataSource = dt;
            Txt_Username.Enabled = false;
            Txt_Password.Enabled = false;
            Txt_Name.Enabled = false;
            CB_Position.Enabled = false;
            Btn_ChoosePic.Enabled = false;
            btn_canncel.Enabled = false;
            btn_delete_account.Enabled = false;
            btn_new_account.Enabled = true;
            btn_update_account.Enabled = false;
            ControlState = "none";
            Picturebox_ProfilePic.Image = null;

            clearInput();
        }

        private void btn_new_account_Click(object sender, EventArgs e)
        {

            Txt_Username.Enabled = true;
            Txt_Password.Enabled = true;
            Txt_Name.Enabled = true;
            CB_Position.Enabled = true;
            Btn_ChoosePic.Enabled = true;
            btn_canncel.Enabled = true;
            btn_delete_account.Enabled = false;
            btn_new_account.Enabled = false;
            btn_update_account.Enabled = false;
            clearInput();
            ControlState = "insert";
            Txt_Username.Focus();
        }

        private void btn_canncel_Click(object sender, EventArgs e)
        {
            Txt_Username.Enabled = false;
            Txt_Password.Enabled = false;
            Txt_Name.Enabled = false;
            CB_Position.Enabled = false;
            Btn_ChoosePic.Enabled = false;
            ControlState = "none";
            btn_delete_account.Enabled = false;
            btn_new_account.Enabled = true;
            btn_update_account.Enabled = false;
            Picturebox_ProfilePic.Image = null;
            btn_canncel.Enabled = false;

            clearInput();
        }
        public EventHandler ReturnLoginForm;
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
            {
                ResetData();
                return;
            }
            DBConnection.Open();
            if (ControlState == "insert")
            {
                DBConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnection.GetConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Proc_ThemTaiKhoan";

                String TenDangNhap = Txt_Username.Text.Trim();
                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                String MatKhau = Txt_Password.Text.Trim();
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                int Cap;
                if (CB_Position.Text == "Admin")
                {
                    Cap = 1;
                }
                else if (CB_Position.Text == "Nhân viên thu ngân")
                {
                    Cap = 2;
                }
                else
                {
                    Cap = 3;
                }
                cmd.Parameters.AddWithValue("@Cap", Cap);
                String TenNguoiDung = Txt_Name.Text.Trim();
                cmd.Parameters.AddWithValue("@TenNguoiDung", TenNguoiDung);
                byte[] imageData = Utils.GenerateDataImageFromPath(Picturebox_ProfilePic.ImageLocation);
                cmd.Parameters.AddWithValue("@Anh", imageData);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm tài khoản thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (ControlState == "update")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBConnection.GetConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Proc_CapNhatTaiKhoan";

                String TenDangNhap = Txt_Username.Text.Trim();
                String MatKhau = Txt_Password.Text.Trim();

                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhauMoi", MatKhau);
                int Cap;
                if (CB_Position.Text == "Admin")
                {
                    Cap = 1;
                }
                else if (CB_Position.Text == "Nhân viên thu ngân")
                {
                    Cap = 2;
                }
                else
                {
                    Cap = 3;
                }
                cmd.Parameters.AddWithValue("@CapMoi", Cap);
                String TenNguoiDung = Txt_Name.Text.Trim();
                cmd.Parameters.AddWithValue("@TenNguoiDung", TenNguoiDung);

                byte[] imageData = Utils.GenerateDataImageFromPath(Picturebox_ProfilePic.ImageLocation);
                cmd.Parameters.AddWithValue("@Anh", imageData);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Bạn đã cập nhật {TenDangNhap} thành công");
                    if (TenDangNhap == Account.UserName)
                    {
                        DatabaseConnection.ConnectString = $"Data Source=.;Initial Catalog=QLNhaSach;User ID={TenDangNhap};Password={MatKhau}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (Cap != 1 && TenDangNhap == Account.UserName)
                {
                    MessageBox.Show("Bạn đã không còn quyền admin, nhấn Ok để đăng xuất", "Thông báo", MessageBoxButtons.OK);
                    ReturnLoginForm?.Invoke(this, null );
                    return;
                }
            }
            ResetData();
            DBConnection.Close();
        }

        private void btn_update_account_Click(object sender, EventArgs e)
        {
            Txt_Password.Enabled = true;
            CB_Position.Enabled = true;
            Txt_Name.Enabled = true;
            Btn_ChoosePic.Enabled = true;

            ControlState = "update";
        }

        private void btn_delete_account_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show(
                $"Xác nhận xóa tài khoản {Txt_Username.Text} của nhân viên {Txt_Name.Text}, nhấn Ok để xác nhận!",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (dl != DialogResult.OK)
            {
                return;
            }

            ControlState = "delete";
            DBConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.GetConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Proc_XoaTaiKhoan";

            String TenDangNhap = Txt_Username.Text.Trim();
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa tài khoản thành công sách thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            ResetData();
            DBConnection.Close();
        }

        private void DG_AccountDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Username.Enabled = false;
            Txt_Password.Enabled = false;
            Txt_Name.Enabled = false;
            CB_Position.Enabled = false;
            Btn_ChoosePic.Enabled = false;
            btn_canncel.Enabled = false;
            btn_delete_account.Enabled = false;
            btn_new_account.Enabled = true;
            btn_update_account.Enabled = false;
            ControlState = "none";

            DataTable dt = (DataTable)DG_AccountDetail.DataSource;
            int chiSo = DG_AccountDetail.SelectedCells[0].RowIndex;
            DataRow dr = dt.Rows[chiSo];

            Txt_Username.Text = dr["TenDangNhap"].ToString();
            Txt_Password.Text = dr["MatKhau"].ToString();
            Txt_Name.Text = dr["TenNguoiDung"].ToString();
            CB_Position.Text = dr["ChucVu"].ToString();

            Picturebox_ProfilePic.Image = null;

            if (DG_AccountDetail.CurrentRow.Cells[4].Value != DBNull.Value)
            {
                try
                {
                    Image image = null;
                    image = Utils.GenerateImageFromData((byte[])DG_AccountDetail.CurrentRow.Cells[4].Value);
                    Picturebox_ProfilePic.Image = image;

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                }
            }
            btn_update_account.Enabled = true;
            btn_delete_account.Enabled = true;
        }

        private void UC_HR_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        private void Btn_ChoosePic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|*.jpg|png|*.png|gif|*.gif|All Files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Picturebox_ProfilePic.ImageLocation = openFileDialog1.FileName;
                openFileDialog1.Dispose();
            }
        }
    }
}
