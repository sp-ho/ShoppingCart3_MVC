using System.ComponentModel.DataAnnotations;

namespace ShoppingCart3.Models
{
    public class User
    {
        public string Id { get; set; }

        // validation to make sure the user enter input
        // always put these required statements right before the properties,
        // then the value will be applied to the properties
        [Required(ErrorMessage = "Please enter username")]
        public string Username { get; set; }

        // validation to make sure enter input and correctly
        // always put these required statements right before the properties,
        // then the value will be applied to the properties
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
