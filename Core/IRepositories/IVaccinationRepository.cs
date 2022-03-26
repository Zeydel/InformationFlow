using Core.IRepositories.IBase;
using Entities.Entities;
using System;
using System.Collections.Generic;

namespace Core.IRepositories
{
    public interface IVaccinationRepository : IRepositoryBase<Vaccination>
    {
        public List<Vaccination> GetVaccinationsInPeriod(DateTime start, DateTime end);
    }
}
