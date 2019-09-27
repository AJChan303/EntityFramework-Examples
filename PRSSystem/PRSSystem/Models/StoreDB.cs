using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRSSystem.Models {
    public class StoreDB : DbContext {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public StoreDB(DbContextOptions options) : base(options) {

        }
    }
}
