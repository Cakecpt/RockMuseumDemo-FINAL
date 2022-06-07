using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RockMuseumUI.Models;
// SEBASTIAN
namespace RockMuseumUI.Data
{
    public class RockMuseumUIContext : DbContext
    {
        public RockMuseumUIContext (DbContextOptions<RockMuseumUIContext> options)
            : base(options)
        {
        }

        public DbSet<RockMuseumUI.Models.ExhibitionCollection> ExhibitionCollection { get; set; }
    }
}
