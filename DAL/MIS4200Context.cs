using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ew774515_MIS4800.Models;

namespace ew774515_MIS4800.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
         Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,ew774515_MIS4800.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<customer> Customers { get; set; }
        public DbSet<orders> Orders { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<pets> Pets { get; set; }

        public DbSet<vets> Vets { get; set; }

        public DbSet<appointments> Appointments { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
       
    }
}