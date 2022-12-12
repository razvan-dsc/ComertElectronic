using ProiectWAD.Models;
using System.ComponentModel.DataAnnotations;

namespace ProiectWAD.Models
{
    public class Category : EntityClass
    {

        public string? CategoryName { get; set; }
        public string? CategoryType { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
