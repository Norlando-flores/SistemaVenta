using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SisVentaDevExpress.Reportes
{
    public partial class ReporteArticulo : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteArticulo()
        {
            InitializeComponent();
        }

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel2.Text= DateTime.Now.ToString();
        }
    }
}
