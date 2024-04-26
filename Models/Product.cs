using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceWebsite.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

    }
}
