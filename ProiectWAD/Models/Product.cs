using ProiectWAD.Models;
using System.ComponentModel.DataAnnotations;

namespace ProiectWAD.Models
{
    public class Product : EntityClass
    {
        
        public int CategoryId { get; set; } //FK
        public Category Category { get; set; }
        public string? ProductName { get; set; }
        public float ProductPrice { get; set; }
        public string? ProductColour { get; set; }
        public ICollection<Seller> Sellers { get; set; }
    }
}

