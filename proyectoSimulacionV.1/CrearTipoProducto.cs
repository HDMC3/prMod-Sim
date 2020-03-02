using MySql.Data.MySqlClient;
using proyectoSimulacionV._1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoSimulacionV._1
{
    public partial class CrearTipoProducto : Form
    {
        public CrearTipoProducto()
        {
            InitializeComponent();
        }

        private void btnGuardarTipoProducto_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtNombreTipoProducto.Text)){
            if (txtNombreTipoProducto.Text.Replace(" ", "").Length != 0)
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=bd_tienda;uid=root;password=hugodavid24"))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        using (var bd = new bdContext())
                        {
                            // Passing an existing transaction to the context
                            //bd.Database.UseTransaction(transaction);

                            bd.Tipos_producto.Add(new Tipo_producto()
                            {
                                nombre = txtNombreTipoProducto.Text,
                                habilitado = chkTipoHabilitado.Checked
                            });

                            bd.SaveChanges();
                        }

                        transaction.Commit();

                        MessageBox.Show("Tipo de producto creado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        
                        //transaction.Dispose();
                        //connection.Close();
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("Fallo en la creacion del registro. Intente de nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw;
                        //transaction.Dispose();
                        //connection.Close();
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
