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
        Ingreso ingreso_editar = null;
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
           // this.txtPrecioVenta.ReadOnly = !valor;

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
        private void precio1()
        {
            try
            {
            //    Articulo detalle2 = (Articulo)searchLookUpEdit1View.GetFocusedRow();
            //    int a1 = detalle2.Existencia + int.Parse(txtStockInicial.Text);
            //    //Calculo de precio
            //    decimal a = detalle2.Existencia * detalle2.PrecioVenta;
            //    decimal b = Convert.ToDecimal(txtStockInicial.Text) * Convert.ToDecimal(txtPrecioVenta.Text);
            //    decimal c = (a + b) / a1;
            //    MensajeOk($"Articulo {a.ToString()}");
            //    MensajeOk($"Formulario {b.ToString()}");
            //    MensajeOk($"existencia {a1.ToString()}");
            //    MensajeOk($"calculo {c.ToString()}");


                Articulo detalle = (Articulo)searchLookUpEdit1View.GetFocusedRow();

                if (detalle != null)
                {
                    Articulo detalle1 = (Articulo)searchLookUpEdit1View.GetFocusedRow();
                    int CExistencia = detalle.Existencia + int.Parse(txtStockInicial.Text);
                    decimal costoTotalExistencia = detalle1.Existencia * detalle1.PrecioVenta;
                    decimal costoTotalNuvaCompra = Convert.ToDecimal(txtStockInicial.Text) * Convert.ToDecimal(txtPrecioVenta.Text);
                    decimal Calculo = (costoTotalExistencia + costoTotalNuvaCompra) / CExistencia;
                    //detalle1.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    if (detalle1.Existencia == 0)
                    {                        
                        detalle1.Existencia = int.Parse(txtStockInicial.Text);
                        detalle1.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
                        unitOfWorkIngreso.CommitChanges();
                        xpCollectionArticulos.Reload();
                    }
                    else
                    {
                        detalle1.Existencia = CExistencia;
                        detalle1.PrecioVenta = Calculo;
                        unitOfWorkIngreso.CommitChanges();
                        xpCollectionArticulos.Reload();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void precio2()
        {
            try
            {
                Articulo detalle = (Articulo)searchLookUpEdit1View.GetFocusedRow();

                if (detalle != null)
                {
                    Articulo detalle1 = (Articulo)searchLookUpEdit1View.GetFocusedRow();
                    Detalle_Ingreso detalle2 = (Detalle_Ingreso)dataListadoDetalle.GetFocusedRow();


                    int ExistenciaAnterior = detalle1.Existencia - detalle2.Stock_inicial;
                    decimal costoTotalExistencia = detalle1.Existencia * detalle1.PrecioVenta;
                    decimal costoTotalSegungaCompra2 = Convert.ToDecimal(txtStockInicial.Text) * Convert.ToDecimal(txtPrecioVenta.Text);
                    decimal costoTotalSegungaCompra = detalle2.Stock_inicial * detalle2.Precio_Venta;
                    decimal costoTotalPrimeraCompra = (costoTotalExistencia - costoTotalSegungaCompra);
                    decimal precioVentaAnterior = (costoTotalPrimeraCompra) / ExistenciaAnterior;
                    decimal costoTotalSegunda2Compra = costoTotalPrimeraCompra + costoTotalSegungaCompra2;
                    int NuevaExistencia = ExistenciaAnterior + Convert.ToInt32(txtStockInicial.Text);
                    decimal nuevoprecio = (costoTotalPrimeraCompra + costoTotalSegungaCompra2) / NuevaExistencia;

                    //int CExistencia = detalle.Existencia + int.Parse(txtStockInicial.Text);
                    //decimal costoTotalExistencia = detalle1.Existencia * detalle1.PrecioVenta;
                    //decimal costoTotalNuvaCompra = Convert.ToDecimal(txtStockInicial.Text) * Convert.ToDecimal(txtPrecioVenta.Text);
                    //decimal Calculo = (costoTotalExistencia + costoTotalNuvaCompra) / CExistencia;
                    if (detalle1.Existencia == 0)
                    {
                        detalle1.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                        detalle1.Existencia = int.Parse(txtStockInicial.Text);
                        unitOfWorkIngreso.CommitChanges();
                        xpCollectionArticulos.Reload();
                    }
                    else
                    {
                       
                        detalle1.Existencia = NuevaExistencia;
                        detalle1.PrecioVenta = nuevoprecio;

                        unitOfWorkIngreso.CommitChanges();
                        xpCollectionArticulos.Reload();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Mostrar()
        {

            this.lblTotal.Text = "Total de Registro: " + Convert.ToString(xpCollectionIngreso.Count);
            xpCollectionArticulos.Reload();
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

            gridControlDetalleIngreso.DataSource = null;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea elimino el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    Ingreso ingreos = (Ingreso)dataListado.GetFocusedRow();
                    ingreos.Delete();

                    unitOfWorkIngreso.CommitChanges();
                    xpCollectionIngreso.Reload();
                    MessageBox.Show("Se elimino correctamente el rejistro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El dato esta Siendo Ocupado", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            //lblTrabajador3.Text =$"Trabajador: {DatosDeAcceso.NombreTrabajador}";
            this.btnAgregar2.Text = "Agregar";
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
                    errorIcon.Clear();
                    MensajeError("Falta Ingresar algunos datos, seran Remarcados");
                    errorIcon.SetError(sbProveedor, "Seleccione el Proveedor");
                }
                else if (this.txtIGV.Text == string.Empty)
                {
                    this.txtIGV.Focus();
                    errorIcon.Clear();
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
                    if (this.IsNuevo==true)
                    {
                       // ingreso = new Ingreso(unitOfWorkIngreso);
                        Trabajador trabajador = (Trabajador)gridView1.GetFocusedRow();
                        Proveedor i = (Proveedor)searchLookUpEdit2View.GetFocusedRow();
                        
                        ingreso.IGV = Convert.ToDecimal(txtIGV.Text);

                        ingreso.IdTrabajador = trabajador;
                        ingreso.IdProveedor = i;
                        ingreso.Fecha_Ingreso = dtFechaIngreso.Value;
                        ingreso.Correlativo = txtCorrelativo.Text;
                        ingreso.Serie = txtSerie.Text;
                        ingreso.Tipo_Comprobante = cbComprobante.Text;
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
                    if (this.IsNuevo && ingreso != null)
                    {
                        decimal sub_Total = Convert.ToDecimal((txtStockInicial.Text)) * Convert.ToDecimal((txtPrecioCompra.Text));
                        Detalle_Ingreso detalleIngreso = new Detalle_Ingreso(unitOfWorkIngreso);
                        precio1();
                        detalleIngreso.IdArticulo = (Articulo)searchLookUpEdit1View.GetFocusedRow();
                        detalleIngreso.Stock_inicial = Convert.ToInt32(txtStockInicial.Text.Trim());
                        detalleIngreso.Precio_Compra = Convert.ToDecimal(txtPrecioCompra.Text.Trim());
                        detalleIngreso.Precio_Venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                        detalleIngreso.Sub_total = sub_Total;
                        detalleIngreso.Save();
                        xpCollectionDetalleIngreso.Reload();
                        ingreso.Detalle_Ingresos.Add(detalleIngreso);
                        this.MensajeOk("Articulo Adregado");

                        this.LimpiarDetalles();
                    }
                    else
                    {
                        if (this.IsEditar)
                        {
                            Detalle_Ingreso detalle = detalle_editar;
                            Articulo art = (Articulo)searchLookUpEdit1View.GetFocusedRow();
                            if (art != null)
                            {
                                detalle.IdArticulo = (Articulo)searchLookUpEdit1View.GetFocusedRow();
                            }
                            decimal sub_Total = Convert.ToDecimal((txtStockInicial.Text)) * Convert.ToDecimal((txtPrecioCompra.Text));

                            precio2();
                            detalle.Stock_inicial = Convert.ToInt32(txtStockInicial.Text.Trim());
                            detalle.Precio_Compra = Convert.ToDecimal(txtPrecioCompra.Text.Trim());
                            detalle.Precio_Venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                            detalle.Sub_total = sub_Total;
                            detalle.Save();
                            
                            //unitOfWorkIngreso.CommitChanges();
                            xpCollectionDetalleIngreso.Reload();
                            LimpiarDetalles();
                            this.MensajeOk("Se a Actualizo el Rejistro de Forma Correcta");

                            this.LimpiarDetalles();
                        }
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
            this.Habilitar(false);
            //this.Limpiar();
            this.Mostrar();
            this.Botones();
            tabControl1.SelectedIndex = 0;
            //this.IsNuevo = false;
            //this.IsEditar = false;
            //this.Botones();
            ////ingreso = null;
            //this.Limpiar();
            //this.Habilitar(false);
            //tabControl1.SelectedIndex = 0;
            //errorIcon.Clear();
            //ingreso.Delete();
            //unitOfWorkIngreso.CommitChanges();
           
        }

        private void sbTrabajador_EditValueChanged(object sender, EventArgs e)
        {
            //Trabajador trabajador = (Trabajador)gridView1.GetFocusedRow();
            //if (ingreso != null)
            //{
            //    ingreso.IdTrabajador = trabajador;
            //    ingreso.Save();
            //    string fecha = trabajador.Telefono;
            //    MensajeOk(fecha);
            //}
        }

        private void sbProveedor_EditValueChanged(object sender, EventArgs e)
        {
            //Proveedor i = (Proveedor)searchLookUpEdit2View.GetFocusedRow();
            //if (ingreso != null)
            //{
            //    ingreso.IdProveedor = i;
            //    ingreso.Save();
            //}
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Desea Eliminar el Rejistro", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    if (this.IsNuevo && ingreso != null)
                    {
                        Detalle_Ingreso di = (Detalle_Ingreso)dataListadoDetalle.GetFocusedRow();
                        di.Delete();
                        detalle_editar = (Detalle_Ingreso)dataListadoDetalle.GetFocusedRow();

                        this.Mostrar();
                    }
                    else
                    {
                        Detalle_Ingreso detalle = (Detalle_Ingreso)dataListadoDetalle.GetFocusedRow();
                        detalle.Delete();
                        unitOfWorkIngreso.CommitChanges();
                        xpCollectionDetalleIngreso.Reload();
                        MessageBox.Show("Se elimino correctamente el rejistro");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            ingreso_editar = (Ingreso)dataListado.GetFocusedRow();
            this.txtidIngresos.Text = ingreso_editar.IdIngreso.ToString();
            this.sbTrabajador.Text= (ingreso_editar.IdTrabajador).IdTrabajador.ToString();
            this.sbProveedor.Text= (ingreso_editar.IdProveedor).IdProveedor.ToString();
            this.dtFechaIngreso.Value = ingreso_editar.Fecha_Ingreso;
            this.txtIGV.Text = ingreso_editar.IGV.ToString();
            this.cbComprobante.Text = ingreso_editar.Tipo_Comprobante.ToString();
            this.txtSerie.Text = ingreso_editar.Serie.ToString();
            this.txtCorrelativo.Text = ingreso_editar.Correlativo.ToString();
            gridControlDetalleIngreso.DataSource = ingreso_editar.Detalle_Ingresos;
            this.sbTrabajador.Focus();
            this.btnAgregar2.Text = "Actualizar";
            this.IsNuevo = false;
            this.IsEditar = true;
            tabControl1.SelectedIndex = 1;
            this.Habilitar(true);

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

            Ingreso ingreso = ingreso_editar;
            Trabajador tra=(Trabajador)gridView1.GetFocusedRow();
            if (tra != null)
            {
                ingreso.IdTrabajador = (Trabajador)gridView1.GetFocusedRow();
            }
            Proveedor pro = (Proveedor)searchLookUpEdit2View.GetFocusedRow();
            if (pro != null)
            {
                ingreso.IdProveedor = (Proveedor)searchLookUpEdit2View.GetFocusedRow();
            }
              
            ingreso.Fecha_Ingreso = dtFechaIngreso.Value;
            ingreso.IGV = Convert.ToDecimal(txtIGV.Text);
            ingreso.Correlativo = txtCorrelativo.Text;
            ingreso.Serie = txtSerie.Text;
            ingreso.Tipo_Comprobante = cbComprobante.Text;

            ingreso.Save();
            unitOfWorkIngreso.CommitChanges();
            xpCollectionIngreso.Reload();
            Limpiar();
            this.MensajeOk("Se  Actualizo el Rejistro de Forma Correcta");
            this.Habilitar(false);
            tabControl1.SelectedIndex = 0;
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            errorIcon.Clear();
            this.Limpiar();
        }

        private void gridControlDetalleIngreso_DoubleClick(object sender, EventArgs e)
        {
            detalle_editar = (Detalle_Ingreso)dataListadoDetalle.GetFocusedRow();
            ingreso_editar = (Ingreso)dataListado.GetFocusedRow();
            this.txtIdDetalleIngreso.Text = detalle_editar.IdDetalle_Ingreso.ToString();
            this.txtidIngresos.Text = ingreso_editar.IdIngreso.ToString();
            this.sbArticulo.Text = (detalle_editar.IdArticulo).IdArticulos.ToString();
            this.txtStockInicial.Text = detalle_editar.Stock_inicial.ToString();
            this.txtPrecioCompra.Text = detalle_editar.Precio_Compra.ToString();
            this.txtPrecioVenta.Text = detalle_editar.Precio_Venta.ToString();

            
            this.sbArticulo.Focus();
        }

        private void btnImprimir1_Click(object sender, EventArgs e)
        {
            dataListado.ShowRibbonPrintPreview();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Articulo detalle1 = (Articulo)searchLookUpEdit1View.GetFocusedRow();
            Detalle_Ingreso detalle2 = (Detalle_Ingreso)dataListadoDetalle.GetFocusedRow();
            //int a1 = detalle1.Existencia + int.Parse(txtStockInicial.Text);
            ////Calculo de precio
            //decimal a2 = detalle1.Existencia * detalle1.PrecioVenta;
            //decimal b2 = Convert.ToDecimal(txtStockInicial.Text) * Convert.ToDecimal(txtPrecioVenta.Text);
            //decimal c2 = (a2 + b2) / a2;
            //MensajeOk($"Articulo {a2.ToString()}");
            //MensajeOk($"Formulario {b2.ToString()}");
            //MensajeOk($"existencia {a2.ToString()}");
            //MensajeOk($"calculo {c2.ToString()}");

           
            int ExistenciaAnterior = detalle1.Existencia - detalle2.Stock_inicial;
            decimal costoTotalExistencia = detalle1.Existencia * detalle1.PrecioVenta;
            decimal costoTotalSegungaCompra2 = Convert.ToDecimal(txtStockInicial.Text) * Convert.ToDecimal(txtPrecioVenta.Text);
            decimal costoTotalSegungaCompra = detalle2.Stock_inicial * detalle2.Precio_Venta;
            decimal costoTotalPrimeraCompra = (costoTotalExistencia - costoTotalSegungaCompra); 
            decimal precioVentaAnterior = (costoTotalPrimeraCompra) / ExistenciaAnterior;
            decimal costoTotalSegunda2Compra = costoTotalPrimeraCompra + costoTotalSegungaCompra2;
            int NuevaExistencia = ExistenciaAnterior + Convert.ToInt32(txtStockInicial.Text);
            decimal nuevoprecio = (costoTotalPrimeraCompra + costoTotalSegungaCompra2)/ NuevaExistencia;

            MensajeOk($" precio Venta Anterior {precioVentaAnterior}");
            MensajeOk($"Mi primera Existencia {ExistenciaAnterior}");
            MensajeOk($" venta total de mi primer ingreso {costoTotalPrimeraCompra}");

            MensajeOk($" venta total de mi segundo ingreso {costoTotalSegungaCompra2}");
            MensajeOk($"la suma de mi primer ingreso y segundo {costoTotalSegunda2Compra}");
            MensajeOk($"Nueva existencia {NuevaExistencia}");
            MensajeOk($"Nuevo Precio {nuevoprecio}");

            // MensajeOk($" venta total de mi primer ingreso {costoTotalPrimeraCompra}");

            //detalle1.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            //if (detalle1.Existencia == 0)
            //{
            //    detalle1.Existencia = int.Parse(txtStockInicial.Text);
            //    detalle1.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
            //    unitOfWorkIngreso.CommitChanges();
            //    xpCollectionArticulos.Reload();
            //}
            //else
            //{
            //    detalle1.Existencia = CExistencia;
            //    detalle1.PrecioVenta = Calculo;
            //    unitOfWorkIngreso.CommitChanges();
            //    xpCollectionArticulos.Reload();
            //}

            //decimal costoTotalNuevo = decimal.Parse(txtPrecioVenta.Text) * decimal.Parse(txtStockInicial.Text); //detalle2.Precio_Venta * detalle2.Stock_inicial;
            //decimal b = detalle1.PrecioVenta * detalle1.Existencia;
            //"Existencia Anterior" ==== decimal d = detalle1.Existencia - detalle2.Stock_inicial;//int.Parse(txtStockInicial.Text);

            //decimal f = (precioVentaAnterior / CExistenciaAnterior);

            ////decimal precioAnterior = detalle1.PrecioVenta * existenciaAnterior;
            //MensajeOk($"precio Anterior {precioVentaAnterior.ToString()}");
            //MensajeOk($"detalle {costoTotalNuvaCompra.ToString()}");
            ////MensajeOk($"Articulo Costo Total Anterior {b.ToString()}");

            //MensajeOk($"Existencia Anterior {CExistenciaAnterior.ToString()}");
            //MensajeOk($" {Calculo.ToString()}");
            //MensajeOk($" {costoTotalExistencia.ToString()}");
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == string.Empty)
            {
                txtPrecioVenta.Text = "0";
            }
            else
            {
                txtPrecioVenta.Text = (int.Parse(txtPrecioCompra.Text) + (((int.Parse(txtPrecioCompra.Text) * 25) / 100))).ToString();
            }
        }
    }
}
