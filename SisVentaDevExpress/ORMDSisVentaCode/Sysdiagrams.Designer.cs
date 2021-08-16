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

    [Persistent(@"sysdiagrams")]
    public partial class Sysdiagrams : XPLiteObject
    {
        string fName;
        [Size(128)]
        [Persistent(@"name")]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        int fPrincipal_id;
        [Indexed(@"Name", Name = @"UK_principal_name", Unique = true)]
        [Persistent(@"principal_id")]
        public int Principal_id
        {
            get { return fPrincipal_id; }
            set { SetPropertyValue<int>(nameof(Principal_id), ref fPrincipal_id, value); }
        }
        int fDiagram_id;
        [Key(true)]
        [Persistent(@"diagram_id")]
        public int Diagram_id
        {
            get { return fDiagram_id; }
            set { SetPropertyValue<int>(nameof(Diagram_id), ref fDiagram_id, value); }
        }
        int fVersion;
        [Persistent(@"version")]
        public int Version
        {
            get { return fVersion; }
            set { SetPropertyValue<int>(nameof(Version), ref fVersion, value); }
        }
        byte[] fDefinition;
        [Size(SizeAttribute.Unlimited)]
        [Persistent(@"definition")]
        [MemberDesignTimeVisibility(true)]
        public byte[] Definition
        {
            get { return fDefinition; }
            set { SetPropertyValue<byte[]>(nameof(Definition), ref fDefinition, value); }
        }
    }

}
