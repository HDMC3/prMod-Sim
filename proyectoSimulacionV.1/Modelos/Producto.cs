using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSimulacionV._1.Modelos
{
    [Table("producto")]
    class Producto
    {
        [Key]
        public int cod_producto { get; set; }
        //[Column(TypeName="DECIMAL")]
        public double precio_compra { get; set; }
        //[Column(TypeName = "varchar(350)")]
        public string nom_producto { get; set; }
        //[Column(TypeName = "DECIMAL")]
        public double precio_venta { get; set; }
        public int stock { get; set; }
        public bool habilitado { get; set; }
        public int cod_tipo_producto { get; set; }
        [ForeignKey("cod_tipo_producto")]
        public virtual Tipo_producto tipo_producto { get; set; }
        //public List<Producto_simulacion> productos_simulacion { get; set; }
    }
}
