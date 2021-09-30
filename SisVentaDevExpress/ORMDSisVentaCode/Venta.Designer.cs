﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SisVentaDevExpress.Ventas
{

    [Persistent(@"venta")]
    public partial class Venta : XPLiteObject
    {
        int fIdVenta;
        [Key(true)]
        [Persistent(@"idVenta")]
        public int IdVenta
        {
            get { return fIdVenta; }
            set { SetPropertyValue<int>(nameof(IdVenta), ref fIdVenta, value); }
        }
        Cliente fIdCliente;
        [Persistent(@"idCliente")]
        [Association(@"VentaReferencesCliente")]
        public Cliente IdCliente
        {
            get { return fIdCliente; }
            set { SetPropertyValue<Cliente>(nameof(IdCliente), ref fIdCliente, value); }
        }
        Trabajador fIdTrabajador;
        [Indexed(Name = @"iidTrabajador_venta")]
        [Persistent(@"idTrabajador")]
        public Trabajador IdTrabajador
        {
            get { return fIdTrabajador; }
            set { SetPropertyValue<Trabajador>(nameof(IdTrabajador), ref fIdTrabajador, value); }
        }
        DateTime fFecha;
        public DateTime Fecha
        {
            get { return fFecha; }
            set { SetPropertyValue<DateTime>(nameof(Fecha), ref fFecha, value); }
        }
        string fTipo_Comprobante;
        [Size(50)]
        public string Tipo_Comprobante
        {
            get { return fTipo_Comprobante; }
            set { SetPropertyValue<string>(nameof(Tipo_Comprobante), ref fTipo_Comprobante, value); }
        }
        string fSerie;
        [Size(10)]
        public string Serie
        {
            get { return fSerie; }
            set { SetPropertyValue<string>(nameof(Serie), ref fSerie, value); }
        }
        string fCorrelativo;
        [Size(10)]
        public string Correlativo
        {
            get { return fCorrelativo; }
            set { SetPropertyValue<string>(nameof(Correlativo), ref fCorrelativo, value); }
        }
        decimal fIGV;
        public decimal IGV
        {
            get { return fIGV; }
            set { SetPropertyValue<decimal>(nameof(IGV), ref fIGV, value); }
        }
        [Association(@"Detalle_ventaReferencesVenta")]
        public XPCollection<Detalle_venta> Detalle_ventas { get { return GetCollection<Detalle_venta>(nameof(Detalle_ventas)); } }
    }

}
