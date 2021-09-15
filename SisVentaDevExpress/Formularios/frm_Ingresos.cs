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
    public partial class frm_Ingresos : Form
    {
        public int IdTrabajador;
        private bool IsNuevo = false;
        private bool IsEditar = false;
        Detalle_Ingreso detalle_editar = null;
        //Ingreso ingreso_editar = null;
        Ingreso ingreso=null;
        private decimal TotalPagado = 0;
        public frm_Ingresos()
        {
            InitializeComponent();
            xpCollectionIngreso.Reload();
            this.ttMensaje.SetToolTip(this.sbProveedor, "Seleccione Proveedor");
            this.ttMensaje.SetToolTip(this.txtSerie, "Ingrese la serie del comprobante");
            this.ttMensaje.SetToolTip(this.txtCorrelativo, "Ingrese el numero del comprobante");
            this.ttMensaje.SetToolTip(this.txtStockInicial, "Ingrese la cantidad de compra");
            this.ttMensaje.SetToolTip(this.sbArticulo, "Seleccione Articulo de compra");
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
            this.txtidIngresos.Text = string.Empty;
            this.txtSerie.Text = string.Empty;
            this.txtCorrelativo.Text = string.Empty;
            this.txtIGV.Text = string.Empty;
            this.cbComprobante.Text = "TICKET";
            this.sbTrabajador.Text = string.Empty;
            this.sbProveedor.Text = string.Empty;
            this.lblTotalP.Text = "0,0";
            this.gridControlDetalleIngreso.DataSource = null;
            ingreso = null;
        }
        private void LimpiarDetalles()
        {
            this.sbArticulo.Text = string.Empty;
            this.txtStockInicial.Text = string.Empty;
            this.txtPrecioCompra.Text = string.Empty;
            this.txtPrecioVenta.Text = string.Empty;
        }
        //Habilitar los controles del Formuario
        private void Habilitar(bool valor)
        {
            
            this.txtidIngresos.ReadOnly = !valor;
            this.txtSerie.ReadOnly = !valor;
            this.txtCorrelativo.ReadOnly = !valor;
            this.txtIGV.ReadOnly = !valor;
            this.sbTrabajador.ReadOnly = !valor;
            this.sbProveedor.ReadOnly = !valor;
            this.cbComprobante.Enabled = valor;
            this.dtFechaIngreso.Enabled = valor;

            this.txtIdDetalleIngreso.ReadOnly = !valor;
            this.txtStockInicial.ReadOnly = !valor;
            this.sbArticulo.Enabled = valor;
            this.txtPrecioCompra.ReadOnly = !valor;
            this.txtPrecioVenta.ReadOnly = !valor;
            this.dtFechaProducion.Enabled = valor;
            this.dtFechaVencimiento.Enabled = valor;
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

            this.lblTotal.Text = "Total de Registro: " + Convert.ToString(xpCollectionIngreso.Count);
        }
        private void OcultarColumnas()
        {
            //dataListadoDetalle.Columns[0].Visible = false;
            //dataListadoDetalle.Columns[1].Visible = false;
            //dataListadoDetalle.Columns[2].Visible = false;
            //dataListadoDetalle.Columns[3].Visible = false;
        }

        private void frm_Ingresos_Load(object sender, EventArgs e)
        {
            ingreso = new Ingreso(unitOfWorkIngreso);

            gridControlDetalleIngreso.DataSource = ingreso.Detalle_Ingresos;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            //Ingreso idt = (Ingreso)dataListado.GetFocusedRow();
            //string estado = "Aunulado";
            //try
            //{
            //    DialogResult opcion;
            //    opcion = MessageBox.Show("Desea Anular el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //    if (opcion == DialogResult.OK)
            //    {
            //        ingreso.IdTrabajador = ingreso_editar.IdTrabajador;
            //        ingreso.IdProveedor = ingreso_editar.IdProveedor;
            //        ingreso.IGV = ingreso_editar.IGV;
            //        ingreso.Fecha_Ingreso = ingreso_editar.Fecha_Ingreso;
            //        ingreso.Correlativo = ingreso_editar.Correlativo;
            //        ingreso.Serie = ingreso_editar.Serie;
            //        ingreso.Tipo_Comprobante = ingreso_editar.Tipo_Comprobante;
            //        ingreso.Estado = estado;
            //        ingreso.Save();
            //        unitOfWorkIngreso.CommitChanges();
            //        xpCollectionIngreso.Reload();
            //        this.MensajeOk("Se Anulo Correctamente el rejistro");
            //        this.Mostrar();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show(ex.Message + ex.StackTrace);
            //    MessageBox.Show("El dato esta Siendo Ocupado", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //xpCollectionIngreso.Reload();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ingreso == null)
            {
                ingreso = new Ingreso(unitOfWorkIngreso);

                gridControlDetalleIngreso.DataSource = ingreso.Detalle_Ingresos;
            }
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();

            this.Habilitar(true);
            tabControl1.SelectedIndex = 1;
            this.sbProveedor.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.sbProveedor.Text == string.Empty)
                {
                    this.sbProveedor.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(sbProveedor, "Seleccione el Proveedor");
                }
                else if (this.txtIGV.Text == string.Empty)
                {
                    this.txtIGV.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtIGV, "Ingrese Impuesto");
                }
                else if (this.txtCorrelativo.Text == string.Empty)
                {
                    this.txtCorrelativo.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtCorrelativo, "Ingrese Correlativo");
                }

                else if (this.txtSerie.Text == string.Empty)
                {
                    this.txtSerie.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtSerie, "Ingrese Serie");
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        string estado = "Emitido";

                        ingreso.IGV = Convert.ToDecimal(txtIGV.Text);
                        ingreso.Fecha_Ingreso = dtFechaIngreso.Value;
                        ingreso.Correlativo = txtCorrelativo.Text;
                        ingreso.Serie = txtSerie.Text;
                        ingreso.Tipo_Comprobante = cbComprobante.Text;
                        ingreso.Estado = estado;
                        ingreso.Save();
                        unitOfWorkIngreso.CommitChanges();
                        xpCollectionIngreso.Reload();
                        this.MensajeOk("Se a Guardado el Rejistro de Forma Correcta");

                        this.IsNuevo = true;
                        this.IsEditar = false;
                        this.btnGuardar.Enabled = true;
                        this.Habilitar(true);
                    }
                    this.Habilitar(false);
                    this.Limpiar();
                    this.Mostrar();
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();

                    tabControl1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.sbArticulo.Text == string.Empty)
                {
                    this.sbArticulo.Focus();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtIGV, "Seleccione el Articulo");
                }
                else if (this.txtStockInicial.Text == string.Empty)
                {
                    this.txtStockInicial.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtStockInicial, "Ingrese Cantidad");
                }

                else if (this.txtPrecioCompra.Text == string.Empty)
                {
                    this.txtPrecioCompra.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtPrecioCompra, "Ingrese Precio");
                }
                else if (this.txtPrecioVenta.Text == string.Empty)
                {
                    this.txtPrecioVenta.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtPrecioVenta, "Ingrese Precio");
                }

                else
                {
                    if (ingreso != null)
                    {
                        Detalle_Ingreso detalleIngreso = new Detalle_Ingreso(unitOfWorkIngreso);
                        detalleIngreso.IdArticulo = (Articulo)searchLookUpEdit1View.GetFocusedRow();
                        detalleIngreso.Stock_inicial = Convert.ToInt32(txtStockInicial.Text.Trim());
                        detalleIngreso.Precio_Compra = Convert.ToDecimal(txtPrecioCompra.Text.Trim());
                        detalleIngreso.Precio_Venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                        detalleIngreso.Fecha_Produccion = dtFechaProducion.Value;
                        detalleIngreso.Fecha_Vencimiento = dtFechaVencimiento.Value;
                        detalleIngreso.Save();
                        xpCollectionDetalleIngreso.Reload();
                        ingreso.Detalle_Ingresos.Add(detalleIngreso);
                        this.MensajeOk("Articulo Adregado");
                        decimal subTotal = Convert.ToDecimal((this.txtStockInicial.Text)) * Convert.ToDecimal((this.txtPrecioCompra.Text));
                        TotalPagado = TotalPagado + subTotal;
                        this.lblTotalP.Text = TotalPagado.ToString();
                        this.LimpiarDetalles();
                    }
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

        private void sbTrabajador_EditValueChanged(object sender, EventArgs e)
        {
            ///// Ingreso ingreso = new Ingreso(unitOfWorkIngreso);
            Trabajador trabajador = (Trabajador)gridView1.GetFocusedRow();
            if (ingreso != null)
            {
                ingreso.IdTrabajador = trabajador;
                ingreso.Save();
            }
            
          

           // MessageBox.Show(ingreso.IdTrabajador.ToString());
        }

        private void sbProveedor_EditValueChanged(object sender, EventArgs e)
        {
            ////Ingreso ingreso = new Ingreso(unitOfWorkIngreso);
            Proveedor i = (Proveedor)searchLookUpEdit2View.GetFocusedRow();
            if (ingreso != null)
            {
                ingreso.IdProveedor = i;
                ingreso.Save();
            }

            //MessageBox.Show(i.IdProveedor.ToString());
        }

        private void sbArticulo_EditValueChanged(object sender, EventArgs e)
        {
             //Articulo i = (Articulo)searchLookUpEdit1View.GetFocusedRow();
            //MessageBox.Show(Convert.ToString( i.IdArticulos));

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea Eliminar el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    Detalle_Ingreso di = (Detalle_Ingreso)dataListadoDetalle.GetFocusedRow();
                    di.Delete();
                    detalle_editar = (Detalle_Ingreso)dataListadoDetalle.GetFocusedRow();
                    decimal calculo = di.Stock_inicial * di.Precio_Compra;
                    this.TotalPagado = TotalPagado - calculo;
                    this.lblTotalP.Text = TotalPagado.ToString();
                    //this.MensajeOk("Se elimino Correctamente el rejistro");
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            //ingreso_editar = (Ingreso)dataListado.GetFocusedRow();
            //MessageBox.Show(ingreso_editar.Estado);
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            //ingreso_editar = (Ingreso)dataListado.GetFocusedRow();
            //MessageBox.Show(ingreso_editar.Estado);
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            //if (ingreso == null)
            //{
            //    ingreso = new Ingreso(unitOfWorkIngreso);

            //    gridControlDetalleIngreso.DataSource = ingreso.Detalle_Ingresos;
            //}
            //this.IsNuevo = true;
            //this.IsEditar = false;
            //this.btnGuardar.Enabled = true;
            ////this.Limpiar();
            //this.Habilitar(true);
            ////Habilitar(true);
        }

    }
}
