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
    public partial class GastosFijos : Form
    {
        private string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["bdContext"].ConnectionString;
        public GastosFijos()
        {
            InitializeComponent();
            recargarGastos();
        }

        private void recargarGastos()
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

                        tblGastosFijos.Rows.Clear();
                        tblGastosFijos.Columns.Clear();
                        tblGastosFijos.Columns.Add("cod_gasto_fijo", "Codigo");
                        tblGastosFijos.Columns[0].Visible = false;
                        tblGastosFijos.Columns.Add("nombre_gasto", "Nombre");
                        tblGastosFijos.Columns.Add("valor_gasto", "Valor");

                        if (bd.Gastos_fijos.Count() != 0)
                        {

                            int codEscenario = bd.Escenarios.OrderByDescending(e => e.cod_escenario).First().cod_escenario;
                            //codigoEscenario = codEscenario;
                            var gastos = bd.Gastos_fijos.Where(gf => gf.cod_escenario == codEscenario).ToList();

                            foreach (var item in gastos)
                            {
                                tblGastosFijos.Rows.Add(item.cod_gasto_fijo, item.nombre_gasto, item.valor_gasto);
                            }

                        }

                        transaccion.Commit();
                    }
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                    this.Close();
                }
            }
        }

        private void btnCrearGasto_Click(object sender, EventArgs e)
        {
            CrearGasto formCrearGasto = new CrearGasto();
            formCrearGasto.Show();
            formCrearGasto.FormClosed += new FormClosedEventHandler(cierreCrearGasto);
        }

        void cierreCrearGasto(object sender, FormClosedEventArgs e)
        {
            recargarGastos();
        }

        private void btnEditarGasto_Click(object sender, EventArgs e)
        {
            if (tblGastosFijos.CurrentRow != null && tblGastosFijos.CurrentRow.Index < tblGastosFijos.Rows.Count-1)
            {
                EditarGasto formEditarGasto = new EditarGasto(int.Parse(tblGastosFijos.CurrentRow.Cells[0].Value.ToString()));
                formEditarGasto.Show();
                formEditarGasto.FormClosed += new FormClosedEventHandler(cierreEditarGasto);
            }
        }

        void cierreEditarGasto(object sender, FormClosedEventArgs e)
        {
            recargarGastos();
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            if (tblGastosFijos.CurrentRow != null && tblGastosFijos.CurrentRow.Index < tblGastosFijos.Rows.Count - 1)
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

                            int codigoGastoFijo = int.Parse(tblGastosFijos.CurrentRow.Cells[0].Value.ToString());

                            var item = bd.Gastos_fijos.Find(codigoGastoFijo);

                            bd.Gastos_fijos.Remove(item);
                            bd.SaveChanges();
                        }

                        transaccion.Commit();
                        recargarGastos();
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                    }
                }
            }
        }

        private void btnRecargarGastos_Click(object sender, EventArgs e)
        {
            recargarGastos();
        }


    }
}
