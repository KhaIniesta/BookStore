using System.Windows.Forms;

namespace BookStore.UserControls
{
    public partial class UC_Cashier : UserControl
    {

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pn_Cashier.Controls.Clear();
            pn_Cashier.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public UC_Cashier()
        {
            InitializeComponent();
            UC_BookItem uC_BookItem = new UC_BookItem();
            AddUserControl(uC_BookItem);
        }
    }
}
