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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HR));
            this.Panel_Dg = new Guna.UI2.WinForms.Guna2Panel();
            this.DG_AccountDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel_Picture = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_ChoosePic = new Guna.UI2.WinForms.Guna2Button();
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
            this.btn_update_account = new Guna.UI2.WinForms.Guna2Button();
            this.btn_canncel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete_account = new Guna.UI2.WinForms.Guna2Button();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_new_account = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DG_AccountDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_AccountDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_AccountDetail.ColumnHeadersHeight = 20;
            this.DG_AccountDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_AccountDetail.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.DG_AccountDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_AccountDetail_CellClick);
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
            this.Btn_ChoosePic.Click += new System.EventHandler(this.Btn_ChoosePic_Click);
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
            this.CB_Position.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên thu ngân",
            "Quản lí kho"});
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
            // btn_update_account
            // 
            this.btn_update_account.BackColor = System.Drawing.Color.Transparent;
            this.btn_update_account.BorderColor = System.Drawing.Color.Empty;
            this.btn_update_account.BorderRadius = 10;
            this.btn_update_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_account.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_update_account.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_update_account.ForeColor = System.Drawing.Color.Black;
            this.btn_update_account.Image = ((System.Drawing.Image)(resources.GetObject("btn_update_account.Image")));
            this.btn_update_account.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_update_account.Location = new System.Drawing.Point(309, 298);
            this.btn_update_account.Name = "btn_update_account";
            this.btn_update_account.PressedColor = System.Drawing.Color.White;
            this.btn_update_account.Size = new System.Drawing.Size(45, 45);
            this.btn_update_account.TabIndex = 17;
            this.btn_update_account.Click += new System.EventHandler(this.btn_update_account_Click);
            // 
            // btn_canncel
            // 
            this.btn_canncel.BackColor = System.Drawing.Color.Transparent;
            this.btn_canncel.BorderRadius = 10;
            this.btn_canncel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_canncel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_canncel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_canncel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_canncel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_canncel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_canncel.ForeColor = System.Drawing.Color.White;
            this.btn_canncel.Image = ((System.Drawing.Image)(resources.GetObject("btn_canncel.Image")));
            this.btn_canncel.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_canncel.Location = new System.Drawing.Point(516, 298);
            this.btn_canncel.Name = "btn_canncel";
            this.btn_canncel.Size = new System.Drawing.Size(45, 45);
            this.btn_canncel.TabIndex = 16;
            this.btn_canncel.Click += new System.EventHandler(this.btn_canncel_Click);
            // 
            // btn_delete_account
            // 
            this.btn_delete_account.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_account.BorderRadius = 10;
            this.btn_delete_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_account.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete_account.ForeColor = System.Drawing.Color.White;
            this.btn_delete_account.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_account.Image")));
            this.btn_delete_account.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_delete_account.Location = new System.Drawing.Point(420, 298);
            this.btn_delete_account.Name = "btn_delete_account";
            this.btn_delete_account.Size = new System.Drawing.Size(45, 45);
            this.btn_delete_account.TabIndex = 15;
            this.btn_delete_account.Click += new System.EventHandler(this.btn_delete_account_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderRadius = 15;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_save.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(597, 305);
            this.btn_save.Name = "btn_save";
            this.btn_save.PressedColor = System.Drawing.Color.Transparent;
            this.btn_save.Size = new System.Drawing.Size(169, 35);
            this.btn_save.TabIndex = 46;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new_account
            // 
            this.btn_new_account.BackColor = System.Drawing.Color.Transparent;
            this.btn_new_account.BorderColor = System.Drawing.Color.Transparent;
            this.btn_new_account.BorderRadius = 15;
            this.btn_new_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_new_account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_new_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_new_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_new_account.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_new_account.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_account.ForeColor = System.Drawing.Color.White;
            this.btn_new_account.Location = new System.Drawing.Point(96, 300);
            this.btn_new_account.Name = "btn_new_account";
            this.btn_new_account.PressedColor = System.Drawing.Color.Transparent;
            this.btn_new_account.Size = new System.Drawing.Size(150, 35);
            this.btn_new_account.TabIndex = 47;
            this.btn_new_account.Text = "New Account";
            this.btn_new_account.Click += new System.EventHandler(this.btn_new_account_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UC_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_new_account);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_update_account);
            this.Controls.Add(this.btn_canncel);
            this.Controls.Add(this.btn_delete_account);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.Panel_Dg);
            this.Controls.Add(this.Panel_Picture);
            this.Name = "UC_HR";
            this.Size = new System.Drawing.Size(1222, 578);
            this.Load += new System.EventHandler(this.UC_HR_Load);
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
        private Guna.UI2.WinForms.Guna2Button btn_update_account;
        private Guna.UI2.WinForms.Guna2Button btn_canncel;
        private Guna.UI2.WinForms.Guna2Button btn_delete_account;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button Btn_ChoosePic;
        private Guna.UI2.WinForms.Guna2Button btn_new_account;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
