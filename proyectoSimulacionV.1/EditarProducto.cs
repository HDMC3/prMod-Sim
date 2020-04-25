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
    public partial class EditarProducto : Form
    {
        private int cod_producto;
        private string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["bdContext"].ConnectionString;
        public EditarProducto(int cod_prod)
        {
            InitializeComponent();
            cod_producto = cod_prod;
            using (MySqlConnection conexion = new MySqlConnection(conStr))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    using(var bd = new bdContext())
                    {
                        var item = bd.Productos.Find(cod_producto);
                        var tiposProducto = bd.Tipos_producto.Where(tp => tp.habilitado).ToList();
                        txtNombreProducto.Text = item.nom_producto.ToString();
                        txtPrecioCostoProducto.Value = decimal.Parse(item.precio_compra.ToString());
                        txtPrecioVentaProducto.Value = decimal.Parse(item.precio_venta.ToString());
                        txtTiempoPreparacion.Value = decimal.Parse(item.tiempo_preparacion.ToString());
                        txtStock.Value = decimal.Parse(item.stock.ToString());
                        chkHabilitado.Checked = item.habilitado;
                        txtTipoProducto.DisplayMember = "nombre";
                        txtTipoProducto.ValueMember = "cod_tipo_producto";
                        txtTipoProducto.DataSource = tiposProducto;
                        int indiceTipoActual = 0;
                        for (int i = 0; i < tiposProducto.ToArray().Length; i++)
                        {
                            if(tiposProducto[i].cod_tipo_producto == item.cod_tipo_producto)
                            {
                                indiceTipoActual = i;
                                break;
                            }
                        }
                        txtTipoProducto.SelectedIndex = indiceTipoActual;
                        
                    }
                    transaccion.Commit();
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al obtener los datos. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void chkHabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTipoProducto_Click(object sender, EventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarEditarProducto_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtTipoProducto.SelectedItem);
            if (txtNombreProducto.Text.Replace(" ", "").Length != 0)
            {
                using (MySqlConnection conexion = new MySqlConnection(conStr))
                {
                    conexion.Open();
                    MySqlTransaction transaccion = conexion.BeginTransaction();

                    try
                    {
                        using (var bd = new bdContext())
                        {
                            var tipoProducto = (Tipo_producto)txtTipoProducto.SelectedItem;
                            var item = new Producto()
                            {
                                cod_producto = cod_producto,
                                nom_producto = txtNombreProducto.Text,
                                precio_compra = (double)txtPrecioCostoProducto.Value,
                                precio_venta = (double)txtPrecioVentaProducto.Value,
                                tiempo_preparacion = (double)txtTiempoPreparacion.Value,
                                stock = (int)txtStock.Value,
                                cod_tipo_producto = tipoProducto.cod_tipo_producto,
                                habilitado = chkHabilitado.Checked
                            };

                            bd.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();
                        }

                        transaccion.Commit();
                        this.Close();
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Error al guardar los cambios. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("El nombre del producto no puede estar vacio ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
