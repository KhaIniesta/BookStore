using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.UserControls;

namespace BookStore.UserControls
{
    public partial class UC_I_Receipt : UserControl
    {
        public UC_I_Receipt()
        {
            InitializeComponent();
        }
       

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public event EventHandler AddControlButtonClick;

     /*   private void guna2Button5_Click(object sender, EventArgs e)
        {
            btn_addbook.Checked = true;
            UserControl user = new UC_Insert_I_ReceiptDetail();
            // Kích hoạt sự kiện AddControlButtonClick khi nút được click
            AddControlButtonClick?.Invoke(this, EventArgs.Empty);
        }*/

       /* private void btn_viewdetail_Click(object sender, EventArgs e)
        {
            btn_viewdetail.Checked = true;
            UserControl user = new UC_ViewAll_I_ReceiptDetail();
            AddControlButtonClick?.Invoke(this, EventArgs.Empty);
        }*/

        private void btn_addbook_Click_1(object sender, EventArgs e)
        {
            btn_addbook.Checked = true;
            UserControl user = new UC_Insert_I_ReceiptDetail();
            // Kích hoạt sự kiện AddControlButtonClick khi nút được click
            AddControlButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void btn_viewdetail_Click_1(object sender, EventArgs e)
        {
            btn_viewdetail.Checked = true;
            UserControl user = new UC_ViewAll_I_ReceiptDetail();
            AddControlButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
