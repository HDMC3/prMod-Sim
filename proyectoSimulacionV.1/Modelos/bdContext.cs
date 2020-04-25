using System;
using System.Collections.Generic;
using MySql.Data.Entity;
using System.Data.Entity;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSimulacionV._1.Modelos
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class bdContext:DbContext
    {
        public bdContext() : base()
        {

        }

        public bdContext(DbConnection existingConnection, bool a) : base(existingConnection, a)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Detalle_venta> Detalles_venta { get; set; }
        public DbSet<Hora_simulacion> Horas_simulacion { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Producto_simulacion> Productos_simulacion { get; set; }
        public DbSet<Simulacion> Simulaciones { get; set; }
        public DbSet<Tipo_producto> Tipos_producto { get; set; }
        public DbSet<Gasto_fijo> Gastos_fijos { get; set; }
        public DbSet<Escenario> Escenarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Cliente>()
            //    .HasMany(c => c.detalles_venta);

            //modelBuilder.Entity<Hora_simulacion>()
            //    .HasMany(hs => hs.clientes);

            //modelBuilder.Entity<Producto>()
            //    .HasMany(p => p.productos_simulacion);

            //modelBuilder.Entity<Producto_simulacion>()
            //    .HasMany(ps => ps.detalles_ventas);

            //modelBuilder.Entity<Simulacion>()
            //    .HasMany(s => s.productos_simulacion);
                
                
        }
    }
}
