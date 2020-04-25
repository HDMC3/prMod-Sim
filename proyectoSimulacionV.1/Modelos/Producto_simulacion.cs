using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyectoSimulacionV._1.Modelos
{
    [Table("producto_simulacion")]
    class Producto_simulacion
    {
        [Key]
        public int cod_prod_simulacion { get; set; }
        //[Column(TypeName = "DECIMAL")]
        public double precio_compra { get; set; }
        //[Column(TypeName = "DECIMAL")]
        public double precio_venta { get; set; }
        public double tiempo_preparacion { get; set; }
        public int stock { get; set; }
        public int cod_producto { get; set; }
        [ForeignKey("cod_producto")]
        public virtual Producto producto { get; set; }
        public int cod_simulacion { get; set; }
        [ForeignKey("cod_simulacion")]
        public virtual Simulacion simulacion { get; set; }
        //public List<Detalle_venta> detalles_ventas { get; set; }

    }
}
