using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BettingSpreadsheet.Server.Data;
using BettingSpreadsheet.Shared;
using Microsoft.EntityFrameworkCore;

namespace BettingSpreadsheet.Server.Services.BetService
{
    public class BetService : IBetService
    {
        private readonly DataContext _context;

        public BetService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Bet>> GetAllBets()
        {

            return await _context.Bets.ToListAsync();
        }

        public async Task AddNewBet(Bet bet)
        {
            _context.Bets.Add(bet);
            await _context.SaveChangesAsync();
        }
    }
}
