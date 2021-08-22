using SisVentaDevExpress.Ventas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SisVentaDevExpress.Formularios
{
    public partial class frm_Trabajador : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        Trabajador trabajador_editar = null;
        public frm_Trabajador()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese Nombre del cliente");
            this.ttMensaje.SetToolTip(this.txtApellido, "Ingrese los Apellidos del cliente");
            this.ttMensaje.SetToolTip(this.cbSexo, "Seleccione el sexo del cliente");
            this.ttMensaje.SetToolTip(this.dtFechaNacimiento, "Ingrese fecha de nacimiento del cliete");
            this.ttMensaje.SetToolTip(this.cbAcceso, "Seleccione tipo de Acceso");
            this.ttMensaje.SetToolTip(this.txtCedula, "Ingrese numero de cedula");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la direccion");
            this.ttMensaje.SetToolTip(this.txtTelefono, "Ingrese numero telefonico");
            this.ttMensaje.SetToolTip(this.txtCorreo, "Ingrese el correo electronico");
            this.ttMensaje.SetToolTip(this.txtUsuario, "Ingrese el Usuario");
            this.ttMensaje.SetToolTip(this.txtContraseña, "Ingrese la contraseña");
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.cbSexo.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtCedula.Text = string.Empty;
            this.cbAcceso.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;
            this.txtidTrabajador.Text = string.Empty;

        }
        //Habilitar los controles del Formuario
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.cbSexo.Enabled = valor;
            this.dtFechaNacimiento.Enabled = valor;
            this.cbAcceso.Enabled = valor;
            this.txtCedula.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtCorreo.ReadOnly = !valor;
            this.txtUsuario.ReadOnly = !valor;
            this.txtContraseña.ReadOnly = !valor;
            this.txtidTrabajador.ReadOnly = !valor;
        }
        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnAgregar.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnGuardarCambios.Enabled = false;
                this.btnEditar1.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnAgregar.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnGuardarCambios.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnEditar1.Enabled = true;
            }

        }
        private void OcultarColumnas()
        {
            //this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;
        }
        private void Mostrar()
        {
            this.lblTotal.Text = "Total de Registro: " + Convert.ToString(xpCollectiontrabajadores.Count);
        }
        private void frm_Trabajador_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea Eliminar el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    Cliente cliente = (Cliente)dataListado.GetFocusedRow();
                    cliente.Delete();
                    unitOfWorkTrabajadores.CommitChanges();
                    xpCollectiontrabajadores.Reload();
                    this.MensajeOk("Se elimino Correctamente el rejistro");
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
                MessageBox.Show("El dato esta Siendo Ocupado", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            xpCollectiontrabajadores.Reload();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            tabControl1.SelectedIndex = 1;
            this.txtNombre.Focus();
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            trabajador_editar = (Trabajador)dataListado.GetFocusedRow();
            this.txtidTrabajador.Text = trabajador_editar.IdTrabajador.ToString();
            this.txtNombre.Text = trabajador_editar.Nombre.ToString();
            this.txtApellido.Text = trabajador_editar.Apellidos.ToString();
            this.cbSexo.Text = trabajador_editar.Sexo.ToString();
            this.dtFechaNacimiento.Value = trabajador_editar.Fecha_Nacimiento;
            this.cbAcceso.Text = trabajador_editar.Acceso.ToString();
            this.txtCedula.Text = trabajador_editar.Cedula.ToString();
            this.txtDireccion.Text = trabajador_editar.Direccion.ToString();
            this.txtTelefono.Text = trabajador_editar.Telefono.ToString();
            this.txtCorreo.Text = trabajador_editar.Email.ToString();
            this.txtUsuario.Text = trabajador_editar.Usuario.ToString();
            this.txtContraseña.Text = trabajador_editar.Contraseña.ToString();
            tabControl1.SelectedIndex = 1;
            this.txtNombre.Focus();
            this.Habilitar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            tabControl1.SelectedIndex = 0;
            errorIcon.Clear();
        }

        private void btnImprimir1_Click(object sender, EventArgs e)
        {
            dataListado.ShowRibbonPrintPreview();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text == string.Empty)
                {
                    this.txtNombre.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtNombre, "Ingrese Nombres");
                }
                else if (this.txtApellido.Text == string.Empty)
                {
                    this.txtApellido.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtApellido, "Ingrese Apellidos");
                }

                else if (this.cbSexo.Text == string.Empty)
                {
                    this.cbSexo.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(cbSexo, "Seleccione un valor");
                }

                else if (this.txtCedula.Text == string.Empty)
                {
                    this.txtCedula.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtCedula, "Ingrese numero de Cedula");
                }
                else if (this.cbAcceso.Text == string.Empty)
                {
                    this.cbAcceso.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(cbAcceso, "Seleccione tipo de acceso");
                }
                else if (this.txtDireccion.Text == string.Empty)
                {
                    this.txtDireccion.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtDireccion, "Ingrese la direccion");
                }
                else if (this.txtTelefono.Text == string.Empty)
                {
                    this.txtTelefono.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtTelefono, "Ingrese numero de telefono");
                }
                else if (this.txtUsuario.Text == string.Empty)
                {
                    this.txtUsuario.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtUsuario, "Ingrese Usuario");
                }
                else if (this.txtContraseña.Text == string.Empty)
                {
                    this.txtContraseña.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtContraseña, "Ingrese Contraseña");
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        Trabajador trabajador = new Trabajador(unitOfWorkTrabajadores);
                        trabajador.Nombre = txtNombre.Text;
                        trabajador.Apellidos = txtApellido.Text;
                        trabajador.Sexo = cbSexo.Text.ToString();
                        trabajador.Fecha_Nacimiento = dtFechaNacimiento.Value;
                        trabajador.Cedula = txtCedula.Text.ToString();
                        trabajador.Acceso = cbAcceso.Text.ToString();
                        trabajador.Direccion = txtDireccion.Text;
                        trabajador.Telefono = txtTelefono.Text;
                        trabajador.Email = txtCorreo.Text;
                        trabajador.Usuario = txtUsuario.Text.ToString();
                        trabajador.Contraseña = txtContraseña.Text.ToString();

                        trabajador.Save();
                        unitOfWorkTrabajadores.CommitChanges();
                        xpCollectiontrabajadores.Reload();
                        this.MensajeOk("Se a Guardado el Rejistro de Forma Correcta");
                    }
                    this.Mostrar();
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    tabControl1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtNombre.Text == string.Empty || this.txtApellido.Text == string.Empty || this.cbSexo.Text == string.Empty || this.txtCedula.Text == string.Empty || this.cbAcceso.Text == string.Empty || this.txtUsuario.Text == string.Empty || this.txtContraseña.Text == string.Empty)
                {
                    MensajeError("Seleccione el dato a modificar");
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    Trabajador trabajador = trabajador_editar;
                    trabajador.Nombre = txtNombre.Text;
                    trabajador.Apellidos = txtApellido.Text;
                    trabajador.Sexo = cbSexo.Text;
                    trabajador.Fecha_Nacimiento = dtFechaNacimiento.Value;
                    trabajador.Cedula = txtCedula.Text;
                    trabajador.Acceso = cbAcceso.Text;
                    trabajador.Direccion = txtDireccion.Text;
                    trabajador.Telefono = txtTelefono.Text;
                    trabajador.Email = txtCorreo.Text;
                    trabajador.Usuario = txtUsuario.Text;
                    trabajador.Contraseña = txtContraseña.Text;
                    trabajador.Save();
                    unitOfWorkTrabajadores.CommitChanges();
                    xpCollectiontrabajadores.Reload();
                    Limpiar();
                    this.MensajeOk("Se a Actualizo el Rejistro de Forma Correcta");
                    this.Habilitar(false);
                    tabControl1.SelectedIndex = 0;
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void chboxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chboxMostrarContraseña.Checked==true)
            {
                if (this.txtContraseña.PasswordChar=='*')
                {
                    this.txtContraseña.PasswordChar = '\0';
                }
            }
            else
            {
                this.txtContraseña.PasswordChar = '*';
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

