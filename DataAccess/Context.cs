using Core.Models.ProductSide;
using Core.Models.UserSide;
using DataAccess.Configuration;
using DataAccess.Configuration.UserSide;
using DataAccess.Seed;
using DataAccess.Seed.UserSide;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //fluentapi
        {
            //----------------configure--------------------------------//
            
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            //------------------seed fake data-------------------------//           
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new RoleSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new UserSeed(new int[] { 1, 2 }));



            modelBuilder.Entity<Role>().HasData(
                                               new Role { ID = 1, Name = "SysAdmin" },
                                               new Role { ID = 2, Name="Admin" },
                                               new Role { ID = 3, Name="Customer" }
                                              );
            modelBuilder.Entity<User>().HasData(
                                               new User { ID = 1, Name = "SysAdmin", Password = "123", RoleID = 1},
                                               new User { ID = 2, Name = "Admin", Password = "123", RoleID = 2},
                                               new User { ID = 3, Name = "Customer", Password = "123", RoleID = 3}
                                              );
            
            modelBuilder.Entity<Category>().HasData(
                                              new Category { ID = 1, Name = "paper-work" },
                                              new Category { ID = 2, Name = "clothing" }                                           
                                             );

            modelBuilder.Entity<Product>().HasData(
                                             new Product { ID = 1, Name = "pen", CategoryID = 1 },
                                             new Product { ID = 2, Name = "paper", CategoryID = 1 },
                                             new Product { ID = 3, Name = "jean", CategoryID = 2},
                                             new Product { ID = 4, Name = "skirt", CategoryID = 2}                                          
                );


        }
    }
}
