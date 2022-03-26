using Core.IRepositories.IBase;
using Entities.Entities;
using System;
using System.Collections.Generic;

namespace Core.IRepositories
{
    public interface ITestResultRepository : IRepositoryBase<TestResult>
    {
        public List<TestResult> GetTestResultsInPeriod(DateTime start, DateTime end);
    }
}
