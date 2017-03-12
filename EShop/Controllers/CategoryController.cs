using System.Linq;
using System.Web.Mvc;
using EShop.Models;

namespace EShop.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private EShopContext db = new EShopContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuCategoryInProductPage()
        {
            var models = db.Category.Where(c => c.IsDeleted == false).ToList();
            return PartialView(models);
        }
    }
}