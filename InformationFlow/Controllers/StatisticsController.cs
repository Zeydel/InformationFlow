using Core.DTO;
using Core.IServices;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Controllers
{
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _statisticsService;
        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        public StatisticsDto GetDailyStatistics(DateTime date)
        {
            return _statisticsService.getDailyStatistics(date);
        }

        public StatisticsDto GetPeriodStatistics(DateTime start, DateTime end)
        {
            return _statisticsService.getPeriodStatistics(start, end);
        }
    }
}
