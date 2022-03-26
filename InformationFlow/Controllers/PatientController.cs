using Core.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformationFlow.Controllers
{
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientServce)
        {
            _patientService = patientServce;
        }

        public void AddBooking(Booking booking, Guid patientId)
        {
            _patientService.AddBooking(booking, patientId);
        }

        public void AddVaccination(Vaccination vaccination, Guid patientId)
        {

        }
    }
}
