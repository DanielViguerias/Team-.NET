using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class cuenta
    {
        public int id { get; set; }
        public string nombreCuenta { get; set; }
        public string nombreCliente  { get; set; }
        public string nombreResponsable { get; set; }
        public string equipo { get; set; }
        public bool active { get; set; }
    }
}
