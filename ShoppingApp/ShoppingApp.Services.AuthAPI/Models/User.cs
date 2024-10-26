using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Services.AuthAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; } 
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string ShippingAddress { get; set; } = string.Empty; 
    }
}
