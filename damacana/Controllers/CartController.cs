using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using damacana.DAL;
using damacana.DAL.Models;
using damacana.Models;

namespace damacana.Controllers
{
    public class CartController : Controller
    {
        DamacanaEntities db = new DamacanaEntities();
        //
        // GET: /Cart/
        public ActionResult Index()
        {
            if (Session["Cart"] == null)
            {
                Session["Cart"] = new List<Product>();
            }

            List<Product> cart = Session["Cart"] as List<Product>;

            return View(cart);
        }

        public ActionResult AddToCart(int productId)
        {
            if (Session["Cart"] == null)
            {
                Session["Cart"] = new List<Product>();
            }

            List<Product> cart = Session["Cart"] as List<Product>;

            Product p = db.Product.FirstOrDefault(x => x.Id == productId);

            if (p != null)
            {
                cart.Add(p);
            }

            Session["Cart"] = cart;

            return RedirectToAction("Index");
        }

        public ActionResult CompletePurchese()
        {
            if (Session["Cart"] == null)
            {
                Session["Cart"] = new List<Product>();
            }

            List<Product> cart = Session["Cart"] as List<Product>;
            User user = db.User.FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (cart.Any())
            {
                Purchase p = new Purchase()
                {
                    CreateDate = DateTime.Now,
                    TotalPrice = cart.Sum(x => x.Price),
                    UserId = user.Id
                };
                db.Purchase.Add(p);

                foreach (var c in cart)
                {
                    PurchasedProducts pp = new PurchasedProducts()
                    {
                        Purchase = p,
                        ProductId = c.Id
                    };

                    db.PurchasedProducts.Add(pp);
                }

                db.SaveChanges();
                cart = new List<Product>();
                Session["Cart"] = cart;
            }

            return RedirectToAction("Index", "Purchase");
        }
	}
}