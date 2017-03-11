using EShop.Models;

namespace EShop.Services.Implements
{
    public abstract class BaseService
    {
        protected EShopContext EShopContext;

        protected BaseService(EShopContext eShopContext)
        {
            this.EShopContext = eShopContext;
        }
    }
}