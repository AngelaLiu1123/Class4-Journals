#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Class4_Journals.Models;

namespace Class4_Journals.Data
{
    public class JournalsContext : DbContext
    {
        public JournalsContext (DbContextOptions<JournalsContext> options)
            : base(options)
        {
        }

        public DbSet<Journal> Journal { get; set; }
        public DbSet<Journal> User { get; set; }
        public DbSet<Journal> Comment { get; set; }
    }
}
