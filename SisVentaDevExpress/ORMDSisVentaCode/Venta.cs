﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SisVentaDevExpress.Ventas
{

    public partial class Venta
    {
        public Venta(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
