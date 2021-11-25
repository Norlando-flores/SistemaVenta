using System;
using DevExpress.XtraGrid;
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
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System.Data.SqlClient;
using System.Configuration;
//Detalle_venta d = detalle_editar;
//if (detalle != null)
//{ 
//    d.IdDetalle_Ingreso = (Detalle_Ingreso)gridviewArticulo.GetFocusedRow();

//}
namespace SisVentaDevExpress.Formularios
{
    public partial class frm_Venta : Form
    {
        public int IdTrabajador;
        private bool IsNuevo = false;
        private bool IsEditar = false;
        Detalle_venta detalle_editar = null;
        Detalle_Ingreso detalle_editar1 = null;
        Venta venta_editar = null;
        Venta venta = null;

        //se utiliza en el metodo salidaActualizar
        int a;

        // Se utiliza en el meodo calcular
        double c;
        double p;
        double d;
        double r;
        double d1; 

        public frm_Venta()
        {
            InitializeComponent();
            xpCollectionVenta.Reload();
            this.ttMensaje.SetToolTip(this.sbCliente, "Seleccione un Cliente");
            this.ttMensaje.SetToolTip(this.sbTrabajador, "Seleccione un Vendedor");
            this.ttMensaje.SetToolTip(this.txtSerie, "Ingrese la serie del comprobante");
            this.ttMensaje.SetToolTip(this.txtCorrelativo, "Ingrese el numero del comprobante");
            this.ttMensaje.SetToolTip(this.txtCantidad, "Ingrese la cantidad a vender");
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
            //Limpia los campo de venta
            this.txtidVenta.Text = string.Empty;
            this.sbTrabajador.Text = string.Empty;
            this.sbCliente.Text = string.Empty;
            this.dtFechaventa.Value = DateTime.Today;
            this.cbComprobante.Text = "FACTURA";
            this.txtSerie.Text = string.Empty;
            this.txtCorrelativo.Text = string.Empty; 
            this.gridControlDetalleVenta.DataSource = null;
            venta = null;
        }
        private void LimpiarDetalles()
        {
            //Limpia los campo del detalle de venta
            this.txtIdDetalleVenta.Text = string.Empty;
            this.txtIdDetalle.Text = string.Empty;
            this.sbArticulo.Text = string.Empty;
            this.txtPrecioVenta.Text = "0";
            this.txtstockActual.Text = "0";
            this.txtCantidad.Text = "0";
            this.txtDescuento.Text = "0";
            this.txtPrescioTotal.Text = "0";
            this.txtIVA.Text = "0";
        }
        //Habilitar los controles del Formuario
        private void Habilitar(bool valor)
        {
            //Bloquea los campos de venta
            this.txtidVenta.ReadOnly = !valor;
            this.sbTrabajador.ReadOnly = !valor;
            this.sbCliente.ReadOnly = !valor;
            this.dtFechaventa.Enabled = valor;
            this.cbComprobante.Enabled = valor;
            this.txtSerie.ReadOnly = !valor;
      
            //Bloquea los campo del detalle venta
            this.txtIdDetalleVenta.ReadOnly = !valor;
            this.txtIdDetalle.ReadOnly = !valor;
            this.sbArticulo.Enabled = valor;
            this.txtCantidad.ReadOnly = !valor;
            this.txtDescuento.ReadOnly = !valor;

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

            this.lblTotal.Text = "Total de Registro: " + Convert.ToString(xpCollectionVenta.Count);
            xpCollectionArticulo.Reload();
        }
        private void OcultarColumnas()
        {
            //dataListadoDetalle.Columns[0].Visible = false;
            //dataListadoDetalle.Columns[1].Visible = false;
            //dataListadoDetalle.Columns[2].Visible = false;
            //dataListadoDetalle.Columns[3].Visible = false;
        }
        private void salidaactualizar()
        {
            try
            {
                //Detalle_Ingreso detalle = detalle_editar1;
                Articulo detalle = (Articulo)gridviewArticulo.GetFocusedRow();
                Detalle_venta d = (Detalle_venta)dataListadoDetalle.GetFocusedRow();
                Articulo detalle2 = detalle;
                if (detalle != null)
                {
                  
                    //detalle = (Detalle_Ingreso)gridviewArticulo.GetFocusedRow();
                    a = Convert.ToInt32(detalle.Existencia) + Convert.ToInt32(d.Cantidad);
                    int b = a - Convert.ToInt32(txtCantidad.Text);
                    //MensajeOk(a.ToString());
                    //MensajeOk(b.ToString());
                    detalle2.Existencia = b;

                    unitOfWorkVentas.CommitChanges();
                    xpCollectionArticulo.Reload();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void salida()
        {
            try
            {
                Articulo detalle = (Articulo)gridviewArticulo.GetFocusedRow();

                if (detalle != null)
                {
                    Articulo detalle1 = (Articulo)gridviewArticulo.GetFocusedRow();

                    int stockActual = Convert.ToInt32(detalle.Existencia - Convert.ToInt32(txtCantidad.Text));

                    detalle1.Existencia = stockActual;

                    unitOfWorkVentas.CommitChanges();
                    xpCollectionArticulo.Reload();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

            public void Calcular()
        {

            if (txtCantidad.Text.Trim().Length == 0 )
            {
                txtDescuento.Text = "0";
                txtPrescioTotal.Text = "0";
                return;
            }
            else if (txtDescuento.Text.Trim().Length == 0)
            {
                double c = Convert.ToDouble(txtCantidad.Text);
                double p = Convert.ToDouble(txtPrecioVenta.Text);
                txtPrescioTotal.Text = (c * p).ToString();
                return;
            }
            else
            {
                double c = Convert.ToDouble(txtCantidad.Text);
                double p = Convert.ToDouble(txtPrecioVenta.Text);
                double d = Convert.ToDouble(txtDescuento.Text);
                double r = p * c;
                double d1 = (r * d) / 100;
                txtPrescioTotal.Text = (r - d1).ToString();
            }
        }

        private void sbArticulo_EditValueChanged(object sender, EventArgs e)
        {
            if (this.IsNuevo)
            {
                Articulo d = (Articulo)gridviewArticulo.GetFocusedRow();
                txtstockActual.Text = Convert.ToString(d.Existencia);
                txtPrecioVenta.Text = Convert.ToString(d.PrecioVenta);
                txtIdDetalle.Text = Convert.ToString(d.IdArticulos);
                this.txtCantidad.ReadOnly = false;
                this.txtDescuento.ReadOnly = false;
                this.txtCantidad.Focus();
            }         
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim().Length == 0)
            {
                txtPrescioTotal.Text = "0";
                return;
            }
            else
            {
                double c = Convert.ToDouble(txtCantidad.Text);
                double p = Convert.ToDouble(txtPrecioVenta.Text);
                double r = p * c;
                txtPrescioTotal.Text = (r).ToString();
            }
            //Calcular();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (txtDescuento.Text.Trim().Length == 0)
            {
                txtCalculoDescuento.Text = "0";
                return;
            }
            else
            {
                decimal c = Convert.ToDecimal(txtDescuento.Text);
                decimal p = Convert.ToDecimal(txtPrescioTotal.Text);
                decimal r = (p * c)/100;
                txtCalculoDescuento.Text = (r).ToString();
            }
            //Calcular();
        }

        private void frm_Venta_Load(object sender, EventArgs e)
        {
            xpCollectionTrabajador.Filter = CriteriaOperator.Parse("[Acceso] = ?", DatosDeAcceso.acceso);
            //BinaryOperator filterCriteria = new BinaryOperator(nameof(Articulo.Existencia),0, BinaryOperatorType.Greater);

            //xpCollectionArticulo.Filter = filterCriteria;
            gridControlDetalleVenta.DataSource = null;
            gridControl2.DataSource = xpCollectionVenta;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {
                venta = new Venta(unitOfWorkVentas);

                gridControlDetalleVenta.DataSource = venta.Detalle_ventas;
                   
            }
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();

            this.Habilitar(true);
            this.txtCantidad.ReadOnly = true;
            this.txtDescuento.ReadOnly = true;
            this.btnAgregar1.Text = "Agregar";
            tabControl1.SelectedIndex = 1;
            this.sbTrabajador.Focus();
        }
        private void btnEditar1_Click(object sender, EventArgs e)
        {
            Venta venta = (Venta)dataListado.GetFocusedRow();
            if (venta == null)
            {
                MensajeError("Seleccione Venta a Editar");
            }
            else
            {
                venta_editar = (Venta)dataListado.GetFocusedRow();
                this.txtidVenta.Text = venta_editar.IdVenta.ToString();
                this.sbTrabajador.Text = (venta_editar.IdTrabajador).IdTrabajador.ToString();
                this.sbCliente.Text = (venta_editar.IdCliente).IdCliente.ToString();
                this.dtFechaventa.Value = venta_editar.Fecha;
                this.cbComprobante.Text = venta_editar.Tipo_Comprobante.ToString();
                this.txtSerie.Text = venta_editar.Serie.ToString();
                this.txtCorrelativo.Text = venta_editar.NDocumento.ToString();
                gridControlDetalleVenta.DataSource = venta_editar.Detalle_ventas;
                this.sbTrabajador.Focus();

                this.IsNuevo = false;
                this.IsEditar = true;
                this.btnAgregar1.Text = "Actualizar";
                tabControl1.SelectedIndex = 1;
                this.Habilitar(true);
            }
        }

        private void btnImprimir1_Click(object sender, EventArgs e)
        {
            dataListado.ShowRibbonPrintPreview();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea elimino el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {

                    Venta venta = (Venta)dataListado.GetFocusedRow();
                    if (venta == null)
                    {
                        MensajeError("Seleccione la Venta a eliminar");
                    }
                    else
                    {
                        venta.Delete();

                        unitOfWorkVentas.CommitChanges();
                        xpCollectionVenta.Reload();
                        MessageBox.Show("Se elimino correctamente el rejistro");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El dato esta Siendo Ocupado", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            xpCollectionVenta.Reload();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.sbCliente.Text == string.Empty)
                {
                    this.sbCliente.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(sbCliente, "Seleccione el Cliente");
                }
                else if (this.sbTrabajador.Text == string.Empty)
                {
                    this.sbTrabajador.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(sbTrabajador, "Seleccione el Trabajador");
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
                    if (this.IsNuevo == true)
                    {

                        //double p = Convert.ToDouble(colTotal.SummaryItem.SummaryValue);

                        Trabajador trabajador = (Trabajador)gridViewTrabajador.GetFocusedRow();
                        Cliente cliente = (Cliente)gridViewCliente.GetFocusedRow();
                        //decimal a = (Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) + ((Convert.ToDecimal(colTotal.SummaryItem.SummaryValue)) * (decimal.Parse(txtIGV.Text) / 100)));
                        venta.IdTrabajador = trabajador;
                        venta.IdCliente = cliente;
                        venta.Fecha = dtFechaventa.Value;
                        venta.Tipo_Comprobante = cbComprobante.Text;
                        venta.Serie = txtSerie.Text.ToUpper();
                        venta.NDocumento = txtCorrelativo.Text;
                        venta.IVA = Convert.ToDecimal(colIVA2.SummaryItem.SummaryValue);
                        venta.SubTotal= (Convert.ToDecimal(colSubTotal2.SummaryItem.SummaryValue) - Convert.ToDecimal(colDescuento2.SummaryItem.SummaryValue));
                        venta.TotalPagar= Convert.ToDecimal(colTotal2.SummaryItem.SummaryValue);                        
                        venta.Save();
                        unitOfWorkVentas.CommitChanges();
                        xpCollectionVenta.Reload();
                        xpCollectionNDocumento.Reload();
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

            Venta venta = venta_editar;
            Trabajador trabajador = (Trabajador)gridViewTrabajador.GetFocusedRow();
            if (trabajador != null)
            {
                venta.IdTrabajador = (Trabajador)gridViewTrabajador.GetFocusedRow();
            }
            Cliente cliente = (Cliente)gridViewCliente.GetFocusedRow();
            if (cliente != null)
            {
                venta.IdCliente = (Cliente)gridViewCliente.GetFocusedRow();
            }

            venta.Fecha = dtFechaventa.Value;
            venta.Tipo_Comprobante = cbComprobante.Text;
            venta.Serie = txtSerie.Text.ToUpper();
            venta.NDocumento = txtCorrelativo.Text;
            venta.IVA = Convert.ToDecimal(colIVA2.SummaryItem.SummaryValue);
            venta.SubTotal = (Convert.ToDecimal(colSubTotal2.SummaryItem.SummaryValue) - Convert.ToDecimal(colDescuento2.SummaryItem.SummaryValue));
            venta.TotalPagar = Convert.ToDecimal(colTotal2.SummaryItem.SummaryValue);
            venta.Save();
            unitOfWorkVentas.CommitChanges();
            xpCollectionNDocumento.Reload();
            xpCollectionVenta.Reload();
            
            Limpiar();
            this.MensajeOk("Se a Actualizo el Rejistro de Forma Correcta");
            this.Habilitar(false);
            tabControl1.SelectedIndex = 0;
            xpCollectionTrabajador.Filter = CriteriaOperator.Parse("[Acceso] = ?", DatosDeAcceso.acceso);
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            errorIcon.Clear();
            this.Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.IsNuevo = false;
            this.IsEditar = false;
            this.Habilitar(false);
            this.Limpiar();
            this.LimpiarDetalles();         
            this.Mostrar();
            this.Botones();
            errorIcon.Clear();
            tabControl1.SelectedIndex = 0;
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.sbArticulo.Text == string.Empty)
                {
                    this.sbArticulo.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(sbArticulo, "Seleccione el Articulo");
                }

                else if (this.txtCantidad.Text == string.Empty)
                {
                    this.txtCantidad.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtCantidad, "Ingrese Cantidad");
                }
                else if (this.txtDescuento.Text == string.Empty)
                {
                    this.txtDescuento.Focus();
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(txtDescuento, "Ingrese Descuento");
                }
               
                else

                {
                    if (this.IsNuevo && venta != null)
                    {
                        if (Convert.ToInt32(txtCantidad.Text) > Convert.ToInt32(txtstockActual.Text))
                        {
                            MensajeError("La cantidas solisitada excede  ala cantidad de articulos en este ingreso ");
                            this.txtCantidad.Focus();
                        }
                        else
                        {
                            //decimal sub_Total = Convert.ToDecimal((txtStockInicial.Text)) * Convert.ToDecimal((txtPrecioCompra.Text));
                            Detalle_venta detalleVenta = new Detalle_venta(unitOfWorkVentas);
                            //Detalle_venta d = (Detalle_Ingreso)gridviewArticulo.GetFocusedRow();
                            //detalleVenta.IdDetalle_Ingreso = Convert.ToInt32(txtIdDetalle.Text.Trim());
                            salida();
                            detalleVenta.IdArticulo = (Articulo)gridviewArticulo.GetFocusedRow();
                            detalleVenta.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                            detalleVenta.Precio_Venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                            detalleVenta.Descuento = Convert.ToDecimal(txtCalculoDescuento.Text.Trim());
                            detalleVenta.DescuentoP = Convert.ToInt32(txtDescuento.Text.Trim());
                            detalleVenta.IVA= Convert.ToDecimal(txtIVA.Text.Trim());
                            detalleVenta.SubTotal = Convert.ToDecimal(txtPrescioTotal.Text.Trim());
                            detalleVenta.Total = (Convert.ToDecimal(txtPrescioTotal.Text) - Convert.ToDecimal(txtCalculoDescuento.Text)) + Convert.ToDecimal(txtIVA.Text);
                            detalleVenta.Save();

                            //unitOfWorkVentas.CommitChanges();
                            xpCollectionDetalleVenta.Reload();
                            venta.Detalle_ventas.Add(detalleVenta);
                            checkEdit1.Checked = false;
                            this.MensajeOk("Articulo Adregado");
                            this.LimpiarDetalles();
                            errorIcon.Clear();
                        }
                    }
                    else
                    {
                        if (this.IsEditar)
                        {
                            
                            Detalle_venta detalle = detalle_editar;
                            Articulo art = (Articulo)gridviewArticulo.GetFocusedRow();
                            if (art != null)
                            {
                                detalle.IdArticulo = (Articulo)gridviewArticulo.GetFocusedRow();
                            }
                            //decimal sub_Total = Convert.ToDecimal((txtStockInicial.Text)) * Convert.ToDecimal((txtPrecioCompra.Text));

                            salidaactualizar();
                            detalle.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                            detalle.Precio_Venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                            detalle.Descuento = Convert.ToDecimal(txtCalculoDescuento.Text.Trim());
                            detalle.DescuentoP = Convert.ToInt32(txtDescuento.Text.Trim());
                            detalle.IVA = Convert.ToDecimal(txtIVA.Text.Trim());
                            detalle.SubTotal = Convert.ToDecimal(txtPrescioTotal.Text.Trim());
                            detalle.Total = (Convert.ToDecimal(txtPrescioTotal.Text) - Convert.ToDecimal(txtCalculoDescuento.Text)) + Convert.ToDecimal(txtIVA.Text);

                            detalle.Save();
                            
                            //salida();
                           // unitOfWorkVentas.CommitChanges();
                            xpCollectionDetalleVenta.Reload();
                            LimpiarDetalles();
                            this.MensajeOk("Se a Actualizo el Rejistro de Forma Correcta");
                            checkEdit1.Checked = false;
                            this.LimpiarDetalles();
                            errorIcon.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void gridControlDetalleVenta_DoubleClick(object sender, EventArgs e)
        {
           

            detalle_editar = (Detalle_venta)dataListadoDetalle.GetFocusedRow();
            this.sbArticulo.Text = (detalle_editar.IdArticulo).IdArticulos.ToString();
            venta_editar = (Venta)dataListado.GetFocusedRow();
            this.txtIdDetalleVenta.Text = detalle_editar.IdDetalle_Venta.ToString();
            this.txtidVenta.Text = venta_editar.IdVenta.ToString();            
            this.txtPrecioVenta.Text = detalle_editar.Precio_Venta.ToString();
            this.txtstockActual.Text = detalle_editar.IdArticulo.Existencia.ToString();
            this.txtCantidad.Text = detalle_editar.Cantidad.ToString();
            this.txtDescuento.Text = detalle_editar.DescuentoP.ToString();
            this.txtCalculoDescuento.Text = detalle_editar.Descuento.ToString();
            this.txtPrescioTotal.Text = detalle_editar.SubTotal.ToString();

            if (txtIVA.Text=="0,00")
            {
                checkEdit1.Checked = false;
            }
            else
            {
                checkEdit1.Checked = true;
            }
            //salidaactualizar();
            this.sbArticulo.Focus();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea Eliminar el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                salidaactualizar();
                if (opcion == DialogResult.OK)
                {
                    if (this.IsNuevo && venta != null)
                    {
                        Articulo detalle1 = (Articulo)gridviewArticulo.GetFocusedRow();
                        Detalle_venta di1 = (Detalle_venta)dataListadoDetalle.GetFocusedRow();
                        Articulo detalle2 = di1.IdArticulo;
                        if (detalle1 == null)
                        {
                            int a = di1.IdArticulo.Existencia + di1.Cantidad;
                            detalle2.Existencia = a;
                            //MensajeOk(detalle2.Stock_Actual.ToString());
                            //detalle2.Save();
                            //unitOfWorkVentas.CommitChanges();
                            xpCollectionArticulo.Reload();
                        }

                        Detalle_venta di = (Detalle_venta)dataListadoDetalle.GetFocusedRow();
                        di.Delete();
                        detalle_editar = (Detalle_venta)dataListadoDetalle.GetFocusedRow();
                        this.Mostrar();
                        errorIcon.Clear();
                        xpCollectionArticulo.Reload();

                       
                    }
                    else
                    {
                        Detalle_Ingreso detalle1 = (Detalle_Ingreso)gridviewArticulo.GetFocusedRow();
                        Detalle_venta di1 = (Detalle_venta)dataListadoDetalle.GetFocusedRow();
                        Articulo detalle2 = di1.IdArticulo;
                        if (detalle1 == null)
                        {
                            int a = di1.IdArticulo.Existencia + di1.Cantidad;
                            detalle2.Existencia = a;
                            detalle2.Save();
                            //unitOfWorkVentas.CommitChanges();
                            xpCollectionArticulo.Reload();

                            Detalle_venta detalle = (Detalle_venta)dataListadoDetalle.GetFocusedRow();
                            detalle.Delete();
                            //unitOfWorkVentas.CommitChanges();
                            xpCollectionDetalleVenta.Reload();
                            MessageBox.Show("Se elimino correctamente el rejistro");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            //xpCollection1.Filter = CriteriaOperator.Parse("[IdVenta] = 4088 AND [Price] < ?", "Saloon", 100000);

            Venta v = (Venta)dataListado.GetFocusedRow();
            string j = v.IdVenta.ToString();
            //xpCollection1.Filter = CriteriaOperator.Parse("[IdVenta.IdVenta] = ?", j);
            // MensajeOk(j.ToString());

            //gridView1.DataSource = 
            //Venta obj = (Venta)dataListado.GetFocusedRow();



            //List<Detalle_venta> lista = xpCollection1
            frmReporteVenta l = new frmReporteVenta();

            l.printInvoice(v);
            l.ShowDialog();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                txtIVA.Text = ((decimal.Parse(txtPrescioTotal.Text) * 15) / 100).ToString();
            }
            else
            {
                txtIVA.Text = "0";
            }
        }

        private void txtSerie_EditValueChanged(object sender, EventArgs e)
        {
            xpCollectionNDocumento.Filter = CriteriaOperator.Parse("[Serie] = ?", txtSerie.Text);
            if (this.IsNuevo)
            {
                if (xpCollectionNDocumento.Count < 9)
            {
                this.txtCorrelativo.Text = $"0000{Convert.ToInt32(xpCollectionNDocumento.Count) + 1}";
            }
            else if (xpCollectionNDocumento.Count < 99 )
            {
                this.txtCorrelativo.Text = $"000{Convert.ToInt32(xpCollectionNDocumento.Count) + 1}";
            }
            else if (xpCollectionNDocumento.Count < 999)
            {
                this.txtCorrelativo.Text = $"00{Convert.ToInt32(xpCollectionNDocumento.Count) + 1}";
            }
            else if (xpCollectionNDocumento.Count < 9999)
            {
                this.txtCorrelativo.Text = $"0{Convert.ToInt32(xpCollectionNDocumento.Count) + 1}";
            }
        }
            if (this.IsEditar)
            {
                if (xpCollectionNDocumento.Count < 9)
                {
                    this.txtCorrelativo.Text = $"0000{Convert.ToInt32(xpCollectionNDocumento.Count)}";
                }
                else if (xpCollectionNDocumento.Count >= 10)
                {
                    this.txtCorrelativo.Text = $"000{Convert.ToInt32(xpCollectionNDocumento.Count)}";
                }
                else if (xpCollectionNDocumento.Count >= 100)
                {
                    this.txtCorrelativo.Text = $"00{Convert.ToInt32(xpCollectionNDocumento.Count)}";
                }
                else if (xpCollectionNDocumento.Count < 1000)
                {
                    this.txtCorrelativo.Text = $"0{Convert.ToInt32(xpCollectionNDocumento.Count)}";
                }

            }
        }

        private void txtIdDetalleVenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
