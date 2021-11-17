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

    [Persistent(@"detalle_Ingreso")]
    public partial class Detalle_Ingreso : XPLiteObject
    {
        int fIdDetalle_Ingreso;
        [Key(true)]
        [Persistent(@"idDetalle_Ingreso")]
        public int IdDetalle_Ingreso
        {
            get { return fIdDetalle_Ingreso; }
            set { SetPropertyValue<int>(nameof(IdDetalle_Ingreso), ref fIdDetalle_Ingreso, value); }
        }
        Ingreso fIdIngreso;
        [Persistent(@"idIngreso")]
        [Association(@"Detalle_IngresoReferencesIngreso")]
        public Ingreso IdIngreso
        {
            get { return fIdIngreso; }
            set { SetPropertyValue<Ingreso>(nameof(IdIngreso), ref fIdIngreso, value); }
        }
        Articulo fIdArticulo;
        [Indexed(Name = @"iidArticulo_detalle_Ingreso")]
        [Persistent(@"idArticulo")]
        [Association(@"Detalle_IngresoReferencesArticulo")]
        public Articulo IdArticulo
        {
            get { return fIdArticulo; }
            set { SetPropertyValue<Articulo>(nameof(IdArticulo), ref fIdArticulo, value); }
        }
        decimal fPrecio_Compra;
        public decimal Precio_Compra
        {
            get { return fPrecio_Compra; }
            set { SetPropertyValue<decimal>(nameof(Precio_Compra), ref fPrecio_Compra, value); }
        }
        decimal fPrecio_Venta;
        public decimal Precio_Venta
        {
            get { return fPrecio_Venta; }
            set { SetPropertyValue<decimal>(nameof(Precio_Venta), ref fPrecio_Venta, value); }
        }
        int fStock_inicial;
        [Persistent(@"stock_inicial")]
        public int Stock_inicial
        {
            get { return fStock_inicial; }
            set { SetPropertyValue<int>(nameof(Stock_inicial), ref fStock_inicial, value); }
        }
        decimal fSub_total;
        [Persistent(@"sub_total")]
        public decimal Sub_total
        {
            get { return fSub_total; }
            set { SetPropertyValue<decimal>(nameof(Sub_total), ref fSub_total, value); }
        }
    }

}
