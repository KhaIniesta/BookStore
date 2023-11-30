using BookStore.Forms;
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

namespace BookStore
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl UC)
        {
            UC.Dock = DockStyle.Fill;
            Panel_Container.Controls.Clear();
            Panel_Container.Controls.Add(UC);
            UC.BringToFront();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Btn_HomeTab.Checked = true;
            UC_aHome UC = new UC_aHome();
            AddUserControl(UC);
        }

        private void Btn_HomeTab_Click(object sender, EventArgs e)
        {
            Btn_HomeTab.Checked = true;
            UC_aHome UC = new UC_aHome();
            AddUserControl(UC);
        }

        private void Btn_BookTab_Click(object sender, EventArgs e)
        {
            Btn_BookTab.Checked = true;
            UC_aBook UC = new UC_aBook();
            AddUserControl(UC);
        }

        private void Btn_PublisherTab_Click(object sender, EventArgs e)
        {
            Btn_PublisherTab.Checked = true;
            UC_aPublisher UC = new UC_aPublisher();
            AddUserControl(UC);
        }

        private void Btn_ReceiptTab_Click(object sender, EventArgs e)
        {
            Btn_ReceiptTab.Checked = true;
            UC_I_Receipt UC = new UC_I_Receipt();
            AddUserControl(UC);
        }

        private void Btn_RevenueTab_Click(object sender, EventArgs e)
        {
            Btn_RevenueTab.Checked = true;
            UC_Revenue UC = new UC_Revenue();
            AddUserControl(UC);
        }

        private void Btn_HRTab_Click(object sender, EventArgs e)
        {
            Btn_HRTab.Checked = true;
            UC_HR UC = new UC_HR();
            AddUserControl(UC);
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new Form_Login();
            form.Show();
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
