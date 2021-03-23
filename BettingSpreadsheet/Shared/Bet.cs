using System;
using System.ComponentModel.DataAnnotations;

namespace BettingSpreadsheet.Shared
{
    public class Bet
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Match { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Selection { get; set; }
        public string League { get; set; }
        public DateTime? MatchDate { get; set; } = DateTimeOffset.Now.Date;
        public TimeSpan? MatchTime { get; set; } = new TimeSpan(00, 00, 00);
        [Range(0.01, 100000000, ErrorMessage = "This field is required.")]
        public double Stake { get; set; }
        [Range(0.01, 100000000, ErrorMessage = "This field is required.")]
        public double Odds { get; set; }
        public double ClosingOdds { get; set; }
        public string Tipster { get; set; }
        public string Bookie { get; set; }
        public string Sport { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string State { get; set; } = "New";
        public bool Locked { get; set; }
        public DateTime BetCreated { get; set; } = DateTime.Now;
    }
}
