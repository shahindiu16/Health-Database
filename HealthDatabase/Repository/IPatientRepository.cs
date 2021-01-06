using HealthDatabase.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthDatabase.Repository
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatient();
        Patient GetPatientByID(long PatientId);
        void Insert(Patient patient);
        void Delete(long PatientId);
        void Update(Patient patient);
        
    }
}
