using ProiectWAD.Models;
using System.ComponentModel.DataAnnotations;

namespace ProiectWAD.Models
{
    public class ShoppingOrder : EntityClass
    {
       
        public int UserId { get; set; }
        public int OrderQuantity { get; set; }
        public float OrderDate { get; set; }
    }
}
