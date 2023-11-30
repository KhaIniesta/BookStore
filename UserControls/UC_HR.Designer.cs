namespace BookStore.UserControls
{
    partial class UC_HR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HR));
            this.Panel_Dg = new Guna.UI2.WinForms.Guna2Panel();
            this.DG_AccountDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel_Picture = new Guna.UI2.WinForms.Guna2Panel();
            this.Picturebox_ProfilePic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.CB_Position = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_UpdateBook = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_ResetTxt = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_DeleteBook = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_ChoosePic = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Newbook = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_Dg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_AccountDetail)).BeginInit();
            this.Panel_Picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_ProfilePic)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Dg
            // 
            this.Panel_Dg.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Dg.BorderRadius = 12;
            this.Panel_Dg.Controls.Add(this.DG_AccountDetail);
            this.Panel_Dg.FillColor = System.Drawing.Color.White;
            this.Panel_Dg.Location = new System.Drawing.Point(28, 351);
            this.Panel_Dg.Name = "Panel_Dg";
            this.Panel_Dg.Size = new System.Drawing.Size(1166, 203);
            this.Panel_Dg.TabIndex = 8;
            // 
            // DG_AccountDetail
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.DG_AccountDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_AccountDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DG_AccountDetail.ColumnHeadersHeight = 20;
            this.DG_AccountDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_AccountDetail.DefaultCellStyle = dataGridViewCellStyle15;
            this.DG_AccountDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DG_AccountDetail.Location = new System.Drawing.Point(128, 3);
            this.DG_AccountDetail.Name = "DG_AccountDetail";
            this.DG_AccountDetail.RowHeadersVisible = false;
            this.DG_AccountDetail.RowHeadersWidth = 51;
            this.DG_AccountDetail.RowTemplate.Height = 24;
            this.DG_AccountDetail.Size = new System.Drawing.Size(911, 230);
            this.DG_AccountDetail.TabIndex = 1;
            this.DG_AccountDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DG_AccountDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DG_AccountDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DG_AccountDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DG_AccountDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DG_AccountDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DG_AccountDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DG_AccountDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DG_AccountDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_AccountDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG_AccountDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DG_AccountDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DG_AccountDetail.ThemeStyle.HeaderStyle.Height = 20;
            this.DG_AccountDetail.ThemeStyle.ReadOnly = false;
            this.DG_AccountDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DG_AccountDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DG_AccountDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG_AccountDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DG_AccountDetail.ThemeStyle.RowsStyle.Height = 24;
            this.DG_AccountDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DG_AccountDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Panel_Picture
            // 
            this.Panel_Picture.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Picture.BorderRadius = 12;
            this.Panel_Picture.Controls.Add(this.Btn_ChoosePic);
            this.Panel_Picture.Controls.Add(this.Picturebox_ProfilePic);
            this.Panel_Picture.FillColor = System.Drawing.Color.Gainsboro;
            this.Panel_Picture.Location = new System.Drawing.Point(789, 25);
            this.Panel_Picture.Name = "Panel_Picture";
            this.Panel_Picture.Size = new System.Drawing.Size(405, 267);
            this.Panel_Picture.TabIndex = 10;
            // 
            // Picturebox_ProfilePic
            // 
            this.Picturebox_ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("Picturebox_ProfilePic.Image")));
            this.Picturebox_ProfilePic.ImageRotate = 0F;
            this.Picturebox_ProfilePic.Location = new System.Drawing.Point(60, 9);
            this.Picturebox_ProfilePic.Name = "Picturebox_ProfilePic";
            this.Picturebox_ProfilePic.Size = new System.Drawing.Size(297, 221);
            this.Picturebox_ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picturebox_ProfilePic.TabIndex = 0;
            this.Picturebox_ProfilePic.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 12;
            this.guna2CustomGradientPanel1.Controls.Add(this.CB_Position);
            this.guna2CustomGradientPanel1.Controls.Add(this.Txt_Name);
            this.guna2CustomGradientPanel1.Controls.Add(this.Txt_Password);
            this.guna2CustomGradientPanel1.Controls.Add(this.Txt_Username);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(204)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(28, 25);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(738, 267);
            this.guna2CustomGradientPanel1.TabIndex = 11;
            // 
            // CB_Position
            // 
            this.CB_Position.AutoRoundedCorners = true;
            this.CB_Position.BackColor = System.Drawing.Color.Transparent;
            this.CB_Position.BorderRadius = 17;
            this.CB_Position.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Position.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_Position.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_Position.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_Position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CB_Position.ItemHeight = 30;
            this.CB_Position.Location = new System.Drawing.Point(231, 194);
            this.CB_Position.Name = "CB_Position";
            this.CB_Position.Size = new System.Drawing.Size(433, 36);
            this.CB_Position.TabIndex = 10;
            // 
            // Txt_Name
            // 
            this.Txt_Name.AutoRoundedCorners = true;
            this.Txt_Name.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Name.BorderRadius = 19;
            this.Txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Name.DefaultText = "";
            this.Txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Name.Location = new System.Drawing.Point(231, 139);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.PasswordChar = '\0';
            this.Txt_Name.PlaceholderText = "";
            this.Txt_Name.SelectedText = "";
            this.Txt_Name.Size = new System.Drawing.Size(433, 40);
            this.Txt_Name.TabIndex = 7;
            // 
            // Txt_Password
            // 
            this.Txt_Password.AutoRoundedCorners = true;
            this.Txt_Password.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Password.BorderRadius = 19;
            this.Txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Password.DefaultText = "";
            this.Txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Password.Location = new System.Drawing.Point(231, 86);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '\0';
            this.Txt_Password.PlaceholderText = "";
            this.Txt_Password.SelectedText = "";
            this.Txt_Password.Size = new System.Drawing.Size(433, 40);
            this.Txt_Password.TabIndex = 8;
            // 
            // Txt_Username
            // 
            this.Txt_Username.AutoRoundedCorners = true;
            this.Txt_Username.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Username.BorderRadius = 19;
            this.Txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Username.DefaultText = "";
            this.Txt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Username.Location = new System.Drawing.Point(231, 34);
            this.Txt_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.PasswordChar = '\0';
            this.Txt_Username.PlaceholderText = "";
            this.Txt_Username.SelectedText = "";
            this.Txt_Username.Size = new System.Drawing.Size(433, 40);
            this.Txt_Username.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(64, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(64, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // Btn_UpdateBook
            // 
            this.Btn_UpdateBook.BackColor = System.Drawing.Color.Transparent;
            this.Btn_UpdateBook.BorderColor = System.Drawing.Color.Empty;
            this.Btn_UpdateBook.BorderRadius = 10;
            this.Btn_UpdateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_UpdateBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_UpdateBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_UpdateBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_UpdateBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_UpdateBook.Enabled = false;
            this.Btn_UpdateBook.FocusedColor = System.Drawing.Color.Transparent;
            this.Btn_UpdateBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_UpdateBook.ForeColor = System.Drawing.Color.Black;
            this.Btn_UpdateBook.Image = ((System.Drawing.Image)(resources.GetObject("Btn_UpdateBook.Image")));
            this.Btn_UpdateBook.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_UpdateBook.Location = new System.Drawing.Point(309, 298);
            this.Btn_UpdateBook.Name = "Btn_UpdateBook";
            this.Btn_UpdateBook.PressedColor = System.Drawing.Color.White;
            this.Btn_UpdateBook.Size = new System.Drawing.Size(45, 45);
            this.Btn_UpdateBook.TabIndex = 17;
            // 
            // Btn_ResetTxt
            // 
            this.Btn_ResetTxt.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ResetTxt.BorderRadius = 10;
            this.Btn_ResetTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ResetTxt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_ResetTxt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_ResetTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_ResetTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_ResetTxt.Enabled = false;
            this.Btn_ResetTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_ResetTxt.ForeColor = System.Drawing.Color.White;
            this.Btn_ResetTxt.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ResetTxt.Image")));
            this.Btn_ResetTxt.ImageSize = new System.Drawing.Size(18, 18);
            this.Btn_ResetTxt.Location = new System.Drawing.Point(516, 298);
            this.Btn_ResetTxt.Name = "Btn_ResetTxt";
            this.Btn_ResetTxt.Size = new System.Drawing.Size(45, 45);
            this.Btn_ResetTxt.TabIndex = 16;
            // 
            // Btn_DeleteBook
            // 
            this.Btn_DeleteBook.BackColor = System.Drawing.Color.Transparent;
            this.Btn_DeleteBook.BorderRadius = 10;
            this.Btn_DeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DeleteBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_DeleteBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_DeleteBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_DeleteBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_DeleteBook.Enabled = false;
            this.Btn_DeleteBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_DeleteBook.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DeleteBook.Image")));
            this.Btn_DeleteBook.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_DeleteBook.Location = new System.Drawing.Point(420, 298);
            this.Btn_DeleteBook.Name = "Btn_DeleteBook";
            this.Btn_DeleteBook.Size = new System.Drawing.Size(45, 45);
            this.Btn_DeleteBook.TabIndex = 15;
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Save.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Save.BorderRadius = 15;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Save.FocusedColor = System.Drawing.Color.Transparent;
            this.Btn_Save.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Location = new System.Drawing.Point(597, 305);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.PressedColor = System.Drawing.Color.Transparent;
            this.Btn_Save.Size = new System.Drawing.Size(169, 35);
            this.Btn_Save.TabIndex = 46;
            this.Btn_Save.Text = "Save";
            // 
            // Btn_ChoosePic
            // 
            this.Btn_ChoosePic.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ChoosePic.BorderRadius = 12;
            this.Btn_ChoosePic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_ChoosePic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_ChoosePic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_ChoosePic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_ChoosePic.FillColor = System.Drawing.Color.White;
            this.Btn_ChoosePic.FocusedColor = System.Drawing.Color.Transparent;
            this.Btn_ChoosePic.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChoosePic.ForeColor = System.Drawing.Color.Black;
            this.Btn_ChoosePic.Location = new System.Drawing.Point(124, 236);
            this.Btn_ChoosePic.Name = "Btn_ChoosePic";
            this.Btn_ChoosePic.Size = new System.Drawing.Size(180, 28);
            this.Btn_ChoosePic.TabIndex = 18;
            this.Btn_ChoosePic.Text = "Choose Picture";
            // 
            // Btn_Newbook
            // 
            this.Btn_Newbook.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Newbook.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Newbook.BorderRadius = 15;
            this.Btn_Newbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Newbook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Newbook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Newbook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Newbook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Newbook.FocusedColor = System.Drawing.Color.Transparent;
            this.Btn_Newbook.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Newbook.ForeColor = System.Drawing.Color.White;
            this.Btn_Newbook.Location = new System.Drawing.Point(96, 300);
            this.Btn_Newbook.Name = "Btn_Newbook";
            this.Btn_Newbook.PressedColor = System.Drawing.Color.Transparent;
            this.Btn_Newbook.Size = new System.Drawing.Size(137, 35);
            this.Btn_Newbook.TabIndex = 47;
            this.Btn_Newbook.Text = "New Book ";
            // 
            // UC_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Newbook);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_UpdateBook);
            this.Controls.Add(this.Btn_ResetTxt);
            this.Controls.Add(this.Btn_DeleteBook);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.Panel_Dg);
            this.Controls.Add(this.Panel_Picture);
            this.Name = "UC_HR";
            this.Size = new System.Drawing.Size(1222, 578);
            this.Panel_Dg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_AccountDetail)).EndInit();
            this.Panel_Picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_ProfilePic)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel_Dg;
        private Guna.UI2.WinForms.Guna2Panel Panel_Picture;
        private Guna.UI2.WinForms.Guna2DataGridView DG_AccountDetail;
        private Guna.UI2.WinForms.Guna2PictureBox Picturebox_ProfilePic;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox CB_Position;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Name;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Password;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Btn_UpdateBook;
        private Guna.UI2.WinForms.Guna2Button Btn_ResetTxt;
        private Guna.UI2.WinForms.Guna2Button Btn_DeleteBook;
        private Guna.UI2.WinForms.Guna2Button Btn_Save;
        private Guna.UI2.WinForms.Guna2Button Btn_ChoosePic;
        private Guna.UI2.WinForms.Guna2Button Btn_Newbook;
    }
}
