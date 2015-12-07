
using damacana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using damacana.DAL;
using damacana.DAL.Models;
using User = damacana.DAL.Models.User;


namespace damacana.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        DamacanaEntities _db = new DamacanaEntities();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult ProductList()
        {
            return View(_db.Product.ToList());
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveProduct(Product product)
        {
            
            //products.Add(product);
            return View();
        }

        public ActionResult CartList()
        {
            return View();
        }
        public ActionResult AddCart()
        {
            //create an empty cart
            Cart cart = new Cart();

            return View(cart);

        }
        [HttpPost]
        public ActionResult SaveCart(Cart cart)
        {

            //carts.Add(cart);
            return View(cart);
        }
        public ActionResult EditCart(int id)
        {
            //   products.Add(product);
            //ViewBag.Message = "Your application description page.";
            //Cart cart = new Cart();

            //foreach (var find in carts)
            //{

            //    if (find.Id == id)
            //    {


            //        cart.UserId = find.UserId;

            //        cart.Id = find.Id;


            //        carts.Remove(find);
            //        break;
            //    }

            //}
            return View();
        }
        [HttpGet]
        public ActionResult DeleteCart(int id)
        {
            ViewBag.Message = "Your application description page.";
            //foreach (var find in carts)
            //{

            //    if (find.Id == id)
            //    {
            //        carts.Remove(find);
            //        break;
            //    }

            //}
            return View();
        }
        public ActionResult AddtoCart(string name)
        {
            
            ViewBag.Message = "Your application description page.";
            Product product = new Product();

            //foreach (var find in products)
            //{

            //    if (find.Name == name)
            //    {


            //        product.Name = find.Name;
            //        product.Price = find.Price;
            //        product.Id = find.Id;
            //        //product.CartId = 1;

            //        products.Remove(find); products.Add(product);
            //        break;
            //    }

            //}
            return View(product);
        }


        [HttpGet]
        public ActionResult DeleteProductfromCart(string name)
        {
            ViewBag.Message = "Your application description page.";
            //foreach (var find in products)
            //{

            //    if (find.Name == name)
            //    {
            //        //find.CartId = 0;
            //        break;
            //    }

            //}
            return View();
        }

        public ActionResult ProductListOfCarts(int id)
        {
            List<Product> ProductListOfCarts = new List<Product>();
            Product product = new Product();
            //foreach (var find in products)
            //{

            //    //if (find.CartId == id)
            //    //{


            //    //    product.Name = find.Name;
            //    //    product.Price = find.Price;
            //    //    product.Id = find.Id;


            //    //    ProductListOfCarts.Add(product);

            //    //}

            //}
            return View(ProductListOfCarts);
        }
       

        public ActionResult EditProduct(string name)
        {
            ViewBag.Message = "Your application description page.";
            Product product = new Product();

            //foreach (var find in products)
            //{

            //    if (find.Name == name)
            //    {


            //        product.Name = find.Name;
            //        product.Price = find.Price;
            //        product.Id = find.Id;


            //        products.Remove(find);
            //        break;
            //    }

            //}
            return View(product);
        }
        [HttpGet]
        public ActionResult DeleteProduct(string name)
        {
            ViewBag.Message = "Your application description page.";
            //foreach (var find in products)
            //{

            //    if (find.Name == name)
            //    {
            //        products.Remove(find);
            //        break;
            //    }

            //}
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PurchaseList()
        {

            return View();
        }

        public ActionResult AddPurchase(int id)
        {
           

            Purchase purchase = new Purchase();
            {
                purchase.CreateDate = DateTime.Now;
                purchase.Id = 1;
            }

            decimal k = 0;

            //foreach (var find in products)
            //{

            //    //if (find.CartId == id)
            //    //{

            //    //    k = k + find.Price;

            //    //}

            //}
            //purchase.TotalPrice = k;
            //purchases.Add(purchase);

            return View(purchase);



        }
        [HttpPost]
        public ActionResult SavePurchase(Purchase purchase)
        {

            //foreach (var find in products)
            //{

            //    //if (find.CartId != 0)
            //    //{

            //    //    find.CartId = 0;

            //    //}

            //}
            //z++;
            return View(purchase);
        }


    }
}