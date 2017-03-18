using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Brand
    {
        public Brand()
        {
            Products = new List<Product>();
            IsDeleted = false;
            CreatedDate = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }
        [DisplayName("Tên Nhãn")]
        public string BrandName { get; set; }
        [DisplayName("Hình")]
        public string Image { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        [DisplayName("Xóa")]
        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}