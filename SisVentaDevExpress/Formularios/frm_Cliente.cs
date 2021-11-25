using SisVentaDevExpress.Ventas;
using System;
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
    public partial class frm_Cliente : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        Cliente Cliente_editar = null;
        public frm_Cliente()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese Nombre del cliente");
            this.ttMensaje.SetToolTip(this.txtApellido, "Ingrese los Apellidos del cliente");
            this.ttMensaje.SetToolTip(this.cbSexo, "Seleccione el sexo del cliente");
            this.ttMensaje.SetToolTip(this.dtFechaNacimiento, "Ingrese fecha de nacimiento del cliete");
            this.ttMensaje.SetToolTip(this.cbTipoDocumento, "Seleccione tipo de documento");
            this.ttMensaje.SetToolTip(this.txtNumeroDocumento, "Ingrese los datos del documento");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la direccion");
            this.ttMensaje.SetToolTip(this.txtTelefono, "Ingrese numero telefonico");
            this.ttMensaje.SetToolTip(this.txtCorreo, "Ingrese el correo electronico");
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
            this.txtNumeroDocumento.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtidCliente.Text = string.Empty;
            
        }
        //Habilitar los controles del Formuario
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.cbSexo.Enabled = valor;
            this.dtFechaNacimiento.Enabled = valor;
            this.cbTipoDocumento.Enabled = valor;
            this.txtNumeroDocumento.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtCorreo.ReadOnly = !valor;
            this.txtidCliente.ReadOnly = !valor;
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
            this.lblTotal.Text = "Total de Registro: " + Convert.ToString(xpCollectionCliente.Count);
        }
        private void frm_Cliente_Load(object sender, EventArgs e)
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
                    if (cliente == null)
                    {
                        MensajeError("Seleccione Cliente a Eliminar");
                    }
                    else
                    {

                        cliente.Delete();
                        unitOfWorkCliente.CommitChanges();
                        xpCollectionCliente.Reload();
                        this.MensajeOk("Se elimino Correctamente el rejistro");
                        this.Mostrar();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
                MessageBox.Show("El dato esta Siendo Ocupado", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            xpCollectionCliente.Reload();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            //txtTelefono.Properties.Mask.EditMask = "(000)0000-0000";

            //txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            //txtNumeroDocumento.Properties.Mask.EditMask = "000-000000-0000A";

            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            tabControl1.SelectedIndex = 1;
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text == string.Empty)
                {
                    this.txtNombre.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtNombre, "Ingrese Nombre");
                }
                else if (this.txtApellido.Text == string.Empty)
                {
                    this.txtApellido.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtApellido, "Ingrese Apellido");
                }

                else if (this.cbSexo.Text == string.Empty)
                {
                    this.cbSexo.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(cbSexo, "Seleccione Sexo");
                }
                

                else
                {
                    if (this.IsNuevo)
                    {
                        Cliente cliente = new Cliente(unitOfWorkCliente);
                        //if (this.txtTelefono.Text == "(___)____-____")
                        //{
                        //    txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                        //    txtTelefono.Properties.Mask.EditMask = "";
                            //cliente.Telefono = txtTelefono.Text;
                        //}
                        
                        cliente.Nombre = txtNombre.Text;
                        cliente.Apellido = txtApellido.Text;
                        cliente.Sexo = cbSexo.Text.ToString();
                        cliente.Fecha_Nacimiento = dtFechaNacimiento.Value;
                        cliente.Tipo_Documento = cbTipoDocumento.Text.ToString();
                        cliente.Num_Documento = txtNumeroDocumento.Text.ToString();
                        cliente.Direccion = txtDireccion.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Email = txtCorreo.Text;

                        cliente.Save();
                        unitOfWorkCliente.CommitChanges();
                        xpCollectionCliente.Reload();
                        this.MensajeOk("Se a Guardado el Rejistro de Forma Correcta");
                    }
                    this.Mostrar();
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    errorIcon.Clear();
                    tabControl1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
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

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoDocumento.Text == "Pasaporte")
            {
                txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                txtNumeroDocumento.Properties.Mask.EditMask = "";
                this.txtNumeroDocumento.Focus();
            }
            else if (cbTipoDocumento.Text == "")
            {
                txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                txtNumeroDocumento.Properties.Mask.EditMask = "";
                this.txtNumeroDocumento.Focus();
            }
            else
            {
                txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                txtNumeroDocumento.Properties.Mask.EditMask = "000-000000-0000A";
            }
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)dataListado.GetFocusedRow();
            if (cliente == null)
            {
                MensajeError("Seleccione Cliente a Editar");
            }
            else
            {
                if (txtTelefono.Text==string.Empty)
                {
                    txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                    txtTelefono.Properties.Mask.EditMask = "(000)0000-0000";
                }
                else if (cbTipoDocumento.Text == string.Empty)
                {
                    txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                    txtNumeroDocumento.Properties.Mask.EditMask = "";
                }
                else if (cbTipoDocumento.Text == "Cedula")
                {
                    txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                    txtNumeroDocumento.Properties.Mask.EditMask = "000-000000-0000A";
                }
                else if (cbTipoDocumento.Text == "Pasaporte")
                {
                    txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                    txtNumeroDocumento.Properties.Mask.EditMask = "";
                }
                Cliente_editar = (Cliente)dataListado.GetFocusedRow();
                this.txtidCliente.Text = Cliente_editar.IdCliente.ToString();
                this.txtNombre.Text = Cliente_editar.Nombre.ToString();
                this.txtApellido.Text = Cliente_editar.Apellido.ToString();
                this.cbSexo.Text = Cliente_editar.Sexo.ToString();
                this.dtFechaNacimiento.Value = Cliente_editar.Fecha_Nacimiento;
                this.cbTipoDocumento.Text = Cliente_editar.Tipo_Documento.ToString();
                this.txtNumeroDocumento.Text = Cliente_editar.Num_Documento.ToString();
                this.txtDireccion.Text = Cliente_editar.Direccion.ToString();
                this.txtTelefono.Text = Cliente_editar.Telefono.ToString();
                this.txtCorreo.Text = Cliente_editar.Email.ToString();
                tabControl1.SelectedIndex = 1;
                this.txtNombre.Focus();
                this.Habilitar(true);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtNombre.Text == string.Empty)
                {
                    this.txtNombre.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtNombre, "Ingrese Nombre");
                }
                else if (this.txtApellido.Text == string.Empty)
                {
                    this.txtApellido.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtApellido, "Ingrese Apellido");
                }

                else if (this.cbSexo.Text == string.Empty)
                {
                    this.cbSexo.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(cbSexo, "Seleccione Sexo");
                }
                else
                {
                    Cliente cliente = Cliente_editar;
                    
                        cliente.Nombre = txtNombre.Text;
                        cliente.Apellido = txtApellido.Text;
                        cliente.Sexo = cbSexo.Text;
                        cliente.Fecha_Nacimiento = dtFechaNacimiento.Value;
                        cliente.Tipo_Documento = cbTipoDocumento.Text;
                        cliente.Num_Documento = txtNumeroDocumento.Text;
                        cliente.Direccion = txtDireccion.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Email = txtCorreo.Text;
                        cliente.Save();
                        unitOfWorkCliente.CommitChanges();
                        xpCollectionCliente.Reload();
                    
                    Limpiar();
                    this.MensajeOk("Se a Actualizo el Rejistro de Forma Correcta");
                    this.Habilitar(false);
                    errorIcon.Clear();
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

        private void btnImprimir1_Click(object sender, EventArgs e)
        {
            dataListado.ShowRibbonPrintPreview();
        }
    }
}
