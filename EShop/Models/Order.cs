using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Order
    {
        public Order()
        {
            CreatedDate = DateTime.Now;
            OrderItems = new List<OrderItem>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public virtual AspNetUser User { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int Total { get; set; }
    }
}