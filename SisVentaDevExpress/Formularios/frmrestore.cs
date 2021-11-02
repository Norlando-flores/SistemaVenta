using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLBackup;
using System.Data.SqlClient;
using AppLotificadora.Formularios;
using System.IO;

namespace AppLotificadora.Formularios
{
    public partial class frmrestore : Form
    {
        public frmrestore()
        {
            InitializeComponent();
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

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            //SqlBackup mb = new SqlBackup(cmd);

            //cmd.Connection = conn;
            //conn.Open();
            ////mb.();
            //conn.Close();
            //MessageBox.Show("hola");



        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //respaldo();
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //string constring = "server=localhost;user=root;pwd=root;database=;";

            //// Important Additional Connection Options
            //constring += "charset=utf8;convertzerodatetime=true;";
            //OpenFileDialog open = new OpenFileDialog();
            //open.Title = "Restauracion de base de datos";
            //// open.Filter = "Respaldo SQL|*.sql";
            //if (open.ShowDialog() == DialogResult.Cancel)
            //{
            //    return;
            //}
            ////  MessageBox.Show(open.FileName);
            //using (MySqlConnection conn = new MySqlConnection(constring))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand())
            //    {
            //        using (MySqlBackup mb = new MySqlBackup(cmd))
            //        {
            //            cmd.Connection = conn;
            //            conn.Open();
            //            mb.ImportFromFile(open.FileName);
            //            conn.Close();
            //            MessageBox.Show("Restauracion  realizada correctamente");
            //        }
            //    }
            //}
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


      
    }
}
