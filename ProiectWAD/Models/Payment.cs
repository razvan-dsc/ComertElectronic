using ProiectWAD.Models;
using System.ComponentModel.DataAnnotations;

namespace ProiectWAD.Models
{
    public class Payment : EntityClass
    {   
       
        public int UserId { get; set; }
        public float PaymentAmount  { get; set; }
        public float Date { get; set; }
    }
}
