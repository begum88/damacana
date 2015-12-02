using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace damacana.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}