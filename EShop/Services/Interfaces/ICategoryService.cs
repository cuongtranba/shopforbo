using System.Collections.Generic;
using EShop.Models;

namespace EShop.Services.Interfaces
{
    public interface ICategoryService
    {
        void Delete(int categoryId);
        List<Category> GetAll();
    }
}