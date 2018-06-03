using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Digital8.Models
{
    public class UIEntities : DbContext
    {
        //model classes for context insertion to database

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}