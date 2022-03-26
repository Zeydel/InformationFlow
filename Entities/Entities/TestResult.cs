using Entities.Entities.Base;
using Entities.Enums;
using System;

namespace Entities.Entities
{
    public class TestResult : EntityBase
    {
        public DateTime TestTime { get; set; }

        /// <summary>
        /// The time that the result was made available
        /// </summary>
        public DateTime ResultTime { get; set; }
        public TestType TestType { get; set; }
        public TestResultType TestResultType { get; set; }
    }
}
