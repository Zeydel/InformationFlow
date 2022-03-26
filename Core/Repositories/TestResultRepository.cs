using Core.IRepositories;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public class TestResultRepository : ITestResultRepository
    {
        public List<TestResult> GetTestResultsInPeriod(DateTime start, DateTime end)
        {
            return new List<TestResult>();
        }
    }
}
