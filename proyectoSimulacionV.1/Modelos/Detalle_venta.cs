using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoSimulacionV._1.Modelos
{
    [Table("detalle_venta")]
    class Detalle_venta
    {
        [Key]
        public int cod_detalle_venta { get; set; }
        public int? cantidad_producto { get; set; }
        public int cod_cliente { get; set; }
        [ForeignKey("cod_cliente")]
        public virtual Cliente cliente { get; set; }        
        public int cod_prod_simulacion { get; set; }
        [ForeignKey("cod_prod_simulacion")]
        public virtual Producto_simulacion producto_simulacion { get; set; }
    }
}
