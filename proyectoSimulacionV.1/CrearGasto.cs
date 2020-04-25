using MySql.Data.MySqlClient;
using proyectoSimulacionV._1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoSimulacionV._1
{
    public partial class CrearGasto : Form
    {
        private string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["bdContext"].ConnectionString;
        public CrearGasto()
        {
            InitializeComponent();
        }

        private void btnGuardarGasto_Click(object sender, EventArgs e)
        {
            if (txtNombreGasto.Text.Replace(" ", "").Length != 0)
            {
                using (MySqlConnection conexion = new MySqlConnection(conStr))
                {
                    conexion.Open();
                    MySqlTransaction transaccion = conexion.BeginTransaction();
                    try
                    {
                        using (var bd = new bdContext(conexion, false))
                        {
                            bd.Database.UseTransaction(transaccion);
                            int codEscenario = bd.Escenarios.OrderByDescending(es => es.cod_escenario).First().cod_escenario;
                            bd.Gastos_fijos.Add(new Gasto_fijo()
                            {
                                nombre_gasto = txtNombreGasto.Text,
                                valor_gasto = (double)txtCantidadGasto.Value,
                                cod_escenario = codEscenario
                            });
                            bd.SaveChanges();
                        }

                        transaccion.Commit();
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fallo en la creacion del registro. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transaccion.Rollback();
                        this.Close();
                    }

                }
            }
        }
    }
}
