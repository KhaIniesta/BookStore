using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.UserControls
{
    public partial class UC_Cashier : UserControl
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();
        private DataTable dt;
        public event EventHandler Btn_receipt_detail_click;

        private void RenderPanelCasher()
        {
            pn_Cashier.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                String BookID = dr["MaSach"].ToString();
                String ItemName = dr["TenSach"].ToString();
                String Price = dr["Gia"].ToString();
                String Quantity = dr["SoLuongSach"].ToString();
                Image BookImage = null;
                try
                {
                    BookImage = Utils.GenerateImageFromData((byte[])dr["Anh"]);

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                }

                UC_BookItem uC_BookItem = new UC_BookItem(BookID, ItemName, Price, Quantity, BookImage);
                uC_BookItem.Clicked += UC_BookItem_Clicked;
                pn_Cashier.Controls.Add(uC_BookItem);
            }
        }

        public void LoadDataWithSearchContent(string searchContent)
        {
            dt = new DataTable();
            if (searchContent != null && searchContent != "")
            {
                DBConnection.Open();
                SqlCommand cmd = new SqlCommand("Proc_TimKiemSach", DBConnection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = searchContent;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DBConnection.Close();

                RenderPanelCasher();
            }
            else
            {
                ResetDuLieu();
            }
        }

        private void ResetDuLieu()
        {
            DBConnection.Open();
            pn_Cashier.Dock = DockStyle.Fill;
            pn_Cashier.Controls.Clear();

            string sql = "Select * from V_HienChiTietSach";
            dt = DBConnection.GetTable(sql);
            DBConnection.Close();

            RenderPanelCasher();
        }

        public UC_Cashier()
        {
            InitializeComponent();
        }

        private void UC_BookItem_Clicked(object sender, EventArgs e)
        {
            if (sender is UC_BookItem clickedUC_BookItem)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaSach"].ToString() == clickedUC_BookItem.GetBookID())
                    {
                        txt_bookid_detail.Text = dr["MaSach"].ToString();
                        txt_bookname_detail.Text = dr["TenSach"].ToString();
                        txt_publisher_detail.Text = dr["TenNXB"].ToString();
                        txt_author_detail.Text = dr["TenTG"].ToString();
                        txt_quantity_detail.Text = dr["SoLuongSach"].ToString();
                        txt_genre_detail.Text = dr["TheLoai"].ToString();
                        txt_price_detail.Text = dr["Gia"].ToString();

                        if (dr["Anh"] != DBNull.Value)
                        {
                            try
                            {
                                Image image = null;
                                image = Utils.GenerateImageFromData((byte[])dr["Anh"]);
                                pb_book_image_detail.Image = image;

                            }
                            catch (Exception ex)
                            {
                                System.Console.WriteLine(ex);
                            }
                        }
                        else
                        {
                            pb_book_image_detail.Image = null;
                        }
                    }
                }
            }
        }
        private void UC_Cashier_Load(object sender, System.EventArgs e)
        {
            ResetDuLieu();
        }

        private void btn_add_receipt_detail_Click(object sender, EventArgs e)
        {
            Btn_receipt_detail_click?.Invoke(this, EventArgs.Empty);
        }
    }
}
