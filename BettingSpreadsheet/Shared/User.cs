using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BettingSpreadsheet.Shared
{
    public class User
    {
        public int Id { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Username { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Bio { get; set; }
        public List<Tipster> Tipsters { get; set; }
        public List<Bet> Bets { get; set; }
        public List<Sport> Sports { get; set; }
        public List<Bookie> Bookies { get; set; }
        public bool Public { get; set; } = true;
        public bool IsConfirmed { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
