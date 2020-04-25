using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoSimulacionV._1.Modelos
{
    [Table("cliente")]
    class Cliente
    {
        [Key]
        public int cod_cliente { get; set; }
        public double? tiempo_servicio { get; set; }
        //[Column(TypeName = "date")]
        //public DateTime hora_llegada { get; set; }
        //[Column(TypeName = "varchar(250)")]
        public string nombre { get; set; }
        public int cod_hora {get; set;}
        [ForeignKey("cod_hora")]
        public virtual Hora_simulacion hora_simulacion { get; set; }
        //public List<Detalle_venta> detalles_venta { get; set; }
    }
}
