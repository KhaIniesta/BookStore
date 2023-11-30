using BookStore.UserControls;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BookStore.Forms
{
    public partial class Form_Cashier : Form
    {
        public static void LoadBookDetail(DataRow dr)
        {
            
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pn_container.Controls.Clear();
            pn_container.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public Form_Cashier()
        {
            InitializeComponent();
        }

        private void Form_Cashier_Load(object sender, EventArgs e)
        {
            UC_Cashier uC_Cashier = new UC_Cashier();
            uC_Cashier.Btn_receipt_detail_click += Btn_receipt_detail_click;
            AddUserControl(uC_Cashier);
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new Form_Login();
            form.Show();
        }

        private void Btn_receipt_detail_click(object sender, EventArgs e)
        {
            UC_ReceipDetail uC_ReceipDetail = new UC_ReceipDetail();
            AddUserControl(uC_ReceipDetail);
        }
    }
}
