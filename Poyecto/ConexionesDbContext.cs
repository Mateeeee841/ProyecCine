using Proyecto.Clases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class ConexionesDbContext : DbContext
    {
        public ConexionesDbContext(DbContextOptions <ConexionesDbContext> options) : base(options)
        {
            
        }
        public DbSet<Personaje> personajes { get; set; }
        public DbSet<Tv> tvs { get; set; }


    }
}
