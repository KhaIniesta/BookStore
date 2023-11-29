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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HR));
            this.Panel_Dg = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel_Picture = new Guna.UI2.WinForms.Guna2Panel();
            this.DG_AccountDetail = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.Panel_Dg.SuspendLayout();
            this.Panel_Picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_AccountDetail)).BeginInit();
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
            this.Panel_Dg.Location = new System.Drawing.Point(28, 318);
            this.Panel_Dg.Name = "Panel_Dg";
            this.Panel_Dg.Size = new System.Drawing.Size(1166, 236);
            this.Panel_Dg.TabIndex = 8;
            // 
            // Panel_Picture
            // 
            this.Panel_Picture.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Picture.BorderRadius = 12;
            this.Panel_Picture.Controls.Add(this.Picturebox_ProfilePic);
            this.Panel_Picture.FillColor = System.Drawing.Color.White;
            this.Panel_Picture.Location = new System.Drawing.Point(789, 25);
            this.Panel_Picture.Name = "Panel_Picture";
            this.Panel_Picture.Size = new System.Drawing.Size(405, 267);
            this.Panel_Picture.TabIndex = 10;
            // 
            // DG_AccountDetail
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.DG_AccountDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_AccountDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.DG_AccountDetail.ColumnHeadersHeight = 20;
            this.DG_AccountDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_AccountDetail.DefaultCellStyle = dataGridViewCellStyle21;
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
            // Picturebox_ProfilePic
            // 
            this.Picturebox_ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("Picturebox_ProfilePic.Image")));
            this.Picturebox_ProfilePic.ImageRotate = 0F;
            this.Picturebox_ProfilePic.Location = new System.Drawing.Point(56, 19);
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
            this.label4.Size = new System.Drawing.Size(93, 24);
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
            this.label3.Size = new System.Drawing.Size(72, 24);
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
            this.label2.Size = new System.Drawing.Size(112, 24);
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
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // UC_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.Panel_Dg);
            this.Controls.Add(this.Panel_Picture);
            this.Name = "UC_HR";
            this.Size = new System.Drawing.Size(1222, 578);
            this.Panel_Dg.ResumeLayout(false);
            this.Panel_Picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_AccountDetail)).EndInit();
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
    }
}
