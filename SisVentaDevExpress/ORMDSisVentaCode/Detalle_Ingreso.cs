using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SisVentaDevExpress.Ventas
{

    public partial class Detalle_Ingreso
    {
        public Detalle_Ingreso(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
