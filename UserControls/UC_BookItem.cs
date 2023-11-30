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
    public partial class UC_BookItem : UserControl
    {
        private String _bookID;
        public UC_BookItem()
        {
            InitializeComponent();
            CustomClickEventForAllControl();
        }

        private void CustomClickEventForAllControl()
        {
            foreach(Control ct in this.Controls)
            {
                ct.Click += UC_BookItem_Click;
            }
        }

        public UC_BookItem(String BookID, String name, String Price, String Quantity, Image Image)
        {
            InitializeComponent();
            CustomClickEventForAllControl();
            lb_name.Text = name;
            lbl_price.Text = Price.ToString();
            lb_quantity.Text = Quantity.ToString();
            Pb_Image.Image = Image;
            this._bookID = BookID;
        }

        public event EventHandler Clicked;

        private void UC_BookItem_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }

        public String GetBookID()
        {
            return _bookID;
        }
    }
}
