using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using damacana.DAL.Models;
using damacana.DAL;

namespace damacana.Controllers
{
    public class PurchaseController : Controller
    {
        private DamacanaEntities db = new DamacanaEntities();

        // GET: /Purchase/
        public ActionResult Index()
        {
            User user = db.User.FirstOrDefault(x => x.UserName == User.Identity.Name);
            return View(db.Purchase.Where(x => x.UserId == user.Id).ToList());
        }

        // GET: /Purchase/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchase.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            List<PurchasedProducts> purchasedProducts = db.PurchasedProducts.Where(x => x.PurchaseId == id).ToList();
            return View(purchasedProducts);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
