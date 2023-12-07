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
    public partial class UC_AllReceiptDetail : UserControl
    {
        public UC_AllReceiptDetail()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234");
        SqlCommand cmd = null;

        public event EventHandler ChangeUCClicked;

        public void ShowDetails(string ReceiptID)
        {
            Lbl_Title.Text = "All Receipt Detail of " + ReceiptID;

            conn.Open();
            cmd = new SqlCommand("Proc_HienCTHDTheoMaHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = ReceiptID;
            var DA = new SqlDataAdapter(cmd);
            var DT = new DataTable();
            DA.Fill(DT);
            conn.Close();
            DG_AllReceiptDetail.DataSource = DT;
        }

        private void UC_AllReceiptDetail_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Details_Click(object sender, EventArgs e)
        {
            ChangeUCClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
