using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller1_Mauricio_Mora.Models;

namespace Taller1_Mauricio_Mora.Data
{
    public class Taller1_Mauricio_MoraContext : DbContext
    {
        public Taller1_Mauricio_MoraContext (DbContextOptions<Taller1_Mauricio_MoraContext> options)
            : base(options)
        {
        }

        public DbSet<Taller1_Mauricio_Mora.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Taller1_Mauricio_Mora.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<Taller1_Mauricio_Mora.Models.Jugador> Jugador { get; set; } = default!;
    }
}
