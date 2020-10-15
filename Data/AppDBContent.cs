using Microsoft.EntityFrameworkCore;
using Site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { 
        
        }
        public DbSet<CV> Cv { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}
