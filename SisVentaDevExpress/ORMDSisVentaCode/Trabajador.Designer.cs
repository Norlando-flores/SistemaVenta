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

    [Persistent(@"trabajador")]
    public partial class Trabajador : XPLiteObject
    {
        int fIdTrabajador;
        [Key(true)]
        [Persistent(@"idTrabajador")]
        public int IdTrabajador
        {
            get { return fIdTrabajador; }
            set { SetPropertyValue<int>(nameof(IdTrabajador), ref fIdTrabajador, value); }
        }
        string fNombre;
        [Size(30)]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fApellidos;
        [Size(50)]
        public string Apellidos
        {
            get { return fApellidos; }
            set { SetPropertyValue<string>(nameof(Apellidos), ref fApellidos, value); }
        }
        string fSexo;
        [Size(50)]
        public string Sexo
        {
            get { return fSexo; }
            set { SetPropertyValue<string>(nameof(Sexo), ref fSexo, value); }
        }
        DateTime fFecha_Nacimiento;
        public DateTime Fecha_Nacimiento
        {
            get { return fFecha_Nacimiento; }
            set { SetPropertyValue<DateTime>(nameof(Fecha_Nacimiento), ref fFecha_Nacimiento, value); }
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
        string fAcceso;
        [Size(50)]
        public string Acceso
        {
            get { return fAcceso; }
            set { SetPropertyValue<string>(nameof(Acceso), ref fAcceso, value); }
        }
        string fUsuario;
        [Size(50)]
        public string Usuario
        {
            get { return fUsuario; }
            set { SetPropertyValue<string>(nameof(Usuario), ref fUsuario, value); }
        }
        string fContraseña;
        [Size(50)]
        public string Contraseña
        {
            get { return fContraseña; }
            set { SetPropertyValue<string>(nameof(Contraseña), ref fContraseña, value); }
        }
        string fCedula;
        [Size(30)]
        public string Cedula
        {
            get { return fCedula; }
            set { SetPropertyValue<string>(nameof(Cedula), ref fCedula, value); }
        }
        [Association(@"IngresoReferencesTrabajador")]
        public XPCollection<Ingreso> Ingresoes { get { return GetCollection<Ingreso>(nameof(Ingresoes)); } }
    }

}
