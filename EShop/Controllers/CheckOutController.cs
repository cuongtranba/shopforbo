using System.Collections.Generic;
using System.Web.Mvc;
using EShop.Models;

namespace EShop.Controllers
{
    public class CheckOutController : Controller
    {
        // GET: CheckOut
        [HttpPost]
        public ActionResult Index(Order order)
        {
            return View();
        }
    }
}