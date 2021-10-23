using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SisVentaDevExpress.Reportes
{
    public partial class reporteVenta : DevExpress.XtraReports.UI.XtraReport
    {
        public reporteVenta()
        {
            InitializeComponent();
        }

        public void intData(int idVenta,string tipoComprovante, string serie, string correlativo, DateTime fecha,string Cliente,string tipoDocumento,string numeroDocumento,string direccion,string telefono)
        {
            xpCollectionDetalleVenta.Filter = CriteriaOperator.Parse("[IdVenta.IdVenta] = ?", idVenta);
            pTipoComprovante.Value = tipoComprovante;
            pSerie.Value = serie;
            pCorrelativo.Value = correlativo;
            pFecha.Value = fecha;
            pCliente.Value = Cliente;
            pDireccion.Value = direccion;
            pTipoDocumento.Value = tipoDocumento;
            pNumeroDocumento.Value = numeroDocumento;
            pTelefono.Value = telefono;
        }

    }
}
