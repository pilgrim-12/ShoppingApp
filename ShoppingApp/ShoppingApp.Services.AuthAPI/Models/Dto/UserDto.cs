namespace ShoppingApp.Services.AuthAPI.Models.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; } 
        public required string Password { get; set; }
        public required string Email { get; set; }
        public string ShippingAddress { get; set; } = string.Empty; 
    }
}
