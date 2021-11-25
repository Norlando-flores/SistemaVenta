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

namespace SisVentaDevExpress
{
    public partial class frm_Presentacion : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        Presentacion presentacion_editar = null;
        public frm_Presentacion()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre de la Categoria");
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
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;

        }
        //Habilitar los controles del Formuario
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
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
            this.lblTotal.Text = "Total de Registro: " + Convert.ToString(xpCollectionPresentacion.Count);
        }
        private void frm_Presentacion_Load(object sender, EventArgs e)
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
            this.txtNombre.Focus();
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtNombre, "Ingrese un Nombre");


                }
                else
                {
                    if (this.IsNuevo)
                    {
                        Presentacion presentacion = new Presentacion(unitOfWorkPresentacion);
                        presentacion.Nombre = txtNombre.Text;
                        presentacion.Descripcion = txtDescripcion.Text;

                        presentacion.Save();
                        unitOfWorkPresentacion.CommitChanges();
                        xpCollectionPresentacion.Reload();
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

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Seleccione el dato a modificar");
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    Presentacion presentacion = presentacion_editar;
                    presentacion.Nombre = txtNombre.Text;
                    presentacion.Descripcion = txtDescripcion.Text;
                    presentacion.Save();
                    unitOfWorkPresentacion.CommitChanges();
                    xpCollectionPresentacion.Reload();
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

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            Presentacion presentacion = (Presentacion)dataListado.GetFocusedRow();
            if (presentacion == null)
            {
                MensajeError("Seleccione U/M a Editar");
            }
            else
            {
                presentacion_editar = (Presentacion)dataListado.GetFocusedRow();
                txtCodigo.Text = presentacion_editar.IdPresentacion.ToString();
                txtNombre.Text = presentacion_editar.Nombre.ToString();
                txtDescripcion.Text = presentacion_editar.Descripcion.ToString();
                tabControl1.SelectedIndex = 1;
                this.txtNombre.Focus();
                this.Habilitar(true);
            }
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea Eliminar el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    Presentacion presentacion = (Presentacion)dataListado.GetFocusedRow();
                    if (presentacion == null)
                    {
                        MensajeError("Seleccione U/M a Eliminar");
                    }
                    else
                    {
                        
                        presentacion.Delete();
                        unitOfWorkPresentacion.CommitChanges();
                        xpCollectionPresentacion.Reload();
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
            xpCollectionPresentacion.Reload();
        }

        private void btnImprimir1_Click(object sender, EventArgs e)
        {
            dataListado.ShowRibbonPrintPreview();
        }
    }
}
