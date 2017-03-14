using System.ComponentModel.DataAnnotations;

namespace EShop.Models
{
    public enum OrderStatus : byte
    {
        [Display(Name = "đang giao hàng")]
        Shipping = 1,
        [Display(Name = "đã giao")]
        Done = 2,
        [Display(Name = "mới")]
        New = 3
    }
}