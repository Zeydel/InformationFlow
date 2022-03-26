using Core.DTO;
using Core.IRepositories;
using Core.IServices;
using Entities.Enums;
using System;
using System.Linq;

namespace Core.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IVaccinationRepository _vaccinationRepository;
        private readonly ITestResultRepository _testResultRepository;
        public StatisticsService(IVaccinationRepository vaccinationRepository, ITestResultRepository testResultRepository)
        {
            _vaccinationRepository = vaccinationRepository;
            _testResultRepository = testResultRepository;
        }

        public StatisticsDto getDailyStatistics(DateTime day)
        {
            var start = day.Date;
            var end = start.AddDays(1).AddTicks(-1);

            return getPeriodStatistics(start, end);
        }

        public StatisticsDto getPeriodStatistics(DateTime start, DateTime end)
        {
            var statistics = new StatisticsDto();

            var vaccinations = _vaccinationRepository.GetVaccinationsInPeriod(start, end);

            statistics.VaccinationsInPeriod = vaccinations.Count;

            foreach (VaccinationType type in Enum.GetValues(typeof(VaccinationType)))
                statistics.VaccinationsPerTypeInPeriod[type] = vaccinations.Where(v => v.VaccinationType == type).Count();

            var testResults = _testResultRepository.GetTestResultsInPeriod(start, end);

            statistics.TestsInPeriod = testResults.Count;

            foreach (TestResultType type in Enum.GetValues(typeof(TestResultType)))
                statistics.TestsPerResultTypeInPeriod[type] = testResults.Where(tr => tr.TestResultType == type).Count();

            foreach (TestType type in Enum.GetValues(typeof(TestType)))
                statistics.TestsPerTypeInPeriod[type] = testResults.Where(tr => tr.TestType == type).Count();

            return statistics;
        }
    }
}
