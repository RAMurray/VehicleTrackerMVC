using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VehiclesMVC.Models;

namespace VehiclesMVC.DAL
{
    public class VehiclesContext : DbContext
    {
        public VehiclesContext() : base("VehiclesContext")
        {
        }

        public DbSet<Automobile> Automobiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}