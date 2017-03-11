using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Product
    {
        public Product()
        {
            Tags = new HashSet<Tag>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool InStock { get; set; }
        public bool IsDeleted { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public string Image { get; set; }
    }
}