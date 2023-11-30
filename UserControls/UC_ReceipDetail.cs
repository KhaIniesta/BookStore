using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.UserControls
{
    public partial class UC_ReceipDetail : UserControl
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();
        private DataTable dt;
        private SqlCommand cmd;
        public event EventHandler Btn_delete_receipt_click;
        private void ResetDuLieu()
        {
            DBConnection.Open();
            //pn_bookItems.Dock = DockStyle.Fill;
            pn_bookItems.Controls.Clear();

            string sql = "Select * from V_HienChiTietSach";
            dt = DBConnection.GetTable(sql);

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
                pn_bookItems.Controls.Add(uC_BookItem);
                uC_BookItem.Clicked += UC_BookItem_Clicked;
            }
            DBConnection.Close();
        }
        public UC_ReceipDetail()
        {
            InitializeComponent();
        }

        private void UpdateTotalReceiptPrice(string ReceiptID)
        {
            cmd = new SqlCommand("Proc_TimKiemTheoMaHD", DBConnection.GetConnection());
            DBConnection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = ReceiptID.Trim();
            ;
            string total = cmd.ExecuteScalar()?.ToString();
            lbl_Subtotal.Text = total;
            DBConnection.Close();

        }

        private int InsertBookIntoReceiptDetail(string ReceiptID, string BookID, string Quantity)
        {
            DBConnection.Open();
            cmd = new SqlCommand("Proc_ThemSachCTHD", DBConnection.GetConnection());
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = ReceiptID.Trim();
                cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = BookID.Trim();
                cmd.Parameters.Add("@SoLuongBan", SqlDbType.Int).Value = Quantity.Trim();

                int count = cmd.ExecuteNonQuery();
                DBConnection.Close();
                return count;
            }
            catch (Exception ex)
            {
                DBConnection.Close();
                MessageBox.Show(ex.Message, "Thông báo!");
            }
            finally
            {
                DBConnection.Close();
            }
            return -1;
        }
        private int UpdateBookIntoReceiptDetail(string ReceiptID, string BookID, string Quantity)
        {
            DBConnection.Open();
            cmd = new SqlCommand("Proc_CapNhatSachCTHD", DBConnection.GetConnection());
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = ReceiptID.Trim();
                cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = BookID.Trim();
                cmd.Parameters.Add("@SoLuongBan", SqlDbType.Int).Value = Quantity.Trim();

                int count = cmd.ExecuteNonQuery();
                DBConnection.Close();
                return count;
            }
            catch (Exception ex)
            {
                DBConnection.Close();
                MessageBox.Show(ex.Message, "Thông báo!");
            }
            finally
            {
                DBConnection.Close();
            }
            return -1;
        }

        private int DeleteBookFromReceiptDetail(string ReceiptID, string BookID)
        {
            DBConnection.Open();
            cmd = new SqlCommand("Proc_XoaSachCTHD", DBConnection.GetConnection());
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = ReceiptID.Trim();
                cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = BookID.Trim();

                int count = cmd.ExecuteNonQuery();
                DBConnection.Close();
                return count;
            }
            catch (Exception ex)
            {
                DBConnection.Close();
                MessageBox.Show(ex.Message, "Thông báo!");
            }
            finally
            {
                DBConnection.Close();
            }
            return -1;
        }

        private void DeleteReceipt(String ReceiptID)
        {
            cmd = new SqlCommand("Proc_XoaHoaDon", DBConnection.GetConnection());
            DBConnection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = ReceiptID.Trim();
            cmd.ExecuteNonQuery();
            DBConnection.Close();
        }
        private void UC_ReceipDetail_Load(object sender, EventArgs e)
        {
            ResetDuLieu();
            lbl_datetime.Text = DateTime.Now.ToString();

            cmd = new SqlCommand("Proc_ThemMaHoaDon", DBConnection.GetConnection());
            DBConnection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lbl_ReceiptID.Text = dr["MaHD"].ToString();
            }
            DBConnection.Close();
        }

        private void UC_BookItem_Clicked(object sender, EventArgs e)
        {
            if (sender is UC_BookItem clickedUC_BookItem)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaSach"].ToString() == clickedUC_BookItem.GetBookID())
                    {
                        String BookID = dr["MaSach"].ToString();
                        String Name = dr["TenSach"].ToString();
                        String Price = dr["Gia"].ToString();
                        String ReceiptID = lbl_ReceiptID.Text.Trim();

                        UC_BookOrderItem uC_BookOrderItem = new UC_BookOrderItem(BookID, Name, Price);
                        uC_BookOrderItem.IncreaseButtonClicked += UpdateBookOrder;
                        uC_BookOrderItem.DescreaseButtonClicked += UpdateBookOrder;
                        uC_BookOrderItem.DeleteBookFromReceiptClicked += DeleteBookOrder;

                        String Quantity = uC_BookOrderItem.GetBoughtQuantity();
                        int count = InsertBookIntoReceiptDetail(ReceiptID, BookID, Quantity);

                        if (count > 0)
                        {
                            flp_bookItems.Controls.Add(uC_BookOrderItem);
                            UpdateTotalReceiptPrice(ReceiptID);
                        }
                        UpdateTotalBill(ReceiptID);
                    }
                }
            }
        }

        public event EventHandler ReturnUC_Casher;
        private void btn_DeleteReceipt_Click(object sender, EventArgs e)
        {
            string ReceiptID = lbl_ReceiptID.Text.Trim();
            DeleteReceipt(ReceiptID);
            ReturnUC_Casher?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateBookOrder(object sender, EventArgs e)
        {
            if (sender is UC_BookOrderItem clicked_UCBookOrderItem)
            {
                String BookID = clicked_UCBookOrderItem.GetBookID();
                String ReceiptID = lbl_ReceiptID.Text.Trim();
                String Quantity = clicked_UCBookOrderItem.GetBoughtQuantity();

                int count = UpdateBookIntoReceiptDetail(ReceiptID, BookID, Quantity);

                if (count > 0)
                {
                    UpdateTotalReceiptPrice(ReceiptID);
                    UpdateTotalBill(ReceiptID);
                }
            }
        }
        public void DeleteBookOrder(object sender, EventArgs e)
        {
            if (sender is UC_BookOrderItem clicked_UCBookOrderItem)
            {
                String BookID = clicked_UCBookOrderItem.GetBookID();
                String ReceiptID = lbl_ReceiptID.Text.Trim();

                int count = DeleteBookFromReceiptDetail(ReceiptID, BookID);
                flp_bookItems.Controls.Remove(clicked_UCBookOrderItem);
                if (count > 0)
                {
                    UpdateTotalReceiptPrice(ReceiptID);
                    UpdateTotalBill(ReceiptID);
                }
            }
        }

        public void UpdateTotalBill(String ReceiptID)
        {
            double subtotalbill = double.Parse(lbl_Subtotal.Text);
            if (subtotalbill >= 1000000)
            {
                lbl_Sale.Text = "10%";
            }
            else if (subtotalbill >= 2500000)
            {
                lbl_Sale.Text = "20%";
            }
            else if (subtotalbill >= 3500000)
            {
                lbl_Sale.Text = "30%";
            }
            else
            {
                lbl_Sale.Text = "0%";
            }
            double sale = double.Parse(lbl_Sale.Text.Replace("%", "")) / 100;
            decimal TotalBill = (Decimal)(subtotalbill - subtotalbill * sale);

            DBConnection.Open();
            string sql = $"update HoaDon set TongHD = {TotalBill} " +
                $"where MaHD = {ReceiptID}";
            cmd.ExecuteNonQuery();
            DBConnection.Close();

            lbl_Total.Text = TotalBill.ToString();
        }
    }
}
