﻿using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using SisVentaDevExpress.Formularios;
using SisVentaDevExpress.Ventas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SisVentaDevExpress
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
                 ConnectionHelper.ConnectionString,
                 AutoCreateOption.DatabaseAndSchema);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Trabajador());
        }
    }
}
