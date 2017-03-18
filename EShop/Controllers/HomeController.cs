using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EShop.Models;

namespace EShop.Controllers
{
    public class HomeController : Controller
    {
        private EShopContext db = new EShopContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ChildActionOnly]
        public ActionResult Banner()
        {
            var productSpecial = db.Product.Where(c => c.IsSpecial).Take(5).ToList();
            return PartialView("_Banner", productSpecial);
        }
        [ChildActionOnly]
        public ActionResult Products()
        {
            var specialProducts = db.Product.Where(c => c.IsSpecial).Take(6).ToList();
            var saleProducts = db.Product.Where(c => c.IsSale).Take(6).ToList();
            var specialProductAndSaleProduct = new Tuple<List<Product>, List<Product>>(specialProducts, saleProducts);
            return PartialView("_Products", specialProductAndSaleProduct);
        }
        [ChildActionOnly]
        public ActionResult Discount()
        {
            return PartialView("_Discount");
        }
        [ChildActionOnly]
        public ActionResult BannerBottom()
        {
            return PartialView("_BannerBottom");
        }
        [ChildActionOnly]
        public ActionResult Brands()
        {
            var brands = db.Brands.Where(c => c.IsDeleted == false).OrderByDescending(c => c.CreatedDate).ToList();
            return PartialView("_Brands", brands);
        }
        [ChildActionOnly]
        public ActionResult NewProduct()
        {
            var productSale =
                db.Product.Where(c => c.IsDeleted == false && c.IsSale).OrderByDescending(c => c.CreatedDate).Take(4).ToList();
            return PartialView("_NewProduct", productSale);
        }

        public ActionResult Help()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Menu()
        {

            var categories = db.Category.Where(c => c.IsDeleted == false).ToList();
            var brands = db.Brands.Where(c => c.IsDeleted == false).ToList();
            var menu = new Tuple<List<Category>, List<Brand>>(categories, brands);
            return PartialView("_Menu", menu);
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