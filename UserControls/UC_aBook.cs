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
    public partial class UC_aBook : UserControl
    {
        public UC_aBook()
        {
            InitializeComponent();
        }
        private DatabaseConnection DBC = new DatabaseConnection();
        private String StateControl = "none";

        private void ResetDataGridView()
        {
            string sql = "SELECT " +
                "MaSach as 'Book ID'" +
                ", MaTG as 'Author ID'" +
                ", MaNXB as 'Publisher ID'" +
                ", TenSach as 'Book Name'" +
                ", SoLuongSach as 'Quantity'" +
                ", Gia as 'Price'" +
                ", TheLoai as 'Genre'" +
                ", Anh as 'Picture'" +
                " FROM dbo.Func_LayBangSach()";
            DG_Books.DataSource = DBC.GetTable(sql);
        }
        private void EnableTextbox()
        {
            Txt_Name.Enabled = true;
            Txt_BookID.Enabled = true;
            CB_PublisherID.Enabled = true;
            CB_AuthorID.Enabled = true;
            Txt_Quantity.Enabled = true;
            Txt_Genre.Enabled = true;
            Txt_Price.Enabled = true;
        }
        private void DisableTextbox()
        {
            Txt_Name.Enabled = false;
            Txt_BookID.Enabled = false;
            CB_PublisherID.Enabled = false;
            CB_AuthorID.Enabled = false;
            Txt_Quantity.Enabled = false;
            Txt_Genre.Enabled = false;
            Txt_Price.Enabled = false;
        }
        private void ResetTextbox()
        {
            Txt_Name.Clear();
            Txt_BookID.Clear();

            CB_PublisherID.ResetText();
            CB_AuthorID.ResetText();

            Txt_Quantity.Clear();
            Txt_Genre.Clear();
            Txt_Price.Clear();
        }
        private bool CheckInputData()
        {
            if (Txt_BookID.Text.Trim() == "")
            {
                MessageBox.Show("Mã sách không được trống!");
                return false;
            }
            if (Txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("Tên sách không được trống!");
                return false;

            }
            if (Txt_Genre.Text.Trim() == "")
            {
                MessageBox.Show("Thể loại không được trống!");
                return false;

            }
            if (Txt_Quantity.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng sách không được trống!");
                return false;

            }
            if (Txt_Price.Text.Trim() == "")
            {
                MessageBox.Show("Giá sách không được trống!");
                return false;
            }
            return true;
        }
        private void UC_aBook_Load(object sender, EventArgs e)
        {
            ResetDataGridView();

            CB_AuthorID.DataSource = DBC.GetTable("SELECT MaTG FROM TacGia");
            CB_AuthorID.DisplayMember = "MaTG";
            CB_AuthorID.ValueMember = "MaTG";

            CB_PublisherID.DataSource = DBC.GetTable("SELECT MaNXB FROM NhaXuatBan");
            CB_PublisherID.DisplayMember = "MaNXB";
            CB_PublisherID.ValueMember = "MaNXB";
        }

        private void DG_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableTextbox();

            Btn_UpdateBook.Enabled = true;
            Btn_DeleteBook.Enabled = true;
            Btn_ResetTxt.Enabled = true;

            Txt_Name.Text = DG_Books.SelectedRows[0].Cells[3].Value.ToString();
            Txt_BookID.Text = DG_Books.SelectedRows[0].Cells[0].Value.ToString();
            CB_PublisherID.Text = DG_Books.SelectedRows[0].Cells[2].Value.ToString();
            CB_AuthorID.Text = DG_Books.SelectedRows[0].Cells[1].Value.ToString();
            Txt_Quantity.Text = DG_Books.SelectedRows[0].Cells[4].Value.ToString();
            Txt_Genre.Text = DG_Books.SelectedRows[0].Cells[6].Value.ToString();
            Txt_Price.Text = DG_Books.SelectedRows[0].Cells[5].Value.ToString();

            //PictureBox.Image = Utils.ChuyenVeHinhAnh((byte[])DG_Books.SelectedRows[0].Cells[5].Value);
            if (DG_Books.CurrentRow.Cells[5].Value != DBNull.Value)
            {
                try
                {
                    Image image = null;
                    image = Utils.ChuyenVeHinhAnh((byte[])DG_Books.CurrentRow.Cells[7].Value);
                    PictureBox.Image = image;

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                }
            }
        }

        private void Btn_ResetTxt_Click(object sender, EventArgs e)
        {
            ResetTextbox();

            Btn_DeleteBook.Enabled = false;
            Btn_UpdateBook.Enabled = false;
        }

        private void Btn_UpdateBook_Click(object sender, EventArgs e)
        {
            StateControl = "update";
            EnableTextbox();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(!CheckInputData())
            {
                ResetText(); 
                return;
            }
            DBC.Open();
            if(StateControl == "add")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBC.GetConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Proc_ThemSach";

                cmd.Parameters.AddWithValue("@MaSach", Txt_BookID.Text);
                cmd.Parameters.AddWithValue("@MaTG", CB_AuthorID.Text);
                cmd.Parameters.AddWithValue("@MaNXB", CB_PublisherID.Text);
                cmd.Parameters.AddWithValue("@TenSach", Txt_Name.Text);
                cmd.Parameters.AddWithValue("@SoLuongSach", int.Parse(Txt_Quantity.Text));
                cmd.Parameters.AddWithValue("@Gia", Txt_Price.Text);
                cmd.Parameters.AddWithValue("@TheLoai", Txt_Genre.Text);

                byte[] imageData = Utils.TaoDataImageTuLinkFile(PictureBox.ImageLocation);
                cmd.Parameters.AddWithValue("@Anh", imageData);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm sách thành công");
                    ResetTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(StateControl == "update")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBC.GetConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Proc_SuaSach";

                String maSach = Txt_BookID.Text.Trim();

                cmd.Parameters.AddWithValue("@MaSach", maSach);
                cmd.Parameters.AddWithValue("@MaTG", CB_AuthorID.Text);
                cmd.Parameters.AddWithValue("@MaNXB", CB_PublisherID.Text);
                cmd.Parameters.AddWithValue("@TenSach", Txt_Name.Text);
                cmd.Parameters.AddWithValue("@SoLuongSach", int.Parse(Txt_Quantity.Text));

                String gia = Txt_Price.Text.Trim().Split(',')[0];
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@TheLoai", Txt_Genre.Text);

                byte[] imageData = Utils.TaoDataImageTuLinkFile(PictureBox.ImageLocation);
                cmd.Parameters.AddWithValue("@Anh", imageData);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã sửa sách thành công");
                    DisableTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            ResetDataGridView();
            StateControl = "none";
        }

        private void Btn_Newbook_Click(object sender, EventArgs e)
        {
            StateControl = "add";
            EnableTextbox();
            ResetTextbox();
        }

        private void Btn_DeleteBook_Click(object sender, EventArgs e)
        {
            StateControl = "xoa";
            DBC.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBC.GetConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Proc_XoaSach";

            String maSach = Txt_BookID.Text.Trim();
            cmd.Parameters.AddWithValue("@MaSach", maSach);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa sách thành công");
                EnableTextbox();
                ResetTextbox();
                DisableTextbox();
                Btn_DeleteBook.Enabled = false;
                Btn_UpdateBook.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            ResetDataGridView();
            DBC.Close();
        }
    }
}
