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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tblProductos.ReadOnly = true;
            tblTiposProducto.ReadOnly = true;
            recargarProductos();
            
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            CrearProducto formCrear = new CrearProducto();
            formCrear.Visible = true;
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            EditarProducto formEditar = new EditarProducto();
            formEditar.Visible = true;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }

        public void recargarProductos()
        {
            using(var db = new bdContext())
            {
                tblProductos.Rows.Clear();
                tblProductos.Columns.Clear();
                tblProductos.Columns.Add("nombre", "Nombre");
                tblProductos.Columns.Add("precio_compra", "Precio compra");
                tblProductos.Columns.Add("precio_venta", "Precio venta");
                tblProductos.Columns.Add("stock", "Cantidad disponible");
                DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
                tblProductos.Columns.Add(checkCol);
                tblProductos.Columns[4].HeaderText = "Habilitado";
                tblProductos.Columns.Add("tipo", "Categoria");

                var productos = db.Productos.Select(p => new
                {
                    cod_producto = p.cod_producto,
                    nombre = p.nom_producto,
                    p_compra = p.precio_compra,
                    p_venta = p.precio_venta,
                    stock = p.stock,
                    habilitado = p.habilitado,
                    tipo = p.tipo_producto.nombre
                }).ToList();

                foreach(var item in productos)
                {
                    tblProductos.Rows.Add(item.nombre, item.p_compra, item.p_venta, item.stock, item.habilitado, item.tipo);
                }

            }
        }
        
        public void recargarTiposProductos()
        {
            using(var db = new bdContext())
            {
                tblTiposProducto.Rows.Clear();
                tblTiposProducto.Columns.Clear();
                tblTiposProducto.Columns.Add("nombre", "Nombre");
                DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
                tblTiposProducto.Columns.Add(checkCol);
                tblTiposProducto.Columns[1].HeaderText = "Habilitado";
                var productos = db.Tipos_producto.Select(tp => new
                {
                    cod_tipo_producto = tp.cod_tipo_producto,
                    nombre = tp.nombre,
                    habilitado = tp.habilitado
                }).ToList();

                foreach(var item in productos)
                {
                    tblTiposProducto.Rows.Add(item.nombre, item.habilitado);
                }

            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPageIndex == 0)
            {
                recargarProductos();
            }else if(e.TabPageIndex == 1)
            {
                recargarTiposProductos();
            }
        }

        private void btnCrearTipoProducto_Click(object sender, EventArgs e)
        {
            CrearTipoProducto formEditarTipo = new CrearTipoProducto();
            formEditarTipo.Visible = true;
            formEditarTipo.FormClosed += new FormClosedEventHandler(cierreCrearTipoProducto);
        }

        private void btnEliminarTipoProducto_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(tblTiposProducto.Rows.Count);
            //Console.WriteLine(tblTiposProducto.CurrentRow.Index);
            
        }

        void cierreCrearTipoProducto(object sender, FormClosedEventArgs e)
        {
            recargarTiposProductos();
        }
    }
}
