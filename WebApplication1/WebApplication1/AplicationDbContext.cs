using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    
    public class AplicationDbContext: DbContext
    {
        DbSet<usuario> usuario { get; set; }
        DbSet<cuenta> cuenta { get; set; }
        DbSet<movimiento> movimiento { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
