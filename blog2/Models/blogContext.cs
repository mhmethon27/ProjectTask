using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Model
{
    public class blogContext : IdentityDbContext
    {
        public blogContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<post> post { get; set; }
        public DbSet<comments> comments { get; set; }
        
    }
}
