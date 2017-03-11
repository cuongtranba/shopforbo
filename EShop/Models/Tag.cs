using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Tag
    {
        public Tag()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TagId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products{ get; set; }
    }
}