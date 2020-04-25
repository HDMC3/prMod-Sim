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
    public partial class CrearProducto : Form
    {
        public CrearProducto()
        {
            InitializeComponent();
            txtTipoProducto.DisplayMember = "nombre";
            txtTipoProducto.ValueMember = "cod_tipo_producto";
            txtTipoProducto.DataSource = dropTiposProductos();
        }


        private void lblPrecioVentaProducto_Click(object sender, EventArgs e)
        {

        }


        private List<Tipo_producto> dropTiposProductos()
        {
            using (var db = new bdContext())
            {
                return db.Tipos_producto.Where(tp => tp.habilitado).ToList();
            }
        }
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            using (var db = new bdContext())
            {
                var tiposProducto = dropTiposProductos();
                var item = (Tipo_producto)txtTipoProducto.SelectedItem;
                db.Productos.Add(new Producto()
                {
                    nom_producto = txtNombreProducto.Text,
                    precio_compra = (Double)txtPrecioCostoProducto.Value,
                    precio_venta = (Double)txtPrecioVentaProducto.Value,
                    tiempo_preparacion = (double)txtTiempoPreparacion.Value,
                    stock = (Int32)txtStock.Value,
                    cod_tipo_producto = item.cod_tipo_producto,
                    habilitado = chkHabilitado.Checked
                }) ;
                db.SaveChanges();
                //MessageBox.Show("Producto creado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }

        private void txtTipoProducto_DropDown(object sender, EventArgs e)
        {
            txtTipoProducto.DataSource = dropTiposProductos();
        }
    }
}
