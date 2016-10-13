using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bookshelf1.Models
{
    public class Bookshelf1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Bookshelf1Context() : base("name=Bookshelf1Context")
        {
        }

        public System.Data.Entity.DbSet<Bookshelf1.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<Bookshelf1.Models.Category> Categories { get; set; }
    }
}
