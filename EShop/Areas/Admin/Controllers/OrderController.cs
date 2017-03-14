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
       

        public ActionResult Details(int id)
        {
            var order = db.Order.Include(d => d.OrderItems).FirstOrDefault(c => c.OrderId == id);
            return View(order);
        }

        public ActionResult Delete(int id)
        {
            var order = db.Order.Find(id);
            if (order !=null)
            {
                order.OrderStatus = OrderStatus.Cancel;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            throw new System.NotImplementedException();
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