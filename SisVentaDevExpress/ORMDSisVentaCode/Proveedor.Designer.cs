//------------------------------------------------------------------------------
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

    [Persistent(@"proveedor")]
    public partial class Proveedor : XPLiteObject
    {
        int fIdProveedor;
        [Key(true)]
        [Persistent(@"idProveedor")]
        public int IdProveedor
        {
            get { return fIdProveedor; }
            set { SetPropertyValue<int>(nameof(IdProveedor), ref fIdProveedor, value); }
        }
        string fRazon_Social;
        [Size(150)]
        public string Razon_Social
        {
            get { return fRazon_Social; }
            set { SetPropertyValue<string>(nameof(Razon_Social), ref fRazon_Social, value); }
        }
        string fSector_Comercial;
        [Size(50)]
        public string Sector_Comercial
        {
            get { return fSector_Comercial; }
            set { SetPropertyValue<string>(nameof(Sector_Comercial), ref fSector_Comercial, value); }
        }
        string fTipo_Documento;
        [Size(20)]
        public string Tipo_Documento
        {
            get { return fTipo_Documento; }
            set { SetPropertyValue<string>(nameof(Tipo_Documento), ref fTipo_Documento, value); }
        }
        string fNum_Documento;
        [Size(25)]
        public string Num_Documento
        {
            get { return fNum_Documento; }
            set { SetPropertyValue<string>(nameof(Num_Documento), ref fNum_Documento, value); }
        }
        string fDireccion;
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
        string fTelefono;
        [Size(20)]
        public string Telefono
        {
            get { return fTelefono; }
            set { SetPropertyValue<string>(nameof(Telefono), ref fTelefono, value); }
        }
        string fEmail;
        [Size(50)]
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fURL;
        [Size(150)]
        public string URL
        {
            get { return fURL; }
            set { SetPropertyValue<string>(nameof(URL), ref fURL, value); }
        }
        [Association(@"IngresoReferencesProveedor")]
        public XPCollection<Ingreso> Ingresoes { get { return GetCollection<Ingreso>(nameof(Ingresoes)); } }
    }

}
