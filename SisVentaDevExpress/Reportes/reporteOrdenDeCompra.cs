using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using SisVentaDevExpress.Ventas;

namespace SisVentaDevExpress.Reportes
{
    public partial class reporteOrdenDeCompra : DevExpress.XtraReports.UI.XtraReport
    {
        public reporteOrdenDeCompra()
        {
            InitializeComponent();

            BinaryOperator filterCriteria = new BinaryOperator(nameof(Articulo.Existencia), 4, BinaryOperatorType.Less);
            xpCollectionOrdenCompra.Filter = filterCriteria;
        }

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel2.Text = DateTime.Now.ToString();
        }
    }
}
