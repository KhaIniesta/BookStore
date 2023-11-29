using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.UserControls
{
    public partial class UC_ReceipDetail : UserControl
    {
        public UC_ReceipDetail()
        {
            InitializeComponent();
        }

        private void UC_ReceipDetail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                UC_BookItem item = new UC_BookItem();
                pn_bookItems.Controls.Add(item);
            }

            for (int i = 0;i < 10;i++)
            {
                UC_BookOrderItem item = new UC_BookOrderItem();
                flp_bookItems.Controls.Add(item);
            }
        }
    }
}
