using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSimulacionV._1.Modelos
{
    [Table("escenario")]
    class Escenario
    {
        [Key]
        public int cod_escenario { get; set; }
        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }
    }
}
