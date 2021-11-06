using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sam.Models
{
    [Table ("t_comentarios")]
    public class Comentarios
    {

        public int id {get;set;}

        public string comentario{get;set;}
    }
}