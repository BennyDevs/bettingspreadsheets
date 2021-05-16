using System;
using System.Collections.Generic;

namespace BettingSpreadsheet.Shared
{
    public class Tipster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BetCount { get; set; }
        public int Won { get; set; }
        public int Lost { get; set; }
        public double AmountStaked { get; set; }
        public List<Bet> Bets { get; set; }
        public double ROI { get; set; }
        public double StartBank { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}