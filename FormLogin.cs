using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_DivisorTensao
{
    public partial class FormLogin : Form
    {
        string usuario1 = "Julio", senha1 = "12345";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txbUsuario.Text == usuario1 && txbSenha.Text == senha1)
            {
                FormDivisorTensao obj_divisor = new FormDivisorTensao();
                obj_divisor.ShowDialog();
                txbUsuario.Text = string.Empty;
                txbUsuario.Text = string.Empty;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario/senha incorreta.");
                txbUsuario.Text = string.Empty;
                txbUsuario.Text = string.Empty;
            }
        }
    }
}
