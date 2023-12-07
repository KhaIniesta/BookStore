using BookStore.Report;
using BookStore.UserControls;
using System;
using System.Data;
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
            uC_ReceipDetail.ReturnUC_Casher += UC_ReceipDetail_ReturnUC_Casher;
            AddUserControl(uC_ReceipDetail);
        }

        private void UC_ReceipDetail_ReturnUC_Casher(object sender, EventArgs e)
        {
            UC_Cashier uC_Cashier = new UC_Cashier();
            uC_Cashier.Btn_receipt_detail_click += Btn_receipt_detail_click;
            AddUserControl(uC_Cashier);
        }

        private void Txt_Searchbox_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Enter)
            {
                String searchContent = Txt_Searchbox.Text;

                if (pn_container.Controls.Count == 1)
                {
                    Control containedControl = pn_container.Controls[0];
                    if (containedControl is UC_Cashier)
                    {
                        UC_Cashier uc_casher = (UC_Cashier)containedControl;
                        uc_casher.LoadDataWithSearchContent(searchContent);
                    }
                    else if (containedControl is UC_ReceipDetail)
                    {
                        UC_ReceipDetail uc_receipt_detail = (UC_ReceipDetail)containedControl;
                        uc_receipt_detail.LoadDataWithSearchContent(searchContent);
                    }
                }
            }
        }
    }
}
