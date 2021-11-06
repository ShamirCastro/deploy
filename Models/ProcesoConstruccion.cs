using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sam.Models
{
    [Table ("t_procesoConstruccion")]
    public class ProcesoConstruccion
    {

        public int id {get;set;}

        public string procesoConstruccion{get;set;}
        public Construccion Construccion { get; set; }
    }
}