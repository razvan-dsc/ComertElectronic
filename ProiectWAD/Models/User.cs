using Microsoft.AspNetCore.Identity;
using ProiectWAD.Models;
using System.ComponentModel.DataAnnotations;

namespace ProiectWAD.Models
{
    public class User : IdentityUser
    {
        public string UserAddress { get; set; }

    }
}
