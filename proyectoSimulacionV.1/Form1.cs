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
using System.Numerics;

namespace proyectoSimulacionV._1
{
    public partial class Form1 : Form
    {
        private LogicaSimulacion simulacion;
        private int currentRowIndexProductos;
        private int currentRowIndexTiposProducto;
        private int cantEscenarios;
        private string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["bdContext"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            tblProductos.ReadOnly = true;
            tblTiposProducto.ReadOnly = true;
            recargarProductos();
            btnEditarProducto.Enabled = tblProductos.Rows.Count > 1;
            btnHabDeshabProducto.Enabled = tblProductos.Rows.Count > 1;
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                recargarProductos();
                btnEditarProducto.Enabled = tblProductos.Rows.Count > 1;
                btnHabDeshabProducto.Enabled = tblProductos.Rows.Count > 1;
            }
            else if (e.TabPageIndex == 1)
            {
                recargarTiposProductos();
                btnEditarTipoProducto.Enabled = tblTiposProducto.Rows.Count > 1;
                btnHabDeshabTipoProducto.Enabled = tblTiposProducto.Rows.Count > 1;
            }else if (e.TabPageIndex == 2)
            {
                //if (simulacion != null) recargarDatosSimulacion();
            }
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            if (tblProductos.Rows.Count > 1)
            {
                currentRowIndexProductos = tblProductos.CurrentRow.Index;
            }
            CrearProducto formCrear = new CrearProducto();
            //formCrear.Visible = true;
            formCrear.Show();
            formCrear.FormClosed += new FormClosedEventHandler(cierreCrearProducto);
        }

        void cierreCrearProducto(object sender, FormClosedEventArgs e)
        {
            recargarProductos();
            tblProductos.CurrentCell = tblProductos.Rows[currentRowIndexProductos].Cells[1];
            btnHabDeshabProducto.Enabled = tblProductos.Rows.Count > 1;
            btnEditarProducto.Enabled = tblProductos.Rows.Count > 1;
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            currentRowIndexProductos = tblProductos.CurrentRow.Index;
            if (tblProductos.CurrentRow != null && currentRowIndexProductos < tblProductos.Rows.Count-1)
            {
                EditarProducto formEditar = new EditarProducto(int.Parse(tblProductos.CurrentRow.Cells[0].Value.ToString()));
                //formEditar.Visible = true;
                formEditar.Show();
                formEditar.FormClosed += new FormClosedEventHandler(cierreEditarProducto);
            }
        }

