namespace BookStore.UserControls
{
    partial class UC_Author
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
            this.Panel_BookDesc = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SuspendLayout();
            // 
            // Panel_BookDesc
            // 
            this.Panel_BookDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_BookDesc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.Panel_BookDesc.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.Panel_BookDesc.Location = new System.Drawing.Point(828, 0);
            this.Panel_BookDesc.Name = "Panel_BookDesc";
            this.Panel_BookDesc.Size = new System.Drawing.Size(394, 578);
            this.Panel_BookDesc.TabIndex = 3;
            // 
            // UC_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_BookDesc);
            this.Name = "UC_Author";
            this.Size = new System.Drawing.Size(1222, 578);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel_BookDesc;
    }
}
