using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.UserControls
{
    public partial class UC_ReceipDetail : UserControl
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();
        private DataTable dt;

        private void ResetDuLieu()
        {
            DBConnection.Open();
            pn_bookItems.Dock = DockStyle.Fill;
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
            }
            DBConnection.Close();
        }
        public UC_ReceipDetail()
        {
            InitializeComponent();
        }

        private void UC_ReceipDetail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                UC_BookItem item = new UC_BookItem();
                pn_bookItems.Controls.Add(item);
            }

            for (int i = 0;i < 10;i++)
            {
                UC_BookOrderItem item = new UC_BookOrderItem();
                flp_bookItems.Controls.Add(item);
            }
        }
    }
}
