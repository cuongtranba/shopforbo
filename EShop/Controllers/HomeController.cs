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
            return PartialView("_Banner");
        }
        [ChildActionOnly]
        public ActionResult Products()
        {
            return PartialView("_Products");
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
            return PartialView("_Brands");
        }
        [ChildActionOnly]
        public ActionResult NewProduct()
        {
            return PartialView("_NewProduct");
        }

        public ActionResult Help()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Menu()
        {

            var categories = db.Category.Where(c => c.IsDeleted == false).ToList();
            return PartialView("_Menu",categories);
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