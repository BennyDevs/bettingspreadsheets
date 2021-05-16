using System;
using System.ComponentModel.DataAnnotations;

namespace BettingSpreadsheet.Shared
{
    public class UserRegister
    {
        [Required]
        public string Email { get; set; }
        [Required, StringLength(20, ErrorMessage = "Max length of username is 20 characters.")]
        public string Username { get; set; }
        [StringLength(180, ErrorMessage = "Max length of bio is 180 characters.")]
        public string Bio { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        public bool IsConfirmed { get; set; }
    }
}
