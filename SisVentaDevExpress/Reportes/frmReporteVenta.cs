using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports;
using DevExpress.XtraPrinting;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using SisVentaDevExpress.Reportes;
using System.Windows.Forms;
using SisVentaDevExpress.Ventas;

namespace SisVentaDevExpress.Formularios
{
    public partial class frmReporteVenta : Form
    {
        public frmReporteVenta()
        {
            InitializeComponent();
        }

        private void frmReporteVenta_Load(object sender, EventArgs e)
        {

        }

        public void printInvoice(Venta v)
        {
            reporteVenta report = new reporteVenta();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)           
                p.Visible = false;
            report.intData(v.IdVenta, v.Tipo_Comprobante, v.Serie, v.NDocumento, v.Fecha, v.IdCliente.NombreCompleto,v.IdCliente.Tipo_Documento,v.IdCliente.Num_Documento,v.IdCliente.Direccion,v.IdCliente.Telefono);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
            
        }
    }
}
