namespace BookStore.UserControls
{
    partial class UC_BookItem
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
            this.lb_name = new System.Windows.Forms.Label();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.Pb_Image = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoEllipsis = true;
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(28, 170);
            this.lb_name.MaximumSize = new System.Drawing.Size(142, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(142, 19);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Lorem ipsum dolor";
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cost.Location = new System.Drawing.Point(18, 230);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(52, 16);
            this.lbl_Cost.TabIndex = 1;
            this.lbl_Cost.Text = "Price :";
            this.lbl_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(74, 230);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(96, 16);
            this.lbl_price.TabIndex = 1;
            this.lbl_price.Text = "100.000.000";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Empty;
            this.guna2Shapes1.BorderThickness = 0;
            this.guna2Shapes1.FillColor = System.Drawing.Color.White;
            this.guna2Shapes1.Location = new System.Drawing.Point(143, 0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.RoundedRadius = 10;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(46, 44);
            this.guna2Shapes1.TabIndex = 2;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 80;
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.BackColor = System.Drawing.Color.White;
            this.lb_quantity.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantity.Location = new System.Drawing.Point(150, 14);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(29, 16);
            this.lb_quantity.TabIndex = 3;
            this.lb_quantity.Text = "100";
            // 
            // Pb_Image
            // 
            this.Pb_Image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pb_Image.BorderRadius = 10;
            this.Pb_Image.Image = global::BookStore.Properties.Resources.background_login;
            this.Pb_Image.ImageRotate = 0F;
            this.Pb_Image.Location = new System.Drawing.Point(27, 14);
            this.Pb_Image.Name = "Pb_Image";
            this.Pb_Image.Size = new System.Drawing.Size(143, 143);
            this.Pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Image.TabIndex = 0;
            this.Pb_Image.TabStop = false;
            // 
            // UC_BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_Cost);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.Pb_Image);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "UC_BookItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(197, 260);
            this.Click += new System.EventHandler(this.UC_BookItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_quantity;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lb_name;
        private Guna.UI2.WinForms.Guna2PictureBox Pb_Image;
    }
}
