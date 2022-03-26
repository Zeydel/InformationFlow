using Core.IRepositories;
using Core.Repositories.RepositoryBase;
using Entities.Entities;
using System;
using System.Collections.Generic;

namespace Core.Repositories
{
    public class VaccinationRepository : RepositoryBase<Vaccination>, IVaccinationRepository
    {
        public List<Vaccination> GetVaccinationsInPeriod(DateTime start, DateTime end)
        {
            return new List<Vaccination>();
        }
    }
}
