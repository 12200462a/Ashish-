﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project.Data
{
    public class ProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProjectContext() : base("name=ProjectContext")
        {
        }

        public System.Data.Entity.DbSet<Project.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<Project.Models.MenuItems> MenuItems { get; set; }

        public System.Data.Entity.DbSet<Project.Models.Reservation> Reservations { get; set; }

        public System.Data.Entity.DbSet<Project.Models.Table> Tables { get; set; }

        public System.Data.Entity.DbSet<Project.Models.User> Users { get; set; }
    }
}
