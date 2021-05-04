using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class usuario
    {
        public int id { get; set; }
        [Required]
        public string nombre  { get; set; }
        [Required]
        public string password { get; set; }
        public bool active { get; set; }
    }
}
