using Core.IRepositories;
using Entities.Entities;
using System;
using System.Collections.Generic;

namespace Core.Repositories
{
    public class VaccinationRepository : IVaccinationRepository
    {
        public List<Vaccination> GetVaccinationsInPeriod(DateTime start, DateTime end)
        {
            return new List<Vaccination>();
        }
    }
}
