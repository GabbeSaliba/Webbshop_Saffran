using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
     public class DatabaseContext : DbContext
     {
          public DatabaseContext(DbContextOptions<DatabaseContext> options)
           : base(options)
          {
          }

          public DbSet<Orders> Orders { get; set; }
          public DbSet<User> User { get; set; }
          public DbSet<Product> Product { get; set; }
          //public DbSet<OrderDetail> OrderDetail { get; set; }
          public DbSet<Pictures> Pictures { get; set; }
          public DbSet<Reviews> Reviews { get; set; }
          public DbSet<Category> Category { get; set; }

     }
}
