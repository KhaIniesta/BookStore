namespace BookStore.UserControls
{
    partial class UC_aPublisher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_aPublisher));
            this.dtg_nxb = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_maNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_BookDesc = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txt_maNXB = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_themPu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_lienHe = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nxb)).BeginInit();
            this.Panel_BookDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_nxb
            // 
            this.dtg_nxb.AllowUserToResizeColumns = false;
            this.dtg_nxb.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtg_nxb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_nxb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_nxb.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_nxb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_nxb.ColumnHeadersHeight = 35;
            this.dtg_nxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg_nxb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maNXB,
            this.col_tenNXB,
            this.col_diaChi,
            this.col_lienHe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_nxb.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_nxb.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtg_nxb.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_nxb.Location = new System.Drawing.Point(0, 0);
            this.dtg_nxb.Margin = new System.Windows.Forms.Padding(6);
            this.dtg_nxb.Name = "dtg_nxb";
            this.dtg_nxb.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_nxb.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_nxb.RowHeadersVisible = false;
            this.dtg_nxb.RowHeadersWidth = 51;
            this.dtg_nxb.RowTemplate.Height = 24;
            this.dtg_nxb.Size = new System.Drawing.Size(828, 578);
            this.dtg_nxb.TabIndex = 10;
            this.dtg_nxb.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_nxb.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg_nxb.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg_nxb.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg_nxb.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg_nxb.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtg_nxb.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_nxb.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_nxb.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_nxb.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_nxb.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_nxb.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg_nxb.ThemeStyle.HeaderStyle.Height = 35;
            this.dtg_nxb.ThemeStyle.ReadOnly = true;
            this.dtg_nxb.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_nxb.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_nxb.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_nxb.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_nxb.ThemeStyle.RowsStyle.Height = 24;
            this.dtg_nxb.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_nxb.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_nxb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_nxb_CellClick);
            // 
            // col_maNXB
            // 
            this.col_maNXB.DataPropertyName = "MaNXB";
            this.col_maNXB.HeaderText = "Publisher ID";
            this.col_maNXB.MinimumWidth = 6;
            this.col_maNXB.Name = "col_maNXB";
            this.col_maNXB.ReadOnly = true;
            // 
            // col_tenNXB
            // 
            this.col_tenNXB.DataPropertyName = "TenNXB";
            this.col_tenNXB.HeaderText = "Name";
            this.col_tenNXB.MinimumWidth = 6;
            this.col_tenNXB.Name = "col_tenNXB";
            this.col_tenNXB.ReadOnly = true;
            // 
            // col_diaChi
            // 
            this.col_diaChi.DataPropertyName = "DiaChiNXB";
            this.col_diaChi.HeaderText = "Address";
            this.col_diaChi.MinimumWidth = 6;
            this.col_diaChi.Name = "col_diaChi";
            this.col_diaChi.ReadOnly = true;
            // 
            // col_lienHe
            // 
            this.col_lienHe.DataPropertyName = "LienHe";
            this.col_lienHe.HeaderText = "Contact";
            this.col_lienHe.MinimumWidth = 6;
            this.col_lienHe.Name = "col_lienHe";
            this.col_lienHe.ReadOnly = true;
            // 
            // Panel_BookDesc
            // 
            this.Panel_BookDesc.Controls.Add(this.txt_maNXB);
            this.Panel_BookDesc.Controls.Add(this.btn_huy);
            this.Panel_BookDesc.Controls.Add(this.btn_sua);
            this.Panel_BookDesc.Controls.Add(this.btn_luu);
            this.Panel_BookDesc.Controls.Add(this.btn_themPu);
            this.Panel_BookDesc.Controls.Add(this.btn_xoa);
            this.Panel_BookDesc.Controls.Add(this.label1);
            this.Panel_BookDesc.Controls.Add(this.label6);
            this.Panel_BookDesc.Controls.Add(this.txt_name);
            this.Panel_BookDesc.Controls.Add(this.label5);
            this.Panel_BookDesc.Controls.Add(this.txt_diaChi);
            this.Panel_BookDesc.Controls.Add(this.txt_lienHe);
            this.Panel_BookDesc.Controls.Add(this.label3);
            this.Panel_BookDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_BookDesc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Panel_BookDesc.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Panel_BookDesc.Location = new System.Drawing.Point(828, 0);
            this.Panel_BookDesc.Name = "Panel_BookDesc";
            this.Panel_BookDesc.Size = new System.Drawing.Size(394, 578);
            this.Panel_BookDesc.TabIndex = 11;
            // 
            // txt_maNXB
            // 
            this.txt_maNXB.BackColor = System.Drawing.Color.Transparent;
            this.txt_maNXB.BorderRadius = 10;
            this.txt_maNXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maNXB.DefaultText = "";
            this.txt_maNXB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maNXB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maNXB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNXB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNXB.Enabled = false;
            this.txt_maNXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_maNXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNXB.Location = new System.Drawing.Point(163, 120);
            this.txt_maNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maNXB.Name = "txt_maNXB";
            this.txt_maNXB.PasswordChar = '\0';
            this.txt_maNXB.PlaceholderText = "";
            this.txt_maNXB.SelectedText = "";
            this.txt_maNXB.Size = new System.Drawing.Size(211, 36);
            this.txt_maNXB.TabIndex = 50;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_huy.BorderRadius = 10;
            this.btn_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.Image")));
            this.btn_huy.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_huy.Location = new System.Drawing.Point(262, 360);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(45, 45);
            this.btn_huy.TabIndex = 47;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua.BorderColor = System.Drawing.Color.Empty;
            this.btn_sua.BorderRadius = 10;
            this.btn_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sua.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_sua.Location = new System.Drawing.Point(96, 360);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.PressedColor = System.Drawing.Color.White;
            this.btn_sua.Size = new System.Drawing.Size(45, 45);
            this.btn_sua.TabIndex = 48;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Transparent;
            this.btn_luu.BorderColor = System.Drawing.Color.Transparent;
            this.btn_luu.BorderRadius = 15;
            this.btn_luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_luu.Enabled = false;
            this.btn_luu.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_luu.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(213, 463);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.PressedColor = System.Drawing.Color.Transparent;
            this.btn_luu.Size = new System.Drawing.Size(161, 35);
            this.btn_luu.TabIndex = 49;
            this.btn_luu.Text = "Save";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_themPu
            // 
            this.btn_themPu.BackColor = System.Drawing.Color.Transparent;
            this.btn_themPu.BorderColor = System.Drawing.Color.Transparent;
            this.btn_themPu.BorderRadius = 15;
            this.btn_themPu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themPu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themPu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themPu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themPu.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_themPu.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btn_themPu.ForeColor = System.Drawing.Color.White;
            this.btn_themPu.Location = new System.Drawing.Point(24, 463);
            this.btn_themPu.Name = "btn_themPu";
            this.btn_themPu.PressedColor = System.Drawing.Color.Transparent;
            this.btn_themPu.Size = new System.Drawing.Size(171, 35);
            this.btn_themPu.TabIndex = 44;
            this.btn_themPu.Text = "New Publisher";
            this.btn_themPu.Click += new System.EventHandler(this.btn_themPu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.BorderRadius = 10;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_xoa.Location = new System.Drawing.Point(180, 360);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(45, 45);
            this.btn_xoa.TabIndex = 46;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Inter", 11F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Address :";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_name.BorderRadius = 10;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.Enabled = false;
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(96, 49);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(278, 36);
            this.txt_name.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Inter", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(20, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Contact :";
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.BackColor = System.Drawing.Color.Transparent;
            this.txt_diaChi.BorderRadius = 10;
            this.txt_diaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diaChi.DefaultText = "";
            this.txt_diaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_diaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_diaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diaChi.Enabled = false;
            this.txt_diaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_diaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diaChi.Location = new System.Drawing.Point(163, 256);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.PasswordChar = '\0';
            this.txt_diaChi.PlaceholderText = "";
            this.txt_diaChi.SelectedText = "";
            this.txt_diaChi.Size = new System.Drawing.Size(211, 36);
            this.txt_diaChi.TabIndex = 39;
            // 
            // txt_lienHe
            // 
            this.txt_lienHe.BackColor = System.Drawing.Color.Transparent;
            this.txt_lienHe.BorderRadius = 10;
            this.txt_lienHe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lienHe.DefaultText = "";
            this.txt_lienHe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_lienHe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_lienHe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lienHe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lienHe.Enabled = false;
            this.txt_lienHe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lienHe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_lienHe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lienHe.Location = new System.Drawing.Point(163, 188);
            this.txt_lienHe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_lienHe.Name = "txt_lienHe";
            this.txt_lienHe.PasswordChar = '\0';
            this.txt_lienHe.PlaceholderText = "";
            this.txt_lienHe.SelectedText = "";
            this.txt_lienHe.Size = new System.Drawing.Size(211, 36);
            this.txt_lienHe.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Publisher ID :";
            // 
            // UC_aPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_BookDesc);
            this.Controls.Add(this.dtg_nxb);
            this.Name = "UC_aPublisher";
            this.Size = new System.Drawing.Size(1222, 578);
            this.Load += new System.EventHandler(this.UC_aPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nxb)).EndInit();
            this.Panel_BookDesc.ResumeLayout(false);
            this.Panel_BookDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtg_nxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lienHe;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel_BookDesc;
        private Guna.UI2.WinForms.Guna2TextBox txt_maNXB;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private Guna.UI2.WinForms.Guna2Button btn_themPu;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_diaChi;
        private Guna.UI2.WinForms.Guna2TextBox txt_lienHe;
        private System.Windows.Forms.Label label3;
    }
}
