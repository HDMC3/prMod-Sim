using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoSimulacionV._1.Modelos;

namespace proyectoSimulacionV._1
{
    public partial class EditarGasto : Form
    {
        private string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["bdContext"].ConnectionString;
        private int codigoGasto;
        public EditarGasto(int codGasto)
        {
            InitializeComponent();
            this.codigoGasto = codGasto;
            using (MySqlConnection conexion = new MySqlConnection(conStr))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    using (var bd = new bdContext(conexion, false))
                    {
                        bd.Database.UseTransaction(transaccion);

                        var item = bd.Gastos_fijos.Find(codGasto);
                        txtNombreGasto.Text = item.nombre_gasto;
                        txtCantidadGasto.Value = (decimal)item.valor_gasto;
                    }
                    transaccion.Commit();
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al obtener los datos. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnGuardarGasto_Click(object sender, EventArgs e)
        {
            if (txtNombreGasto.Text.Replace(" ","").Length != 0)
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
                            var item = new Gasto_fijo()
                            {
                                cod_gasto_fijo = codigoGasto,
                                nombre_gasto = txtNombreGasto.Text,
                                valor_gasto = (double)txtCantidadGasto.Value,
                                cod_escenario = codEscenario
                            };

                            bd.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();
                        }

                        transaccion.Commit();
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al guardar el registro. Intente de nuevo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaccion.Rollback();
                        this.Close();
                    }
                }
            }
        }
    }
}
