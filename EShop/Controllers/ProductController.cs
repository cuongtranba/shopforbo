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
            var products = db.Product.Where(c => c.CategoryId == categoryId && c.IsDeleted == false).ToList();
            return View("Product",products);
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