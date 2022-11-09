using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection") //web.configteki dataconnectionı DbContexte gönderiyoruz
        {
            //Database.SetInitializer(new DataInitializer()); // Adding test data to database
        }

        //Kullanacak olduğumuz tabloları buraya yazıyoruz
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Comment> Commments { get; set; }
    }
}