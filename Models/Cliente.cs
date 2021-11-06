using System;


namespace Sam.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public DateTime fecha { get; set; }
        public string tarjeta{get; set;}
        public string distrito { get; set; }
        public string MyProperty { get; set; }

    }
}
