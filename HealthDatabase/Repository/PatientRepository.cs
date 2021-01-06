using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthDatabase.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private ModelContext context;

        public PatientRepository(ModelContext context)
        {
            this.context = context;
        }
        public IEnumerable<Patient> GetPatient()
        {
            return context.Patients.ToList();
        }
        public void Insert(Patient patient)
        {
            context.Patients.Add(patient);
            context.SaveChanges();
        }
        public void Update(Patient patient)
        {
            context.Entry(patient).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(long PatientId)
        {
            Patient patient = context.Patients.Find(PatientId);
            context.Patients.Remove(patient);
            context.SaveChanges();
        }
        public Patient GetPatientByID(long PatientId)
        {
            return context.Patients.Find(PatientId);
        }
        IEnumerable<Patient> IPatientRepository.GetPatient()
        {
            return context.Patients.ToList();
        }
    }
}
