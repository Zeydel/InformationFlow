using Entities.Entities.Base;
using Entities.Enums;
using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class Patient : EntityBase
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CprNumber { get; set; }
        /// <summary>
        /// Measured in centimeters
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Measured in kilos
        /// </summary>
        public decimal Weight { get; set; }
        public DateTime TimeOfBirth { get; set; }
        public Gender Gender { get; set; }
        public EyeColor EyeColor { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Vaccination> Vaccines { get; set; }
    }
}
