using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}