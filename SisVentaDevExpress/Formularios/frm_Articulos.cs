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
    public partial class frm_Articulos : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        Articulo articulo_editar = null;
        public frm_Articulos()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCodigoVenta, "Ingrese el Codigo de Venta");
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre del Articulo");
            this.ttMensaje.SetToolTip(this.sbxCategoria, "Seleccione la Categoria del Articulo");
            this.ttMensaje.SetToolTip(this.sbxPresentacion, "Seleccione la Presentación del Articulo");
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
            this.txtCodigoVenta.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.sbxCategoria.Text = string.Empty;
            this.sbxPresentacion.Text = string.Empty;

        }
        //Habilitar los controles del Formuario
        private void Habilitar(bool valor)
        {
            this.txtCodigoVenta.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.sbxCategoria.ReadOnly = !valor;
            this.sbxPresentacion.ReadOnly = !valor;
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
        private void Mostrar()
        {
            this.lblTotal.Text = "Total de Registro: " + Convert.ToString(xpCollectionArticulos.Count);
        }
        private void frm_Articulos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            tabControl1.SelectedIndex = 1;
            this.txtCodigoVenta.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCodigoVenta.Text == string.Empty)
                {
                    this.txtCodigoVenta.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtCodigoVenta, "Ingrese Codigo de Venta");
                }
                else if (this.txtNombre.Text == string.Empty)
                {
                    this.txtNombre.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtNombre, "Ingrese Nombre de Articulo");               
                }
                
                else if (this.sbxCategoria.Text == string.Empty)
                {
                   this.sbxCategoria.Focus();
                   errorIcon.Clear();
                   MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                   errorIcon.SetError(sbxCategoria, "Seleccione la Categoria");
                }
                
                else if (this.sbxPresentacion.Text == string.Empty)
                {
                    this.sbxPresentacion.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(sbxPresentacion, "Seleccione la Presentacion");
                }

                else
                {
                    if (this.IsNuevo)
                    {
                       Articulo articulo = new Articulo(unitOfWorkArticulos);
                       articulo.Codigo = txtCodigoVenta.Text; 
                       articulo.Nombre = txtNombre.Text;
                       articulo.Descripcion = txtDescripcion.Text;
                       articulo.IdCategoria = (Categoria)searchLookUpEdit1View.GetFocusedRow();
                       articulo.IdPresentacion = (Presentacion)searchLookUpEdit2View.GetFocusedRow();

                       articulo.Save();
                       unitOfWorkArticulos.CommitChanges();
                       xpCollectionArticulos.Reload();
                       this.MensajeOk("Se a Guardado el Rejistro de Forma Correcta");
                    //MessageBox.Show(Convert.ToString(articulo.IdArticulos));
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
        private void btnEditar1_Click(object sender, EventArgs e)
        {
            articulo_editar = (Articulo)dataListado.GetFocusedRow();
            this.txtCodigo.Text = articulo_editar.IdArticulos.ToString();
            this.txtCodigoVenta.Text = articulo_editar.Codigo.ToString();
            this.txtNombre.Text = articulo_editar.Nombre.ToString();
            this.txtDescripcion.Text = articulo_editar.Descripcion.ToString();
            this.sbxCategoria.Text= (articulo_editar.IdCategoria).IdCategoria.ToString();
            this.sbxPresentacion.Text = (articulo_editar.IdPresentacion).IdPresentacion.ToString();
            tabControl1.SelectedIndex = 1;
            this.txtCodigoVenta.Focus();
            this.Habilitar(true);
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtCodigoVenta.Text==string.Empty||this.txtNombre.Text == string.Empty||this.sbxCategoria.Text==string.Empty||this.sbxPresentacion.Text==string.Empty)
                {
                    MensajeError("Seleccione el dato a modificar");
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    Articulo articulo = articulo_editar;
                    articulo.Codigo = txtCodigoVenta.Text.ToString();
                    articulo.Nombre = txtNombre.Text.ToString();
                    articulo.Descripcion = txtDescripcion.Text.ToString();
                    articulo.IdCategoria = (Categoria)searchLookUpEdit1View.GetFocusedRow();
                    articulo.IdPresentacion = (Presentacion)searchLookUpEdit2View.GetFocusedRow();
                    articulo.Save();
                    unitOfWorkArticulos.CommitChanges();
                    xpCollectionArticulos.Reload();
                    Limpiar();
                    this.MensajeOk("Se a Actualizo el Rejistro de Forma Correcta");
                    this.Habilitar(false);
                    tabControl1.SelectedIndex = 0;
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    errorIcon.Clear();
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                
                //MessageBox.Show("Selecione Categoria y Presentacion", "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.sbxCategoria.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(sbxCategoria, "Seleccione la Categoria");
                    errorIcon.SetError(sbxPresentacion, "Seleccione la Presentacion");
                //MessageBox.Show(ex.Message + ex.StackTrace);

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

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea Eliminar el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    Articulo articulo = (Articulo)dataListado.GetFocusedRow();
                    articulo.Delete();
                    unitOfWorkArticulos.CommitChanges();
                    xpCollectionArticulos.Reload();
                    this.MensajeOk("Se elimino Correctamente el rejistro");
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
                MessageBox.Show("El dato esta Siendo Ocupado", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            xpCollectionPresentacion.Reload();
        }

        private void sbxCategoria_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
