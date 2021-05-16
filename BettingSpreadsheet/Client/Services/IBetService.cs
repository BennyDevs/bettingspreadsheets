using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BettingSpreadsheet.Shared;

namespace BettingSpreadsheet.Client.Services
{
    public interface IBetService
    {
        List<Bet> Bets { get; set; }
        Task<List<Bet>> LoadBetsAsync();
        Task<Bet> CreateNewBet(Bet bet);
        Task DeleteBet(int id);
    }
}
