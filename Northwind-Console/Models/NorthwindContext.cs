using System.Data.Entity;

namespace NorthwindConsole.Models
{
    public class NorthwindContext : DbContext
    {
        //"base": We're using NorthwindContext with all of its default behaviors other than we've assigned a name to it
        public NorthwindContext() : base("name=NorthwindContext") { } 

        //Establish a relationship between our classes and tables in the database
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}