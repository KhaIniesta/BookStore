using System;
using System.Windows.Forms;

namespace BookStore.UserControls
{
    public partial class UC_BookOrderItem : UserControl
    {
        public UC_BookOrderItem()
        {
            InitializeComponent();
            CustomClickEventForAllControl();
        }
        private String _bookID;
        private String _quantity;

        private void CustomClickEventForAllControl()
        {
            foreach (Control ct in this.Controls)
            {
                ct.Click += UC_BookOrderItem_Click;
            }
        }

        public UC_BookOrderItem(String BookID, String name, String Price)
        {
            InitializeComponent();
            CustomClickEventForAllControl();
            lbl_BookPrice.Text = Price.ToString();
            lbl_BookQuantity.Text = "1";
            lbl_BookName.Text = name.ToString();
            this._bookID = BookID;
            this._quantity = lbl_BookQuantity.Text.Trim();
        }


        public event EventHandler Clicked;
        private void UC_BookOrderItem_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }


        public String GetBookID()
        {
            return _bookID;
        }

        public String GetBoughtQuantity()
        {
            return _quantity;
        }

        public event EventHandler IncreaseButtonClicked;
        public event EventHandler DescreaseButtonClicked;

        private void btn_IncreaseQuantity_Click(object sender, EventArgs e)
        {
            int newquantity = int.Parse(lbl_BookQuantity.Text) + 1;
            lbl_BookQuantity.Text = Convert.ToString(newquantity);
            _quantity = lbl_BookQuantity.Text.Trim();

            IncreaseButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_DecreaseQuantity_Click(object sender, EventArgs e)
        {
            int newquantity = int.Parse(lbl_BookQuantity.Text);
            if (newquantity > 1)
            {
                newquantity -= 1;
                lbl_BookQuantity.Text = Convert.ToString(newquantity);
                _quantity = lbl_BookQuantity.Text.Trim();
            }
            DescreaseButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
