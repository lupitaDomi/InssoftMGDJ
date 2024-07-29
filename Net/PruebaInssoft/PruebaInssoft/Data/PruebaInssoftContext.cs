using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaInssoft.Models;

namespace PruebaInssoft.Data
{
    public class PruebaInssoftContext : DbContext
    {
        public PruebaInssoftContext (DbContextOptions<PruebaInssoftContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaInssoft.Models.Usuario> Usuario { get; set; } = default!;
    }
}
