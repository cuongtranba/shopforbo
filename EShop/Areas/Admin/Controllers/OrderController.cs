using System.Web.Mvc;

namespace EShop.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Admin/Order
        public ActionResult Index()
        {
            return View();
        }
    }
}