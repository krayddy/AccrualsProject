using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccrualsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (textBoxWithLogin.Text != null && textBoxWithLogin.Text != "")
            {
                var formAccruals = new FormAccruals(this);
                formAccruals.Show();
            }
            else
            {
                labelErrorLogin.Visible = true;
            }
        }
        
        public string GetLogin()
        {
            return textBoxWithLogin.Text;
        }
    }
}
