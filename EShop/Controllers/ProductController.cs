using System;
using System.Linq;
using System.Web.Mvc;
using EShop.Models;

namespace EShop.Controllers
{
    public class ProductController : Controller
    {
        private EShopContext db = new EShopContext();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductByCategory(int categoryId)
        {
            var products = db.Product.Where(c => c.CategoryId == categoryId && c.IsDeleted == false).OrderByDescending(c=>c.CreatedDate).ToList();
            return View("Product",products);
        }

        public ActionResult Single(int productId)
        {
            var product = db.Product.Find(productId);
            return View(product);
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