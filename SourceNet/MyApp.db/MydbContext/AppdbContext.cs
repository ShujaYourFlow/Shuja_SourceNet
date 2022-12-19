using Microsoft.EntityFrameworkCore;
using MyApp.Entity;
using MyApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.db.MydbContext
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options)
            : base(options)
        {

        }

        public DbSet<EntityCustomer> Customers { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityCustomer>()
                .HasNoKey();

        }



    }
}
