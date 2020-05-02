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
    public partial class DetalleHora : Form
    {
        private string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["bdContext"].ConnectionString;
        public DetalleHora(int codigoHora)
        {
            InitializeComponent();
            using (MySqlConnection conexion = new MySqlConnection(conStr))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    using (var bd = new bdContext(conexion, false))
                    {
                        bd.Database.UseTransaction(transaccion);

                        var clientes = bd.Clientes.Where(c => c.cod_hora == codigoHora).ToList();

                        tblClientes.Rows.Clear();
                        tblClientes.Columns.Clear();

                        tblClientes.Columns.Add("cod_cliente", "Codigo");
                        tblClientes.Columns[0].Visible = false;
                        tblClientes.Columns.Add("nombre", "Nombre");
                        tblClientes.Columns.Add("tiempo_servicio", "Tiempo de servicio");

                        foreach (var item in clientes)
                        {
                            tblClientes.Rows.Add(item.cod_cliente, item.nombre, item.tiempo_servicio);
                        }
                    }

                    transaccion.Commit();
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al cargar los datos. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void tblClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblClientes.CurrentRow != null && tblClientes.CurrentRow.Index < tblClientes.Rows.Count)
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

                            int codigoCliente = int.Parse(tblClientes.Rows[e.RowIndex].Cells[0].Value.ToString());

                            var productosCliente = bd.Detalles_venta.Where(dv => dv.cod_cliente == codigoCliente).Select(a => new
                            {
                                cod_detalle_venta = a.cod_detalle_venta,
                                nom_producto = a.producto_simulacion.producto.nom_producto,
                                precio_compra = a.producto_simulacion.precio_compra,
                                precio_venta = a.producto_simulacion.precio_venta,
                                tiempo_preparacion = a.producto_simulacion.tiempo_preparacion,
                                stock = a.producto_simulacion.stock
                            });

                            tblProductosCliente.Rows.Clear();
                            tblProductosCliente.Columns.Clear();

                            tblProductosCliente.Columns.Add("cod_detalle_venta", "Codigo");
                            tblProductosCliente.Columns[0].Visible = false;
                            tblProductosCliente.Columns.Add("nom_producto", "Nombre");
                            tblProductosCliente.Columns.Add("precio_compra", "Precio costo");
                            tblProductosCliente.Columns.Add("precio_venta", "Precio venta");
                            tblProductosCliente.Columns.Add("tiempo_preparacion", "Tiempo preparacion");
                            tblProductosCliente.Columns.Add("stock", "Cantidad disponible");

                            foreach (var item in productosCliente)
                            {
                                tblProductosCliente.Rows.Add(item.cod_detalle_venta, item.nom_producto, item.precio_compra, item.precio_venta, item.tiempo_preparacion, item.stock);
                            }
                        }

                        transaccion.Commit();
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Error al cargar los datos. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
