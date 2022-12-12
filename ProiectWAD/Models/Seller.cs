using ProiectWAD.Models;
using System.ComponentModel.DataAnnotations;

namespace ProiectWAD.Models
{
    public class Seller : EntityClass
    {
       
        public string SellerName { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } //FK
        public int SellerAddress { get; set; }
    }
}
