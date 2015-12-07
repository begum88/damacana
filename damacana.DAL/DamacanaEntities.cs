using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using damacana.DAL.Models;

namespace damacana.DAL
{
    public class DamacanaEntities : DbContext
    {
        public virtual DbSet<User> User { get; set; } 
        public virtual DbSet<Product> Product { get; set; } 
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchasedProducts> PurchasedProducts { get; set; } 
        
    }
}
