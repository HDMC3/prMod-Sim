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
    }
}
