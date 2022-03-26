using Core.IRepositories;
using Core.Repositories.RepositoryBase;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
    }
}
