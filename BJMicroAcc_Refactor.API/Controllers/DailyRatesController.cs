using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BJMicroAcc_Refactor.API.Controllers
{
    [ApiController]
    [Route("api/dailyrates")]
    public class DailyRatesController : ControllerBase
    {
        private readonly IDailyRateService _dailyRateService;

        public DailyRatesController(IDailyRateService dailyRateService)
        {
            _dailyRateService = dailyRateService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var rates = await _dailyRateService.GetAllAsync();
            return Ok(rates);
        }

        [HttpGet("date/{date}")]
        public async Task<IActionResult> GetByDate(DateTime date)
        {
            var rate = await _dailyRateService.GetByDateAsync(date);
            if (rate == null) return NotFound();
            return Ok(rate);
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var rate = await _dailyRateService.GetByIdAsync(id);
            if (rate == null) return NotFound();
            return Ok(rate);
        }

        [HttpGet("range")]
        public async Task<IActionResult> GetByDateRange(DateTime fromDate, DateTime toDate)
        {
            var rates = await _dailyRateService.GetRatesByDateRange(fromDate, toDate);
            if (rates == null) return NotFound();
            return Ok(rates);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDailyRateDto rate)
        {
            if (rate == null) return BadRequest();
            await _dailyRateService.AddAsync(rate);
            return Ok();
        }

        [HttpPut()]
        public async Task<IActionResult> Update([FromBody] UpdateDailyRateDto rate)
        {
            if (rate == null) return BadRequest();

            await _dailyRateService.UpdateAsync(rate);
            return Ok();
        }


    }
}
