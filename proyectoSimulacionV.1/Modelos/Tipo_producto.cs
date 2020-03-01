using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyectoSimulacionV._1.Modelos
{
    [Table("tipo_producto")]
    class Tipo_producto
    {
        [Key]
        public int cod_tipo_producto { get; set; }
        //[Column(TypeName = "varchar(350)")]
        public string nombre { get; set; }
        public bool habilitado { get; set; }
    }
}
