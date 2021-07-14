using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaxTestWebApiCodeGen.Models {
    public class AppDbContext : DbContext {
        public DbSet<Customer> Customers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public AppDbContext() {}
    }
}
