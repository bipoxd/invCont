using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace invStore
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string usr = txt_usr.Text;
            string pass = txt_pass.Text;
            if (usr == "root" && pass == "root")
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("CREDENCIALES INCORRECTAS!");
                txt_usr.Text = "";
                txt_pass.Text = "";
            }

        }
    }
}
