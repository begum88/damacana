using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using damacana.DAL.Models;

namespace damacana.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Product> Products { get; set; }
    }
}