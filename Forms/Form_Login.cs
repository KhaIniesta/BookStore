using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms
{
    public partial class Form_Login : Form
    {
        private DatabaseConnection DBConnection = new DatabaseConnection();
        private String StateControl = "none";
        public Form_Login()
        {
            InitializeComponent();
        }
    }
}
