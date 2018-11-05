using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceStore.Models;

namespace ServiceStore.Models
{
    public class ServiceStoreContext : DbContext
    {
        public ServiceStoreContext (DbContextOptions<ServiceStoreContext> options)
            : base(options)
        {
        }

        public DbSet<ServiceTeam> ServiceTeam { get; set; }
    }
}
