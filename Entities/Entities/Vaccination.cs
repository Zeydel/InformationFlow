using Entities.Entities.Base;
using Entities.Enums;
using System;

namespace Entities.Entities
{
    public class Vaccination : EntityBase
    {
        public DateTime VaccinationTime { get; set; }
        public VaccinationType VaccinationType { get; set; }
        /// <summary>
        /// The booking that was made ahead of the vaccination
        /// </summary>
        public string Comment { get; set; }
    }
}
