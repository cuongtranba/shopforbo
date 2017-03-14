using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EShop.Models
{
    public class OrderItem
    {
        [DisplayName("Mã")]
        public int OrderItemId { get; set; }
        [DisplayName("Số lượng")]
        public int Amount { get; set; }
        [DisplayName("Mã hóa đơn")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        [DisplayName("Tổng tiền")]
        public int Price { get; set; }
        [DisplayName("giá tiền")]
        public int ProductPrice { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}