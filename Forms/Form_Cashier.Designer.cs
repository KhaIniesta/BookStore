namespace BookStore.Forms
{
    partial class Form_Cashier
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cashier));
            this.Panel_Header = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Txt_Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel_BookDesc = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.Controls.Add(this.Txt_Searchbox);
            this.Panel_Header.Controls.Add(this.guna2Panel1);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Panel_Header.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Panel_Header.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Panel_Header.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1422, 95);
            this.Panel_Header.TabIndex = 1;
            // 
            // Txt_Searchbox
            // 
            this.Txt_Searchbox.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Searchbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Txt_Searchbox.BorderRadius = 12;
            this.Txt_Searchbox.BorderThickness = 2;
            this.Txt_Searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Searchbox.DefaultText = "";
            this.Txt_Searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Searchbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Txt_Searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Searchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_Searchbox.ForeColor = System.Drawing.Color.White;
            this.Txt_Searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Searchbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Txt_Searchbox.IconLeft")));
            this.Txt_Searchbox.IconLeftOffset = new System.Drawing.Point(12, 0);
            this.Txt_Searchbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_Searchbox.Location = new System.Drawing.Point(501, 25);
            this.Txt_Searchbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Searchbox.Name = "Txt_Searchbox";
            this.Txt_Searchbox.PasswordChar = '\0';
            this.Txt_Searchbox.PlaceholderText = "Search";
            this.Txt_Searchbox.SelectedText = "";
            this.Txt_Searchbox.Size = new System.Drawing.Size(472, 48);
            this.Txt_Searchbox.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.Location = new System.Drawing.Point(21, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(161, 89);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Panel_BookDesc
            // 
            this.Panel_BookDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_BookDesc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Panel_BookDesc.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Panel_BookDesc.Location = new System.Drawing.Point(1028, 95);
            this.Panel_BookDesc.Name = "Panel_BookDesc";
            this.Panel_BookDesc.Size = new System.Drawing.Size(394, 578);
            this.Panel_BookDesc.TabIndex = 2;
            // 
            // Form_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 673);
            this.Controls.Add(this.Panel_BookDesc);
            this.Controls.Add(this.Panel_Header);
            this.Name = "Form_Cashier";
            this.Text = "Cashier Form";
            this.Panel_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel_Header;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Searchbox;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel_BookDesc;
    }
}