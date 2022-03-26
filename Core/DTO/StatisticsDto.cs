using Entities.Enums;
using System.Collections.Generic;

namespace Core.DTO
{
    public class StatisticsDto
    {
        public int VaccinationsInPeriod { get; set; }
        public Dictionary<VaccinationType, int> VaccinationsPerTypeInPeriod { get; set; } = new Dictionary<VaccinationType, int>();
        public int TestsInPeriod { get; set; }
        public Dictionary<TestType, int> TestsPerTypeInPeriod { get; set; } = new Dictionary<TestType, int>();
        public Dictionary<TestResultType, int> TestsPerResultTypeInPeriod { get; set; } = new Dictionary<TestResultType, int>();
    }
}