        void cierreEditarProducto(object sender, FormClosedEventArgs e)
        {
            recargarProductos();
            tblProductos.CurrentCell = tblProductos.Rows[currentRowIndexProductos].Cells[1];
            
        }
        private void btnHabDeshabProducto_Click(object sender, EventArgs e)
        {
            currentRowIndexProductos = tblProductos.CurrentRow.Index;
            if (tblProductos.CurrentRow != null && currentRowIndexProductos < tblProductos.Rows.Count-1)
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
                            var item = new Producto();
                            if (bool.Parse(tblProductos.CurrentRow.Cells[6].Value.ToString()))
                            {
                                item.cod_producto = int.Parse(tblProductos.CurrentRow.Cells[0].Value.ToString());
                                item.nom_producto = tblProductos.CurrentRow.Cells[1].Value.ToString();
                                item.precio_compra = double.Parse(tblProductos.CurrentRow.Cells[2].Value.ToString());
                                item.precio_venta = double.Parse(tblProductos.CurrentRow.Cells[3].Value.ToString());
                                item.tiempo_preparacion = double.Parse(tblProductos.CurrentRow.Cells[4].Value.ToString());
                                item.stock = int.Parse(tblProductos.CurrentRow.Cells[5].Value.ToString());
                                item.habilitado = false;
                                item.cod_tipo_producto = int.Parse(tblProductos.CurrentRow.Cells[8].Value.ToString());
                            }
                            else
                            {
                                item.cod_producto = int.Parse(tblProductos.CurrentRow.Cells[0].Value.ToString());
                                item.nom_producto = tblProductos.CurrentRow.Cells[1].Value.ToString();
                                item.precio_compra = double.Parse(tblProductos.CurrentRow.Cells[2].Value.ToString());
                                item.precio_venta = double.Parse(tblProductos.CurrentRow.Cells[3].Value.ToString());
                                item.tiempo_preparacion = double.Parse(tblProductos.CurrentRow.Cells[4].Value.ToString());
                                item.stock = int.Parse(tblProductos.CurrentRow.Cells[5].Value.ToString());
                                item.habilitado = true;
                                item.cod_tipo_producto = int.Parse(tblProductos.CurrentRow.Cells[8].Value.ToString());
                            }

                            bd.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();
                        }
                        transaccion.Commit();
                        recargarProductos();
                        tblProductos.CurrentCell = tblProductos.Rows[currentRowIndexProductos].Cells[1];
                }
                    catch (Exception)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Fallo al deshabilitar el registro. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    recargarProductos();
                    tblProductos.CurrentCell = tblProductos.Rows[currentRowIndexProductos].Cells[1];
                }
            }
            }
        }

        public void recargarProductos()
        {
            using(MySqlConnection conexion = new MySqlConnection(conStr))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    using (var db = new bdContext(conexion, false))
                    {
                        db.Database.UseTransaction(transaccion);
                        tblProductos.Rows.Clear();
                        tblProductos.Columns.Clear();
                        tblProductos.Columns.Add("cod_producto", "Codigo");
                        tblProductos.Columns[0].Visible = false;
                        tblProductos.Columns.Add("nombre", "Nombre");
                        tblProductos.Columns.Add("precio_compra", "Precio compra");
                        tblProductos.Columns.Add("precio_venta", "Precio venta");
                        tblProductos.Columns.Add("tiempo_preparacion", "Tiempo preparacion");
                        tblProductos.Columns.Add("stock", "Cantidad disponible");
                        DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
                        tblProductos.Columns.Add(checkCol);
                        tblProductos.Columns[6].HeaderText = "Habilitado";
                        tblProductos.Columns.Add("tipo", "Categoria");
                        tblProductos.Columns.Add("cod_tipo_producto", "Codigo tipo");
                        tblProductos.Columns[8].Visible = false;

                        if (db.Productos.Count() != 0)
                        {

                            var productos = db.Productos.Select(p => new
                            {
                                cod_producto = p.cod_producto,
                                nombre = p.nom_producto,
                                p_compra = p.precio_compra,
                                p_venta = p.precio_venta,
                                t_preparacion = p.tiempo_preparacion,
                                stock = p.stock,
                                habilitado = p.habilitado,
                                cod_tipo_producto = p.cod_tipo_producto,
                                tipo = p.tipo_producto.nombre
                            }).ToList();
                            foreach (var item in productos)
                            {
                                tblProductos.Rows.Add(item.cod_producto, item.nombre, item.p_compra, item.p_venta, item.t_preparacion, item.stock, item.habilitado, item.tipo, item.cod_tipo_producto);
                            }
                        }


                    }
                    transaccion.Commit();
                }
                catch (Exception e)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al cargar los productos. Presione 'Recargar productos' para intentar nuevamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        
        public void recargarTiposProductos()
        {
            using (MySqlConnection conexion = new MySqlConnection(conStr))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    using (var db = new bdContext(conexion, false))
                    {
                        db.Database.UseTransaction(transaccion);

                        tblTiposProducto.Rows.Clear();
                        tblTiposProducto.Columns.Clear();
                        tblTiposProducto.Columns.Add("codigo_tipo", "Codigo");
                        tblTiposProducto.Columns[0].Visible = false;
                        tblTiposProducto.Columns.Add("nombre", "Nombre");
                        DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
                        tblTiposProducto.Columns.Add(checkCol);
                        tblTiposProducto.Columns[2].HeaderText = "Habilitado";

                        var productos = db.Tipos_producto.Select(tp => new
                        {
                            cod_tipo_producto = tp.cod_tipo_producto,
                            nombre = tp.nombre,
                            habilitado = tp.habilitado
                        }).ToList();

                        foreach (var item in productos)
                        {
                            tblTiposProducto.Rows.Add(item.cod_tipo_producto, item.nombre, item.habilitado);
                        }

                    }
                    transaccion.Commit();
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al cargar los tipos de producto. Presione 'Recargar tipos' para intentar nuevamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }
            
        }

        

        private void btnCrearTipoProducto_Click(object sender, EventArgs e)
        {
            if (tblTiposProducto.Rows.Count > 1)
            {
                currentRowIndexTiposProducto = tblTiposProducto.CurrentRow.Index;
            }
            CrearTipoProducto formCrearTipo = new CrearTipoProducto();
            //formCrearTipo.Visible = true;
            formCrearTipo.Show();
            formCrearTipo.FormClosed += new FormClosedEventHandler(cierreCrearTipoProducto);
        }

        void cierreCrearTipoProducto(object sender, FormClosedEventArgs e)
        {
            recargarTiposProductos();
            tblTiposProducto.CurrentCell = tblTiposProducto.Rows[currentRowIndexTiposProducto].Cells[1];
            btnHabDeshabTipoProducto.Enabled = tblTiposProducto.Rows.Count > 1;
            btnEditarTipoProducto.Enabled = tblTiposProducto.Rows.Count > 1;
        }

        private void btnEditarTipoProducto_Click(object sender, EventArgs e)
        {
            currentRowIndexTiposProducto = tblTiposProducto.CurrentRow.Index;
            if (tblTiposProducto.CurrentRow != null && tblTiposProducto.CurrentRow.Index < tblTiposProducto.Rows.Count-1)
            {
                EditarTipoProducto formEditarTipo = new EditarTipoProducto(int.Parse(tblTiposProducto.CurrentRow.Cells[0].Value.ToString()));
                formEditarTipo.Show();                
                formEditarTipo.FormClosed += new FormClosedEventHandler(cierreEditarTipoProducto);
            }
            
        }

        void cierreEditarTipoProducto(object sender, FormClosedEventArgs e)
        {
            recargarTiposProductos();
            tblTiposProducto.CurrentCell = tblTiposProducto.Rows[currentRowIndexTiposProducto].Cells[1];
        }

        private void btnHabDeshabTipoProducto_Click(object sender, EventArgs e)
        {
            currentRowIndexTiposProducto = tblTiposProducto.CurrentRow.Index;
            if (tblTiposProducto.CurrentRow != null && tblTiposProducto.CurrentRow.Index < tblTiposProducto.Rows.Count-1)
            {
                using (MySqlConnection connection = new MySqlConnection(conStr))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        using (var db = new bdContext(connection , false))
                        {
                            db.Database.UseTransaction(transaction);
                            //var item = db.Tipos_producto.Find(int.Parse(tblTiposProducto.CurrentRow.Cells[0].Value.ToString()));
                            var obj = new Tipo_producto();
                            if (bool.Parse(tblTiposProducto.CurrentRow.Cells[2].Value.ToString()) == true)
                            {
                                obj.cod_tipo_producto = int.Parse(tblTiposProducto.CurrentRow.Cells[0].Value.ToString());
                                obj.nombre = tblTiposProducto.CurrentRow.Cells[1].Value.ToString();
                                obj.habilitado = false;
                            }
                            else
                            {
                                obj.cod_tipo_producto = int.Parse(tblTiposProducto.CurrentRow.Cells[0].Value.ToString());
                                obj.nombre = tblTiposProducto.CurrentRow.Cells[1].Value.ToString();
                                obj.habilitado = true;
                            }

                            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                        transaction.Commit();
                        recargarTiposProductos();
                        tblTiposProducto.CurrentCell = tblTiposProducto.Rows[currentRowIndexTiposProducto].Cells[1];
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Fallo al deshabilitar el registro. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        recargarTiposProductos();
                        tblTiposProducto.CurrentCell = tblTiposProducto.Rows[currentRowIndexTiposProducto].Cells[1];
                    }
                }
            }
        }

        private void btnRecargarProductos_Click(object sender, EventArgs e)
        {
            recargarProductos();
        }

        private void btnRecargarTiposProducto_Click(object sender, EventArgs e)
        {
            recargarTiposProductos();
        }

        private void recargarDatosSimulacion()
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

                        tblSimulacion.Rows.Clear();
                        tblSimulacion.Columns.Clear();
                        tblSimulacion.Columns.Add("cod_cliente", "Codigo");
                        tblSimulacion.Columns[0].Visible = false;
                        tblSimulacion.Columns.Add("nombre", "Nombre");
                        tblSimulacion.Columns.Add("tiempo_servicio", "Tiempo de servicio");
                        tblSimulacion.Columns.Add("hora", "Hora");
                        int cSimulacion = simulacion.getCodigoSimulacion();
                        var clientesSimulacion = bd.Clientes.Where(c => c.hora_simulacion.cod_simulacion == cSimulacion)
                            .Select(a => new
                            {
                                cod_cliente = a.cod_cliente,
                                nombre = a.nombre,
                                tiempo_servicio = a.tiempo_servicio,
                                hora = a.hora_simulacion.hora
                            });
                        foreach (var item in clientesSimulacion)
                        {
                            tblSimulacion.Rows.Add(item.cod_cliente, item.nombre, item.tiempo_servicio, item.hora);
                        }
                    }
                    transaccion.Commit();
                }
                    catch (Exception)
                {
                    transaccion.Rollback();
                }
            }
        }

        private void btnGenerarRegistros_Click(object sender, EventArgs e)
        {
            simulacion = new LogicaSimulacion(int.Parse(txtHorasSimulacion.Value.ToString()));
            cantEscenarios = 3;
            if (checkCantidadEscenarios.Checked)
            {
                cantEscenarios = (int)txtCantidadEscenarios.Value;
            }
            if (simulacion.iniciarSimulacion(cantEscenarios))
            {
                //Console.WriteLine("Creacion de datos para simulacion: OK");
                //recargarDatosSimulacion();
                comboBoxEscenarios.Enabled = true;
                llenarComboBoxEscenarios();
                btnAgregarGastos.Enabled = true;
            }
            else
            {
                MessageBox.Show("Fallo al generar los datos para la simulacion. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxEscenarios.Enabled = false;
                btnAgregarGastos.Enabled = false;
            }
        }

        private void llenarComboBoxEscenarios()
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
                        
                        var simulaciones = bd.Simulaciones.OrderByDescending(s => s.cod_simulacion).Take(cantEscenarios).ToList();

                        simulaciones.Reverse();
                        comboBoxEscenarios.DataSource = simulaciones;
                        comboBoxEscenarios.DisplayMember = "indice_simulacion";
                        comboBoxEscenarios.ValueMember = "cod_simulacion";
                    }
                    transaccion.Commit();
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                }
            }
        }

        private void checkCantidadEscenarios_CheckedChanged(object sender, EventArgs e)
        {
            txtCantidadEscenarios.Enabled = checkCantidadEscenarios.Checked;
        }

        private void comboBoxEscenarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSeleccionado = (Simulacion)comboBoxEscenarios.SelectedItem;

            using (MySqlConnection conexion = new MySqlConnection(conStr))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    using (var bd = new bdContext(conexion, false))
                    {
                        bd.Database.UseTransaction(transaccion);

                        var horas = bd.Horas_simulacion.Where(hs => hs.cod_simulacion == itemSeleccionado.cod_simulacion).OrderBy(a => a.cod_hora).ToList();
                        List<int> cantidadesHoras = new List<int>();
                        foreach (var item in horas)
                        {
                            int cantidadClientes = bd.Clientes.Where(c => c.cod_hora == item.cod_hora).ToList().Count();
                            cantidadesHoras.Add(cantidadClientes);
                        }

                        tblSimulacion.Rows.Clear();
                        tblSimulacion.Columns.Clear();
                        tblSimulacion.Columns.Add("cod_hora", "Codigo");
                        tblSimulacion.Columns[0].Visible = false;
                        tblSimulacion.Columns.Add("hora", "Hora");
                        tblSimulacion.Columns.Add("cantidad", "Cantidad clientes");
                        tblSimulacion.Columns.Add("costo_hora", "Costo por hora");
                        tblSimulacion.Columns.Add("valor_ventas", "Valor por ventas");
                        tblSimulacion.Columns.Add("beneficio", "Beneficio");
                        tblSimulacion.Columns.Add("probabilidad", "Probabilidad");

                        //Sumatoria del costo total de los productos en stock
                        var productosSimulacion = bd.Productos.ToList();
                        double costoStock = 0;

                        foreach (var item in productosSimulacion)
                        {
                            costoStock += (item.precio_compra * item.stock);
                        }

                        //Sumatoria de los gastos fijos
                        var gastosFijos = bd.Gastos_fijos.Where(gf => gf.cod_escenario == itemSeleccionado.cod_escenario).ToList();
                        double costosFijosTotales = 0;

                        foreach (var item in gastosFijos)
                        {
                            costosFijosTotales += item.valor_gasto;
                        }

                        //Calculo de los gastos fijos por hora
                        double costoFijoPorHora = (costoStock + costosFijosTotales) / 26;

                        for (int i = 0; i < horas.Count(); i++)
                        {
                        //Sumatoria de los productos comprados por hora
                            int hora_i = horas[i].cod_hora;
                            var detallesVenta = bd.Detalles_venta.Where(dv => dv.cliente.cod_hora == hora_i).Select(a => a.producto_simulacion).ToList();
                            double cantidadComprada = 0;

                            foreach (var item in detallesVenta)
                            {
                                cantidadComprada += item.precio_venta;
                            }

                            //Obtencion del beneficio
                            double beneficio = cantidadComprada - costoFijoPorHora;

                            tblSimulacion.Rows.Add(horas[i].cod_hora, horas[i].hora, cantidadesHoras[i], costoFijoPorHora, cantidadComprada, beneficio, distribucionPoisson(cantidadesHoras[i]));
                            //tblSimulacion.Rows.Add(horas[i].cod_hora, horas[i].hora, cantidadesHoras[i], costoFijoPorHora, cantidadComprada, beneficio, null);
                        }

                        double mu = checkTasaServicio.Checked ? (double)txtCapacidadDeServicio.Value : 40;
                        double lambda = calcularTasaDeLlegadaPorSimulacion(itemSeleccionado.cod_simulacion);
                        
                        double Ls = Math.Ceiling(lambda / (mu - lambda));
                        double Ws = 1 / (mu - lambda);
                        double Lq = Math.Ceiling((lambda * lambda) / (mu * (mu - lambda)));
                        double Wq = lambda / (mu * (mu - lambda));
                        double ro = lambda / mu;
                        double Po = 1 - ro;

                        tblResultadosColas.Rows.Clear();
                        tblResultadosColas.Columns.Clear();
                        tblResultadosColas.Columns.Add("lambda", "Tasa de llegada");
                        tblResultadosColas.Columns.Add("mu", "Capacidad de servicio");
                        tblResultadosColas.Columns.Add("ls", "Ls");
                        tblResultadosColas.Columns.Add("ws", "Ws");
                        tblResultadosColas.Columns.Add("lq", "Lq");
                        tblResultadosColas.Columns.Add("wq", "Wq");
                        tblResultadosColas.Columns.Add("po", "Po");
                        tblResultadosColas.Columns.Add("ro", "Factor de uso");

                        tblResultadosColas.Rows.Add(lambda, mu, Ls, Ws, Lq, Wq, Po, ro);

                    }

                    transaccion.Commit();
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                }
            }

            //Console.WriteLine(itemSeleccionado.cod_simulacion);
        }

        private void tblSimulacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < tblSimulacion.Rows.Count-1)
            {
                int codigoHoraSeleccionada = int.Parse(tblSimulacion.Rows[e.RowIndex].Cells[0].Value.ToString());
                DetalleHora formDetalleHora = new DetalleHora(codigoHoraSeleccionada);
                formDetalleHora.Show();
                //using (var bd = new bdContext())
                //{
                //    int cCliente = int.Parse(tblSimulacion.Rows[e.RowIndex].Cells[0].Value.ToString());
                //    var objs = bd.Detalles_venta.Where(dv => dv.cod_cliente == cCliente)
                //        .Select(a => new {
                //            nombre = a.producto_simulacion.producto.nom_producto
                //        });

                //    foreach (var item in objs)
                //    {
                //        Console.WriteLine(item.nombre);
                //    }

                //}
            }
        }

        private double distribucionPoisson(int x)
        {
            double lambda = 20f;
            double e = Math.E;
            double k = x;

            
            double resultado = Math.Pow(lambda, k) / ( Math.Pow(e, lambda) * (double)factorial((int)k) );

            return resultado;
        }

        private BigInteger factorial(int n)
        {
            BigInteger fact = 1;
            for (ulong i = 1; i <= (ulong)n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        private int calcularTasaDeLlegadaPorSimulacion(int codigoSimulacion)
        {
            int tasaResultante = 20;
            using (MySqlConnection conexion = new MySqlConnection(conStr))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    using (var bd = new bdContext(conexion, false))
                    {
                        bd.Database.UseTransaction(transaccion);

                        double clientesPorHora = bd.Clientes.Where(c => c.hora_simulacion.cod_simulacion == codigoSimulacion).Count();
                        double numeroDeHoras = bd.Horas_simulacion.Where(hs => hs.cod_simulacion == codigoSimulacion).Count();

                        tasaResultante = (int)Math.Round(clientesPorHora / numeroDeHoras);
                    }

                    transaccion.Commit();
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                }
            }
            return tasaResultante;
        }

        private void btnAgregarGastos_Click(object sender, EventArgs e)
        {
            GastosFijos formGastos = new GastosFijos();
            formGastos.Show();
        }

        private void btnIniciarSimulacion_Click(object sender, EventArgs e)
        {

        }

        private void checkTasaServicio_CheckedChanged(object sender, EventArgs e)
        {
            txtCapacidadDeServicio.Enabled = checkTasaServicio.Checked;
        }
    }
}
