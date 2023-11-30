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

namespace BookStore.Forms
{
    public partial class Form_Login : Form
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();
        private String StateControl = "none";
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Người dùng có thể quay lại đăng nhập từ một user khác admin, khi đó cần khôi phục lại chuỗi kết nối để thực hiện bước đăng nhập
            DatabaseConnection.ConnectString = "Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234";
            DatabaseConnection DBConnection= new DatabaseConnection();
            StateControl = "login";
            DBConnection.Open();

            SqlCommand cmd = new SqlCommand("select dbo.func_DangNhap(@TenDangNhap,@MatKhau)", DBConnection.GetConnection());
            string UserName = txt_username.Text;
            cmd.Parameters.AddWithValue("@TenDangNhap", UserName);
            string Password = txt_password.Text;
            cmd.Parameters.AddWithValue("@MatKhau", Password);

            try
            {
                int Position = (int)cmd.ExecuteScalar();

                Account.UserName = UserName;
                Account.PassWord = Password;
                Account.Position = Position;
                // Thay đổi chuỗi kết nối để kết nối Database với quyền tương ứng
                DatabaseConnection.ConnectString = $"Data Source=.;Initial Catalog=QLNhaSach;User ID={UserName};Password={Password}";

                if (Position == 1)
                {
                    Form form = new Form_Admin();
                    this.Hide();
                    form.Show();
                }
                else if (Position == 2)  // nhan vien thu ngan
                {
                    Form form = new Form_Cashier();
                    this.Hide();
                    form.Show();
                }
                else if (Position == 3) // Quản lí kho
                {
                    Form form = new Form_SM();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    // Đăng nhập thất bại thì khôi phục lại chuỗi kết nối gốc
                    DatabaseConnection.ConnectString = "Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234";
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DBConnection.Close();
        }
    }
}
