using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MopMarvels.Models;

namespace MopMarvels.Data
{
    public class MopMarvelsContext : DbContext
    {
        public MopMarvelsContext (DbContextOptions<MopMarvelsContext> options)
            : base(options)
        {
        }

        public DbSet<MopMarvels.Models.Product> Product { get; set; } = default!;
    }
}
