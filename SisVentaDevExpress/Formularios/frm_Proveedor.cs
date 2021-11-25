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
    public partial class frm_Proveedor : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        Proveedor proveedor_editar = null;
        public frm_Proveedor()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtRazonSocial, "Ingrese razon social del proveedor");
            this.ttMensaje.SetToolTip(this.txtNumeroDocumento, "Ingrese Numero de documento del proveedor");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la direccion del proveedor");
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
            this.txtRazonSocial.Text = string.Empty;
            this.txtNumeroDocumento.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtURL.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtidProveedor.Text = string.Empty;
            this.txtSectorComercial.Text = string.Empty;
            this.cbTipoDocumento.Text = "RUC";
        }
        //Habilitar los controles del Formuario
        private void Habilitar(bool valor)
        {
            this.txtRazonSocial.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtSectorComercial.Enabled = valor;
            this.cbTipoDocumento.Enabled = valor;
            this.txtNumeroDocumento.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtURL.ReadOnly = !valor;
            this.txtCorreo.ReadOnly = !valor;
            this.txtidProveedor.ReadOnly = !valor;
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
            this.lblTotal.Text = "Total de Registro: " + Convert.ToString(xpCollectionProveedor.Count);
        }
        private void frm_Proveedor_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoDocumento.Text == "Cedula")
            {
                txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                txtNumeroDocumento.Properties.Mask.EditMask = "000-000000-0000A";
                txtNumeroDocumento.Focus();
            }
            else
            {
                txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                txtNumeroDocumento.Properties.Mask.EditMask = "";
                txtNumeroDocumento.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea Eliminar el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    Proveedor proveedor = (Proveedor)dataListado.GetFocusedRow();
                    if (proveedor == null)
                    {
                        MensajeError("Seleccione Proveedor a Eliminar");
                    }
                    else
                    {
                        //Proveedor proveedor = (Proveedor)dataListado.GetFocusedRow();
                        proveedor.Delete();
                        unitOfWorkProveedor.CommitChanges();
                        xpCollectionProveedor.Reload();
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
            xpCollectionProveedor.Reload();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            tabControl1.SelectedIndex = 1;
            this.txtRazonSocial.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtRazonSocial.Text == string.Empty)
                {
                    this.txtRazonSocial.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtRazonSocial, "Ingrese la Razon Social");
                }
                else if (this.txtSectorComercial.Text == string.Empty)
                {
                    this.txtSectorComercial.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtSectorComercial, "Sector Comercial");
                }

                else if (this.cbTipoDocumento.Text == string.Empty)
                {
                    this.cbTipoDocumento.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(cbTipoDocumento, "Seleccione Tipo de Documento");
                }

                else if (this.txtNumeroDocumento.Text == string.Empty)
                {
                    this.txtNumeroDocumento.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtNumeroDocumento, "Ingrese Numero de Documento");
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

                else
                {
                    if (this.IsNuevo)
                    {
                        Proveedor proveedor = new Proveedor(unitOfWorkProveedor);
                        proveedor.Razon_Social = txtRazonSocial.Text;
                        proveedor.Sector_Comercial = txtSectorComercial.Text.ToString();
                        proveedor.Tipo_Documento = cbTipoDocumento.Text.ToString();
                        proveedor.Num_Documento = txtNumeroDocumento.Text.ToString();
                        proveedor.Direccion = txtDireccion.Text;
                        proveedor.Telefono = txtTelefono.Text;
                        proveedor.Email = txtCorreo.Text;
                        proveedor.URL = txtURL.Text;

                        proveedor.Save();
                        unitOfWorkProveedor.CommitChanges();
                        xpCollectionProveedor.Reload();
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

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            Proveedor presentacion = (Proveedor)dataListado.GetFocusedRow();
            if (presentacion == null)
            {
                MensajeError("Seleccione Proveedor a Editar");
            }
            else
            {
                proveedor_editar = (Proveedor)dataListado.GetFocusedRow();
                this.txtidProveedor.Text = proveedor_editar.IdProveedor.ToString();
                this.txtRazonSocial.Text = proveedor_editar.Razon_Social.ToString();
                this.txtSectorComercial.Text = proveedor_editar.Sector_Comercial.ToString();
                this.cbTipoDocumento.Text = proveedor_editar.Tipo_Documento.ToString();
                this.txtNumeroDocumento.Text = proveedor_editar.Num_Documento.ToString();
                this.txtDireccion.Text = proveedor_editar.Direccion.ToString();
                this.txtTelefono.Text = proveedor_editar.Telefono.ToString();
                this.txtCorreo.Text = proveedor_editar.Email.ToString();
                this.txtURL.Text = proveedor_editar.URL.ToString();
                tabControl1.SelectedIndex = 1;
                this.txtRazonSocial.Focus();
                this.Habilitar(true);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtRazonSocial.Text == string.Empty)
                {
                    this.txtRazonSocial.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtRazonSocial, "Ingrese la Razon Social");
                }
                else if (this.txtSectorComercial.Text == string.Empty)
                {
                    this.txtSectorComercial.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtSectorComercial, "Sector Comercial");
                }

                else if (this.cbTipoDocumento.Text == string.Empty)
                {
                    this.cbTipoDocumento.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(cbTipoDocumento, "Seleccione Tipo de Documento");
                }

                else if (this.txtNumeroDocumento.Text == string.Empty)
                {
                    this.txtNumeroDocumento.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtNumeroDocumento, "Ingrese Numero de Documento");
                }
                else if (this.txtTelefono.Text ==string.Empty )
                {
                    this.txtTelefono.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtTelefono, "Ingrese numero de telefono");
                }

                else
                {
                    Proveedor proveedor = proveedor_editar;
                    proveedor.Razon_Social = txtRazonSocial.Text;
                    proveedor.Sector_Comercial = txtSectorComercial.Text;
                    proveedor.Tipo_Documento = cbTipoDocumento.Text;
                    proveedor.Num_Documento = txtNumeroDocumento.Text;
                    proveedor.Direccion = txtDireccion.Text;
                    proveedor.Telefono = txtTelefono.Text;
                    proveedor.Email = txtCorreo.Text;
                    proveedor.URL = txtURL.Text;
                    proveedor.Save();
                    unitOfWorkProveedor.CommitChanges();
                    xpCollectionProveedor.Reload();
                    Limpiar();
                    this.MensajeOk("Se a Actualizo el Rejistro de Forma Correcta");
                    this.Habilitar(false);
                    tabControl1.SelectedIndex = 0;
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    errorIcon.Clear();
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

        private void btnImprimir1_Click(object sender, EventArgs e)
        {
            dataListado.ShowRibbonPrintPreview();
        }
    }
}
