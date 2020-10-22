using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectClient.Models
{
    public class ProjectClientContext : DbContext
    {
        public ProjectClientContext (DbContextOptions<ProjectClientContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectClient.Models.Client> Client { get; set; }
    }
}
