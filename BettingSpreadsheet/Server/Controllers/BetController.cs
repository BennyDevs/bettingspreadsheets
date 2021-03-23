using System.Collections.Generic;
using System.Threading.Tasks;
using BettingSpreadsheet.Server.Services.BetService;
using BettingSpreadsheet.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BettingSpreadsheet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {
        private readonly IBetService _betService;

        public BetController(IBetService betService)
        {
            _betService = betService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bet>>> GetAllBets()
        {
            return Ok(await _betService.GetAllBets());
        }

        [HttpPost]
        public async Task<ActionResult<Bet>> CreateNewBet(Bet request)
        {
            await _betService.AddNewBet(request);

            return request;
        }
    }
}
