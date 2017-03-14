using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EShop.Models;

namespace EShop.Controllers
{
    public class CheckOutController : Controller
    {
        private EShopContext db = new EShopContext();

        // GET: CheckOut
        [HttpPost]
        public ActionResult Index(Order order)
        {
            if (order.OrderItems != null && order.OrderItems.Any())
            {
                order.OrderItems = order.OrderItems.Where(c => c.ProductId != 0).ToList();
                foreach (var item in order.OrderItems)
                {
                    var product = db.Product.Find(item.ProductId);
                    if (product != null)
                    {
                        item.Price = product.Price * item.Amount;
                        item.ProductPrice = product.Price;
                    }
                }
                try
                {
                    order.Total = order.OrderItems.Sum(c => c.Price);
                    order.OrderStatus = OrderStatus.New;
                    db.Order.Add(order);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return Json(new { result = false }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
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