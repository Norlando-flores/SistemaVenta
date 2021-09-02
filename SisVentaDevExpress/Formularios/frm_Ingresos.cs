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
    public partial class frm_Ingresos : Form
    {
        public int IdTrabajador;
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private decimal TotalPagado = 0;
        public frm_Ingresos()
        {
            InitializeComponent();
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
            this.sbProveedor.Text = string.Empty;
            this.lblTotalP.Text = "0,0";
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
            this.sbProveedor.Enabled = valor;
            this.cbComprobante.Enabled = valor;
            this.dtFechaIngreso.Enabled = valor;

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

        private void frm_Ingresos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }
    }
}
