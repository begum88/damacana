using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damacana.DAL.Models
{
    public class PurchasedProducts
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual Product Product { get; set; }
    }
}
