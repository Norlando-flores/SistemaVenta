using DevExpress.Xpo;
using System;
namespace SisVentaDevExpress.Ventas
{

    public partial class Trabajador
    {
        public Trabajador(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellidos;
            }
        }
    }

}
