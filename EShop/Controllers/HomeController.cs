using System.Web.Mvc;

namespace EShop.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult NewArrivals()
        {
            return PartialView("_NewArrivals");
        }
        [ChildActionOnly]
        public ActionResult Discount()
        {
            return PartialView("_Discount");
        }
        [ChildActionOnly]
        public ActionResult Product()
        {
            return PartialView("_Product");
        }
    }
}