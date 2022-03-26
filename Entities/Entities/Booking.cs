using Entities.Entities.Base;
using Entities.Enums;
using System;

namespace Entities.Entities
{
    public class Booking : EntityBase
    {
        public BookingType BookingType { get; set; }
        /// <summary>
        /// Comment entered by the patient when creating the booking
        /// </summary>
        public string PatientComment { get; set; }
        /// <summary>
        /// The time that the patient should show up for the booking
        /// </summary>
        public DateTime BookingTime { get; set; }
        /// <summary>
        /// The time shat the patient showed up for the booking. NULL if the patient has not shown up yet.
        /// </summary>
        public DateTime? ArrivalTime { get; set; }
    }
}
