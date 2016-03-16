using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cis411_Homework08_Petshop.Models
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
    }
}