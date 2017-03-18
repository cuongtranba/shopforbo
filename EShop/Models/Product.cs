using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Product
    {
        public Product()
        {
            Tags = new HashSet<Tag>();
            CreatedDate = DateTime.Now;
            InStock = true;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string Title { get; set; }
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
        [DisplayName("Còn hàng")]
        public bool InStock { get; set; }
        [DisplayName("Xóa")]
        public bool IsDeleted { get; set; }
        [DisplayName("Giá")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        public int Price { get; set; }
        [DisplayName("Loại")]
        public int CategoryId { get; set; }
        [DisplayName("Hàng giảm giá")]
        public bool IsSale { get; set; }
        [DisplayName("Hàng đặt biệt")]
        public bool IsSpecial { get; set; }
        [DisplayName("Ngày nhập")]
        public DateTime CreatedDate { get; set; }
        [DisplayName("Giá giảm")]
        public int DiscountPrice { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        [DisplayName("Hình")]
        public string Image { get; set; }
        public virtual Brand Brand { get; set; }
        public int? BrandId { get; set; }
    }
}