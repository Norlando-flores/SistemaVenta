using System;
using SisVentaDevExpress.Ventas;
using SisVentaDevExpress.Clases;
using SisVentaDevExpress.Formularios;
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
    public partial class frm_DetalleIngreso : Form
    {
        Detalle_Ingreso octenerDetalle = null;
        public string Articulo;
        public frm_DetalleIngreso()
        {
            InitializeComponent();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
           // frm_Venta e = new frm_Venta();
            frm_Venta t = new frm_Venta();
            octenerDetalle = (Detalle_Ingreso)dataListado.GetFocusedRow();
            this.Close();
        }

        private void frm_DetalleIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}
