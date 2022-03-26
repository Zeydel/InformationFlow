using Core.IRepositories;
using Core.IServices;
using Entities.Entities;
using System;

namespace Core.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public void AddBooking(Booking booking, Guid patientId)
        {
            var patient = _patientRepository.Get(patientId);

            patient.Bookings.Add(booking);

            _patientRepository.Update(patient);
        }

        public void AddVaccination(Vaccination vaccination, Guid patientId)
        {
            var patient = _patientRepository.Get(patientId);

            patient.Vaccines.Add(vaccination);

            _patientRepository.Update(patient);
        }
    }
}
