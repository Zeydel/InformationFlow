using Core.DTO;
using System;

namespace Core.IServices
{
    public interface IStatisticsService
    {
        public StatisticsDto getDailyStatistics(DateTime date);
        public StatisticsDto getPeriodStatistics(DateTime start, DateTime end);
    }
}
