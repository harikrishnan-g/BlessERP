using System.ComponentModel.DataAnnotations;

namespace BlessERP.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength = 4, ErrorMessage = "You must enter minimum 4 letter")]
        public string Password { get; set; }
    }
}