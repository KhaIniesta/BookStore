namespace BookStore.UserControls
{
    partial class UC_BookOrderItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BookOrderItem));
            this.btn_DeleteBook = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_BookName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_BookPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbl_BookQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_DecreaseQuantity = new Guna.UI2.WinForms.Guna2Button();
            this.btn_IncreaseQuantity = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DeleteBook
            // 
            this.btn_DeleteBook.AutoRoundedCorners = true;
            this.btn_DeleteBook.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteBook.BorderRadius = 20;
            this.btn_DeleteBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DeleteBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DeleteBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DeleteBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DeleteBook.FillColor = System.Drawing.Color.Empty;
            this.btn_DeleteBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_DeleteBook.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteBook.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.btn_DeleteBook.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.btn_DeleteBook.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_DeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteBook.Image")));
            this.btn_DeleteBook.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_DeleteBook.Location = new System.Drawing.Point(13, 3);
            this.btn_DeleteBook.Name = "btn_DeleteBook";
            this.btn_DeleteBook.ShadowDecoration.BorderRadius = 21;
            this.btn_DeleteBook.Size = new System.Drawing.Size(42, 42);
            this.btn_DeleteBook.TabIndex = 0;
            this.btn_DeleteBook.Click += new System.EventHandler(this.btn_DeleteBook_Click);
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = false;
            this.lbl_BookName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BookName.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookName.Location = new System.Drawing.Point(59, 3);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(298, 40);
            this.lbl_BookName.TabIndex = 1;
            this.lbl_BookName.Text = "Sự im lặng của bầy cừu";
            // 
            // lbl_BookPrice
            // 
            this.lbl_BookPrice.AutoSize = false;
            this.lbl_BookPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BookPrice.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookPrice.Location = new System.Drawing.Point(504, 5);
            this.lbl_BookPrice.Name = "lbl_BookPrice";
            this.lbl_BookPrice.Size = new System.Drawing.Size(130, 38);
            this.lbl_BookPrice.TabIndex = 2;
            this.lbl_BookPrice.Text = "125000 Đ";
            this.lbl_BookPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.lbl_BookQuantity);
            this.guna2GradientPanel1.Controls.Add(this.btn_DecreaseQuantity);
            this.guna2GradientPanel1.Controls.Add(this.btn_IncreaseQuantity);
            this.guna2GradientPanel1.CustomizableEdges.BottomRight = false;
            this.guna2GradientPanel1.CustomizableEdges.TopRight = false;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(388, 10);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(110, 29);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // lbl_BookQuantity
            // 
            this.lbl_BookQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BookQuantity.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookQuantity.Location = new System.Drawing.Point(46, 4);
            this.lbl_BookQuantity.Name = "lbl_BookQuantity";
            this.lbl_BookQuantity.Size = new System.Drawing.Size(12, 18);
            this.lbl_BookQuantity.TabIndex = 2;
            this.lbl_BookQuantity.Text = "5";
            // 
            // btn_DecreaseQuantity
            // 
            this.btn_DecreaseQuantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DecreaseQuantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DecreaseQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DecreaseQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DecreaseQuantity.FillColor = System.Drawing.Color.Empty;
            this.btn_DecreaseQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_DecreaseQuantity.ForeColor = System.Drawing.Color.White;
            this.btn_DecreaseQuantity.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_DecreaseQuantity.Image = ((System.Drawing.Image)(resources.GetObject("btn_DecreaseQuantity.Image")));
            this.btn_DecreaseQuantity.Location = new System.Drawing.Point(0, 0);
            this.btn_DecreaseQuantity.Name = "btn_DecreaseQuantity";
            this.btn_DecreaseQuantity.Size = new System.Drawing.Size(29, 29);
            this.btn_DecreaseQuantity.TabIndex = 1;
            this.btn_DecreaseQuantity.Click += new System.EventHandler(this.btn_DecreaseQuantity_Click);
            // 
            // btn_IncreaseQuantity
            // 
            this.btn_IncreaseQuantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_IncreaseQuantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_IncreaseQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_IncreaseQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_IncreaseQuantity.FillColor = System.Drawing.Color.Empty;
            this.btn_IncreaseQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_IncreaseQuantity.ForeColor = System.Drawing.Color.White;
            this.btn_IncreaseQuantity.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btn_IncreaseQuantity.Image = ((System.Drawing.Image)(resources.GetObject("btn_IncreaseQuantity.Image")));
            this.btn_IncreaseQuantity.Location = new System.Drawing.Point(81, 0);
            this.btn_IncreaseQuantity.Name = "btn_IncreaseQuantity";
            this.btn_IncreaseQuantity.Size = new System.Drawing.Size(29, 29);
            this.btn_IncreaseQuantity.TabIndex = 0;
            this.btn_IncreaseQuantity.Click += new System.EventHandler(this.btn_IncreaseQuantity_Click);
            // 
            // UC_BookOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.lbl_BookPrice);
            this.Controls.Add(this.lbl_BookName);
            this.Controls.Add(this.btn_DeleteBook);
            this.Name = "UC_BookOrderItem";
            this.Size = new System.Drawing.Size(634, 51);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_DeleteBook;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_BookName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_BookPrice;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_IncreaseQuantity;
        private Guna.UI2.WinForms.Guna2Button btn_DecreaseQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_BookQuantity;
    }
}
