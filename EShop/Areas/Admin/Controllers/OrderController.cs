using System.Web.Mvc;
using EShop.Models;

namespace EShop.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        private EShopContext db = new EShopContext();

        // GET: Admin/Order
        public ActionResult Index()
        {
            return View();
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