using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BettingSpreadsheet.Shared;

namespace BettingSpreadsheet.Client.Services
{
    public class BetService : IBetService
    {
        private readonly HttpClient _http;

        public BetService(HttpClient http)
        {
            _http = http;
        }

        public List<Bet> Bets { get; set; } = new List<Bet>();

        public async Task<List<Bet>> LoadBetsAsync()
        {
            return Bets = await _http.GetFromJsonAsync<List<Bet>>($"api/Bet");
        }

        public async Task<Bet> CreateNewBet(Bet request)
        {
            var result = await _http.PostAsJsonAsync("api/Bet", request);
            return await result.Content.ReadFromJsonAsync<Bet>();
        }
    }
}