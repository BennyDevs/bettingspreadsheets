using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BettingSpreadsheet.Shared;

namespace BettingSpreadsheet.Server.Services.BetService
{
    public interface IBetService
    {
        Task<List<Bet>> GetAllBets();
        Task AddNewBet(Bet bet);
    }
}
