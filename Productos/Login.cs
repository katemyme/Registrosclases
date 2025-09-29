using Productos.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class Login : Form
    {
        UsarioDao users = new UsarioDao();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Logear();
        }
        private void Logear()
        {
            if (users.Validar(tbusuario.Text, tbpassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales invalida",
                    "advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void tbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Logear();
            }
        }

        private void tbusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            tbpassword.Focus();
        }

        private void chkShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkShowPw.Checked)
            {
                tbpassword.PasswordChar = '*';
                chkShowPw.Text = "Mostrar contraseña";

            }
            else
            {
                tbpassword.PasswordChar = '\0';
                chkShowPw.Text = "Ocultar Contraseña";
            }
        }
    }
}
