using Entities.Entities;
using System;

namespace Core.IServices
{
    public interface IPatientService
    {
        public void AddBooking(Booking booking, Guid patientId);
        public void AddVaccination(Vaccination vaccination, Guid patientId);
    }
}
