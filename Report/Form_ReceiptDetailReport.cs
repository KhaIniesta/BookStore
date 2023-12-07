using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore.Report
{
    public partial class Form_ReceiptDetailReport : Form
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();
        private DataTable dt;
        private SqlCommand cmd;
        public Form_ReceiptDetailReport()
        {
            InitializeComponent();
        }
    }
}
