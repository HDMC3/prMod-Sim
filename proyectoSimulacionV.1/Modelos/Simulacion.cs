﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyectoSimulacionV._1.Modelos
{
    [Table("simulacion")]
    class Simulacion
    {
        [Key]
        public int cod_simulacion { get; set; }
        public int indice_simulacion { get; set; }
        public int horas_simulacion { get; set; }
        //[Column(TypeName = "time")]
        //public DateTime hora_ini { get; set; }
        //[Column(TypeName = "time")]
        //public DateTime hora_fin { get; set; }
        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }
        public int cod_escenario { get; set; }
        [ForeignKey("cod_escenario")]
        public virtual Escenario escenario { get; set; }
        //public List<Producto_simulacion> productos_simulacion { get; set; }
    }
}
