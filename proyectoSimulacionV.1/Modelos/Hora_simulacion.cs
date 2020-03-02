using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoSimulacionV._1.Modelos
{
    [Table("hora_simulacion")]
    class Hora_simulacion
    {
        [Key]
        public int cod_hora { get; set; }
        //[Column(TypeName="time")]
        public DateTime hora { get; set; }
        public int cod_simulacion { get; set; }
        [ForeignKey("cod_simulacion")]
        public virtual Simulacion simulacion { get; set; }
        //public List<Cliente> clientes { get; set; }
    }
}
