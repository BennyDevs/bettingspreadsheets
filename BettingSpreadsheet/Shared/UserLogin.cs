using System;
using System.ComponentModel.DataAnnotations;

namespace BettingSpreadsheet.Shared
{
    public class UserLogin
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
