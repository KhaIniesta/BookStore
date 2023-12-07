namespace BookStore.UserControls
{
    partial class UC_ReceipDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ReceipDetail));
            this.pn_bookItems = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_bookItems = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbl_ReceiptID = new System.Windows.Forms.Label();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_Sale = new System.Windows.Forms.Label();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_ChangeMoney = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DeleteReceipt = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txt_ReceivedMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_printReceipt = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_bookItems
            // 
            this.pn_bookItems.AutoScroll = true;
            this.pn_bookItems.BackColor = System.Drawing.Color.White;
            this.pn_bookItems.Location = new System.Drawing.Point(20, 18);
            this.pn_bookItems.Name = "pn_bookItems";
            this.pn_bookItems.Size = new System.Drawing.Size(701, 567);
            this.pn_bookItems.TabIndex = 3;
            // 
            // flp_bookItems
            // 
            this.flp_bookItems.AutoScroll = true;
            this.flp_bookItems.BackColor = System.Drawing.Color.White;
            this.flp_bookItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_bookItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_bookItems.Location = new System.Drawing.Point(753, 105);
            this.flp_bookItems.Name = "flp_bookItems";
            this.flp_bookItems.Size = new System.Drawing.Size(656, 265);
            this.flp_bookItems.TabIndex = 1;
            this.flp_bookItems.WrapContents = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.lbl_ReceiptID);
            this.guna2GradientPanel1.Controls.Add(this.lbl_datetime);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.CustomizableEdges.BottomLeft = false;
            this.guna2GradientPanel1.CustomizableEdges.BottomRight = false;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(753, 18);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(656, 81);
            this.guna2GradientPanel1.TabIndex = 6;
            // 
            // lbl_ReceiptID
            // 
            this.lbl_ReceiptID.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReceiptID.ForeColor = System.Drawing.Color.White;
            this.lbl_ReceiptID.Location = new System.Drawing.Point(348, 50);
            this.lbl_ReceiptID.Name = "lbl_ReceiptID";
            this.lbl_ReceiptID.Size = new System.Drawing.Size(293, 20);
            this.lbl_ReceiptID.TabIndex = 1;
            this.lbl_ReceiptID.Text = "HD01";
            this.lbl_ReceiptID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datetime.ForeColor = System.Drawing.Color.White;
            this.lbl_datetime.Location = new System.Drawing.Point(32, 50);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(369, 20);
            this.lbl_datetime.TabIndex = 1;
            this.lbl_datetime.Text = "29/11/2023 11:48:40";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "New order";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientPanel2.BorderRadius = 15;
            this.guna2GradientPanel2.Controls.Add(this.label11);
            this.guna2GradientPanel2.Controls.Add(this.label20);
            this.guna2GradientPanel2.Controls.Add(this.lbl_Sale);
            this.guna2GradientPanel2.Controls.Add(this.lbl_Subtotal);
            this.guna2GradientPanel2.Controls.Add(this.lbl_ChangeMoney);
            this.guna2GradientPanel2.Controls.Add(this.lbl_Total);
            this.guna2GradientPanel2.Controls.Add(this.label5);
            this.guna2GradientPanel2.Controls.Add(this.label4);
            this.guna2GradientPanel2.Controls.Add(this.label3);
            this.guna2GradientPanel2.Controls.Add(this.btn_DeleteReceipt);
            this.guna2GradientPanel2.Controls.Add(this.txt_ReceivedMoney);
            this.guna2GradientPanel2.Controls.Add(this.btn_printReceipt);
            this.guna2GradientPanel2.CustomizableEdges.TopLeft = false;
            this.guna2GradientPanel2.CustomizableEdges.TopRight = false;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(753, 387);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(656, 200);
            this.guna2GradientPanel2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(422, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Sale : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(420, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "Subtotal : ";
            // 
            // lbl_Sale
            // 
            this.lbl_Sale.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sale.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Sale.Location = new System.Drawing.Point(569, 64);
            this.lbl_Sale.Name = "lbl_Sale";
            this.lbl_Sale.Size = new System.Drawing.Size(72, 20);
            this.lbl_Sale.TabIndex = 20;
            this.lbl_Sale.Text = "15%";
            this.lbl_Sale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Subtotal.Location = new System.Drawing.Point(535, 12);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(106, 24);
            this.lbl_Subtotal.TabIndex = 19;
            this.lbl_Subtotal.Text = "0";
            this.lbl_Subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ChangeMoney
            // 
            this.lbl_ChangeMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ChangeMoney.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChangeMoney.Location = new System.Drawing.Point(242, 101);
            this.lbl_ChangeMoney.Name = "lbl_ChangeMoney";
            this.lbl_ChangeMoney.Size = new System.Drawing.Size(143, 28);
            this.lbl_ChangeMoney.TabIndex = 18;
            this.lbl_ChangeMoney.Text = "0";
            this.lbl_ChangeMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Total
            // 
            this.lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Total.Location = new System.Drawing.Point(242, 14);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(140, 28);
            this.lbl_Total.TabIndex = 17;
            this.lbl_Total.Text = "0";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Change : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Received : ";
            // 
            // btn_DeleteReceipt
            // 
            this.btn_DeleteReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteReceipt.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_DeleteReceipt.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_DeleteReceipt.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_DeleteReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteReceipt.Image")));
            this.btn_DeleteReceipt.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_DeleteReceipt.ImageRotate = 0F;
            this.btn_DeleteReceipt.Location = new System.Drawing.Point(25, 148);
            this.btn_DeleteReceipt.Name = "btn_DeleteReceipt";
            this.btn_DeleteReceipt.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_DeleteReceipt.Size = new System.Drawing.Size(30, 30);
            this.btn_DeleteReceipt.TabIndex = 13;
            this.btn_DeleteReceipt.Click += new System.EventHandler(this.btn_DeleteReceipt_Click);
            // 
            // txt_ReceivedMoney
            // 
            this.txt_ReceivedMoney.BackColor = System.Drawing.Color.Transparent;
            this.txt_ReceivedMoney.BorderRadius = 8;
            this.txt_ReceivedMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ReceivedMoney.DefaultText = "";
            this.txt_ReceivedMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ReceivedMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ReceivedMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ReceivedMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ReceivedMoney.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ReceivedMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ReceivedMoney.Font = new System.Drawing.Font("Inter Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReceivedMoney.ForeColor = System.Drawing.Color.Black;
            this.txt_ReceivedMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ReceivedMoney.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_ReceivedMoney.IconLeft")));
            this.txt_ReceivedMoney.Location = new System.Drawing.Point(208, 53);
            this.txt_ReceivedMoney.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_ReceivedMoney.Name = "txt_ReceivedMoney";
            this.txt_ReceivedMoney.PasswordChar = '\0';
            this.txt_ReceivedMoney.PlaceholderText = "";
            this.txt_ReceivedMoney.SelectedText = "";
            this.txt_ReceivedMoney.Size = new System.Drawing.Size(164, 36);
            this.txt_ReceivedMoney.TabIndex = 8;
            this.txt_ReceivedMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ReceivedMoney_KeyDown);
            // 
            // btn_printReceipt
            // 
            this.btn_printReceipt.Animated = true;
            this.btn_printReceipt.AutoRoundedCorners = true;
            this.btn_printReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btn_printReceipt.BorderRadius = 17;
            this.btn_printReceipt.DefaultAutoSize = true;
            this.btn_printReceipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_printReceipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_printReceipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_printReceipt.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_printReceipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_printReceipt.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_printReceipt.ForeColor = System.Drawing.Color.White;
            this.btn_printReceipt.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_printReceipt.Location = new System.Drawing.Point(460, 145);
            this.btn_printReceipt.Name = "btn_printReceipt";
            this.btn_printReceipt.Size = new System.Drawing.Size(173, 36);
            this.btn_printReceipt.TabIndex = 3;
            this.btn_printReceipt.Text = "Export receipt";
            this.btn_printReceipt.Click += new System.EventHandler(this.btn_printReceipt_Click);
            // 
            // UC_ReceipDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.pn_bookItems);
            this.Controls.Add(this.flp_bookItems);
            this.Name = "UC_ReceipDetail";
            this.Size = new System.Drawing.Size(1440, 625);
            this.Load += new System.EventHandler(this.UC_ReceipDetail_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pn_bookItems;
        private System.Windows.Forms.FlowLayoutPanel flp_bookItems;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_printReceipt;
        private Guna.UI2.WinForms.Guna2TextBox txt_ReceivedMoney;
        private Guna.UI2.WinForms.Guna2ImageButton btn_DeleteReceipt;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_Sale;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl_ChangeMoney;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ReceiptID;
    }
}
