﻿using AppTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AppTracker.Data
{
    public class AppTrackerContext : DbContext
    {
        public AppTrackerContext() : base()
        { }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Update> Updates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                
        }
    }
}