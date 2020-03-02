using proyectoSimulacionV._1.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoSimulacionV._1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new bdContext())
            {
                if (db.Tipos_producto.Count() == 0)
                {
                    db.Tipos_producto.Add(new Tipo_producto() { nombre = "Comida preparada", habilitado = true });
                    db.SaveChanges();
                }
                
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
