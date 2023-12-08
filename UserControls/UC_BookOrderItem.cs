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
            txt_BookQuantity.KeyDown += new KeyEventHandler(txt_BookQuantity_KeyDown);
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
            txt_BookQuantity.Text = "1";
            lbl_BookName.Text = name.ToString();
            this._bookID = BookID;
            this._quantity = txt_BookQuantity.Text.Trim();
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
            return txt_BookQuantity.Text;
        }

        public void SetBoughtQuantity()
        {
            int quanNum = Convert.ToInt32(_quantity);
            quanNum = 1;
            _quantity = quanNum.ToString();
            txt_BookQuantity.Text = _quantity;
        }

        public event EventHandler IncreaseButtonClicked;
        public event EventHandler DescreaseButtonClicked;
        public event EventHandler DeleteBookFromReceiptClicked;
        public event EventHandler QuantityOver;
        public event EventHandler TextBoxEnter;

        private void btn_IncreaseQuantity_Click(object sender, EventArgs e)
        {
            int newquantity = int.Parse(txt_BookQuantity.Text) + 1;
            txt_BookQuantity.Text = Convert.ToString(newquantity);
            _quantity = txt_BookQuantity.Text.Trim();

            IncreaseButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_DecreaseQuantity_Click(object sender, EventArgs e)
        {
            int newquantity = int.Parse(txt_BookQuantity.Text);
            if (newquantity > 1)
            {
                newquantity -= 1;
                txt_BookQuantity.Text = Convert.ToString(newquantity);
                _quantity = txt_BookQuantity.Text.Trim();
            }
            DescreaseButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBookFromReceiptClicked?.Invoke(this, EventArgs.Empty);
        }

        private void txt_BookQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private void txt_BookQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txt_BookQuantity.Text == "" || txt_BookQuantity.Text == "00")
            {
                txt_BookQuantity.Text = "1";
            }
        }

        private void txt_BookQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBoxEnter?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
