using BookStore.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms
{
    public partial class Form_Cashier : Form
    {
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
            UC_ReceipDetail uC_ReceipDetail = new UC_ReceipDetail();
            AddUserControl(uC_ReceipDetail);
        }
    }
}
