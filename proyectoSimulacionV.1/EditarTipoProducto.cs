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
    public partial class EditarTipoProducto : Form
    {
        private int cod_tipo_prod;
        private string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["bdContext"].ConnectionString;
        public EditarTipoProducto(int cod_tipo)
        {
            InitializeComponent();
            cod_tipo_prod = cod_tipo;
            
            using (MySqlConnection conexion = new MySqlConnection(conStr))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    using (var bd = new bdContext())
                    {

                        var item = bd.Tipos_producto.Find(cod_tipo_prod);
                        txtNombreTipoProducto.Text = item.nombre;
                        chkTipoHabilitado.Checked = item.habilitado;
                        
                    }

                    transaccion.Commit();
                    
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al obtener los datos. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    //throw;
                }
            }
            
        }

        private void btnGuardarEditarTipoProducto_Click(object sender, EventArgs e)
        {
            if (txtNombreTipoProducto.Text.Replace(" ", "").Length != 0)
            {
                using (MySqlConnection conexion = new MySqlConnection(conStr))
                {
                    conexion.Open();
                    MySqlTransaction transaccion = conexion.BeginTransaction();

                    try
                    {
                        using (var bd = new bdContext())
                        {
                            var item = new Tipo_producto() 
                            { 
                                cod_tipo_producto = cod_tipo_prod, 
                                nombre = txtNombreTipoProducto.Text,
                                habilitado = chkTipoHabilitado.Checked
                            };
                            bd.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();
                        }

                        transaccion.Commit();

                        //MessageBox.Show("Los cambios se guardaron exitosamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Fallo al guardar los datos. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        //throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("El nombre de tipo no puede estar vacio.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
