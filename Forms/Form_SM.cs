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
    public partial class Form_SM : Form
    {
        public Form_SM()
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

        private void Btn_AuthorTab_Click(object sender, EventArgs e)
        {
            Btn_AuthorTab.Checked = true;
            UC_Author UC = new UC_Author();
            AddUserControl(UC);
        }

        private void Panel_Container_Paint(object sender, PaintEventArgs e)
        {

        }
    
    }

}
