using System;
using SisVentaDevExpress.Clases;
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
        public string usuario= "Vendedor";
        public frm_acceso()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            xpCollectionUsuario.Reload();
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
            foreach (Trabajador u in xpCollectionUsuario)
            {
                DatosDeAcceso.acceso = u.Acceso;
                DatosDeAcceso.usuario = u.Usuario;
                DatosDeAcceso.idtrabajador = u;
                DatosDeAcceso.NombreTrabajador = u.NombreCompleto;
                //DatosDeAcceso.acceso = u.NombreCompleto;
                if (txtUsuario.Text.Equals(u.Usuario) && txtContraseña.Text.Equals(u.Contraseña))
                {

                    //this.Visible = false;
                    frm_Principal formularioPrincipal = new frm_Principal();

                    //formularioPrincipal.ShowDialog();
                    formularioPrincipal.Show();
                    this.Hide();
                   // this.Visible = true;
                    xpCollectionUsuario.Reload();
                    this.txtContraseña.Text = string.Empty;
                    this.txtContraseña.Focus();
                    
                    return;                   
                }             
            }
            this.MensajeError("Usuario o contraseña incorrecta");
            xpCollectionUsuario.Reload();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
