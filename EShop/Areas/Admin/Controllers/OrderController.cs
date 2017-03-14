using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using EShop.Models;

namespace EShop.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Admin/Order
        private EShopContext db = new EShopContext();

        public ActionResult Index()
        {
            var orders = db.Order.Include(d => d.OrderItems).OrderByDescending(c => c.CreatedDate).ToList();
            return View(orders);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Details(int id)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}