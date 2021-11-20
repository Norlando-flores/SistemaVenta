using System;
using SisVentaDevExpress.Clases;
using SisVentaDevExpress.Ventas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisVentaDevExpress.Reportes;
using System.Data.SqlClient;

namespace SisVentaDevExpress.Formularios
{
    public partial class frm_Principal : Form
    {
        private int childFormNumber = 0;
        private string acceso;


        public frm_Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria formulario_Categoria = new frmCategoria();
            formulario_Categoria.MdiParent = this;
            formulario_Categoria.Show();
            formulario_Categoria.WindowState = FormWindowState.Maximized;
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Presentacion formulario_Presentacion = new frm_Presentacion();
            formulario_Presentacion.MdiParent = this;
            formulario_Presentacion.Show();
            formulario_Presentacion.WindowState = FormWindowState.Maximized;
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Articulos formulario_Articulos = new frm_Articulos();
            formulario_Articulos.MdiParent = this;
            formulario_Articulos.Show();
            formulario_Articulos.WindowState = FormWindowState.Maximized;
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Proveedor formulario_Proveedor = new frm_Proveedor();
            formulario_Proveedor.MdiParent = this;
            formulario_Proveedor.Show();
            formulario_Proveedor.WindowState = FormWindowState.Maximized;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cliente formulario_Clientes = new frm_Cliente();
            formulario_Clientes.MdiParent = this;
            formulario_Clientes.Show();
            formulario_Clientes.WindowState = FormWindowState.Maximized;
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Trabajador formulario_Trabajador = new frm_Trabajador();
            formulario_Trabajador.MdiParent = this;
            formulario_Trabajador.Show();
            formulario_Trabajador.WindowState = FormWindowState.Maximized;
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            xpCollectionAcceso.Reload();
            this.GestionAcceso();
        }
        public void GestionAcceso()
        {
            acceso = DatosDeAcceso.acceso;
            foreach (Trabajador trabajador in xpCollectionAcceso)
            {
                if (acceso == "Administrador")
                {
                    this.MenuAlmacen.Enabled = true;
                    this.MenuCompra.Enabled = true;
                    this.MenuVentas.Enabled = true;
                    this.MenuMantenimiento.Enabled = true;
                    this.MenuReportes.Enabled = true;
                    respaldoRestauracionToolStripMenuItem.Enabled = true;
                    // this.MenuHerramientas.Enabled = true;
                    //this.tsCompras.Enabled = true;
                    // this.tsVentas.Enabled = true;
                }
                else if (acceso == "Vendedor")
                {
                    this.MenuAlmacen.Enabled = false;
                    this.MenuCompra.Enabled = false;
                    this.MenuVentas.Enabled = true;
                    this.MenuMantenimiento.Enabled = false;
                    this.MenuReportes.Enabled = true;
                    this.existeciasDeArticulosToolStripMenuItem.Enabled = false;
                    this.compraNecesariasToolStripMenuItem.Enabled = false;
                    this.respaldoRestauracionToolStripMenuItem.Enabled = false;
                    // this.MenuHerramientas.Enabled = true;
                    //this.tsCompras.Enabled = false;
                    // this.tsVentas.Enabled = true;
                }
                else if (acceso == "Almasenero")
                {
                    this.MenuAlmacen.Enabled = true;
                    this.MenuCompra.Enabled = true;
                    this.MenuVentas.Enabled = false;
                    this.MenuMantenimiento.Enabled = false;
                    this.MenuReportes.Enabled = true;
                    this.compraNecesariasToolStripMenuItem.Enabled = true;
                    this.existeciasDeArticulosToolStripMenuItem.Enabled = false;
                    this.respaldoRestauracionToolStripMenuItem.Enabled = false;
                    //this.MenuHerramientas.Enabled = true;
                    //this.tsCompras.Enabled = true;
                    //this.tsVentas.Enabled = false;
                }
                else
                {
                    this.MenuAlmacen.Enabled = false;
                    this.MenuCompra.Enabled = false;
                    this.MenuVentas.Enabled = false;
                    this.MenuMantenimiento.Enabled = false;
                    this.MenuReportes.Enabled = false;
                    this.compraNecesariasToolStripMenuItem.Enabled = false;
                    this.existeciasDeArticulosToolStripMenuItem.Enabled = false;
                    this.respaldoRestauracionToolStripMenuItem.Enabled = false;
                    //this.MenuHerramientas.Enabled = false;
                    // this.tsCompras.Enabled = false;
                    //this.tsVentas.Enabled = false;
                }
            }
        }

        private void bolverAlLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_acceso a = new frm_acceso();
            a.Show();
            this.Close();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ingresos formulario_Ingreso = new frm_Ingresos();
            formulario_Ingreso.MdiParent = this;
            formulario_Ingreso.Show();
            formulario_Ingreso.WindowState = FormWindowState.Maximized;
        }

        private void detalleDeArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DetalleIngreso formulario_Articulos = new frm_DetalleIngreso();
            formulario_Articulos.MdiParent = this;
            formulario_Articulos.Show();
            formulario_Articulos.WindowState = FormWindowState.Maximized;
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Venta formulario_Venta = new frm_Venta();
            formulario_Venta.MdiParent = this;
            formulario_Venta.Show();
            formulario_Venta.WindowState = FormWindowState.Maximized;
        }

        private void existeciasDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteArticulos formularioArticulo = new frmReporteArticulos();
            //formularioArticulo.MdiParent = this;
            formularioArticulo.Show();
            formularioArticulo.WindowState = FormWindowState.Maximized;
        }

        private void compraNecesariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenCompra comprasNecesarias = new frmOrdenCompra();
            //formularioArticulo.MdiParent = this;
            comprasNecesarias.Show();
            comprasNecesarias.WindowState = FormWindowState.Maximized;
        }

        private void copiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Realizando respaldo de Base de datos ";
            save.Filter = "Respaldo SQL|*.bak";
            save.FileName = "Respaldo-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

            if (save.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            
            respaldo(save.FileName);
            MessageBox.Show("Respaldo realizado correctamente");
        }
        private void respaldo(string ruta)
        {


            //string nombre = "Respaldo-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

            string constring = "Data Source=NORLANDO_FLORES\\SQLEXPRESS;Initial Catalog=Ventas;Integrated Security=True";
            string comando_consulta = $"BACKUP DATABASE [Ventas] TO  DISK = N'{ruta}' WITH NOFORMAT, NOINIT,  NAME = N'Ventas-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            //string file = ruta;

            SqlConnection conn = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand(comando_consulta, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si desea hacer otra copia de seguridad cierre el formulario e intente nuevamente ");
                return ;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                
            }
        }
        private void restauracion(string ruta)
        {


            //string nombre = "Respaldo-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

            string constring = "Data Source=NORLANDO_FLORES\\SQLEXPRESS;Initial Catalog=Ventas;Integrated Security=True";
            string comando_consulta = $"USE[master] ALTER DATABASE[Ventas] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE[Ventas] FROM DISK = N'{ruta}' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5 ALTER DATABASE[Ventas] SET MULTI_USER";
            //string file = ruta;

            SqlConnection conn = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand(comando_consulta, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si desea restaurar cierre el formulario e intente nuevamente");
                return;
            }
            finally
            {
                conn.Close();
                conn.Dispose();

            }
        }

        private void restauracionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Realizando respaldo de Base de datos ";
            save.Filter = "Respaldo SQL|*.bak";
            save.FileName = "Respaldo-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

            if (save.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            restauracion(save.FileName);
            MessageBox.Show("Restauracion realizada correctamente");
        }
    }
}





