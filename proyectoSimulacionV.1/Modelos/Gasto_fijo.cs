using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSimulacionV._1.Modelos
{
    [Table("gasto_fijo")]
    class Gasto_fijo
    {
        [Key]
        public int cod_gasto_fijo { get; set; }
        public string nombre_gasto { get; set; }
        public double valor_gasto { get; set; }
        public int cod_escenario { get; set; }
        [ForeignKey("cod_escenario")]
        public virtual Escenario escenario{ get; set; }
    }
}
