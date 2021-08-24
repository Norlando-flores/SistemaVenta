using System;
using SisVentaDevExpress.Ventas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentaDevExpress.Formularios
{
    public partial class frm_acceso : Form
    {
        Trabajador trabajador = null;
        public frm_acceso()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private void cbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarContraseña.Checked == true)
            {
                if (this.txtContraseña.PasswordChar == '*')
                {
                    this.txtContraseña.PasswordChar = '\0';
                }
            }
            else
            {
                this.txtContraseña.PasswordChar = '*';
            }
        }

        private void frm_acceso_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //txtUsuario.Text = trabajador.Usuario;
            MessageBox.Show("jola");
        }
    }
}
