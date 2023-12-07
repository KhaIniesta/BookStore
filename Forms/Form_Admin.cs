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
        UC_Revenue UC_Rev;
        UC_AllReceiptDetail UC_AllRecDetail;

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
            InitUCsForRevenueTab();
        }

        private void Btn_HRTab_Click(object sender, EventArgs e)
        {
            Btn_HRTab.Checked = true;
            UC_HR UC = new UC_HR();
            UC.ReturnLoginForm += Btn_Logout_Click;
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

        private void Btn_AuthorTab_Click(object sender, EventArgs e)
        {
            Btn_AuthorTab.Checked = true;
            UC_Author UC = new UC_Author();
            AddUserControl(UC);
        }

        // followings for change UC
        private void InitUCsForRevenueTab()
        {
            UC_Rev = new UC_Revenue();
            UC_Rev.ChangeUCClicked += UC_Rev_ChangeClicked;

            UC_AllRecDetail = new UC_AllReceiptDetail();;
            UC_AllRecDetail.ChangeUCClicked += UC_AllRecDetail_ChangeClicked;

            UC_Rev.SetUC_AllRecDetail_Reference(UC_AllRecDetail);

            AddUserControl(UC_Rev);
        }
        private void UC_Rev_ChangeClicked(object sender, EventArgs e)
        {
            AddUserControl(UC_AllRecDetail);
        }
        private void UC_AllRecDetail_ChangeClicked(object sender, EventArgs e)
        {
            AddUserControl(UC_Rev);
        }

    }
}
