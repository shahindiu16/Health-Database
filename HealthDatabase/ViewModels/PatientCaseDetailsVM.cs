using HealthDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthDatabase.ViewModels
{
    public class PatientCaseDetailsVM
    {
        public long PatientId { get; set; }
        public string Name { get; set; }
        public DateTime DathOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }
        public string Description { get; set; }
        public string CaseDescription { get; set; }
        public DateTime Date { get; set; }
        public string HospitalName { get; set; }
        public string DeptName { get; set; }
        public string DoctorName { get; set; }
        public string AcademicDegree { get; set; }
        public string DoctorSpecialty { get; set; }
        public string Designation { get; set; }
        public long DiagnosticsId { get; set; }
        public string DiagnosticsName { get; set; }
        public string DiagnosisName { get; set; }
        public DiagnosisType Type { get; set; }
        public string DiagnosisResults { get; set; }
        public long PrescriptionId { get; set; }
        public string MedicineName { get; set; }
        public string MedicationSchedule { get; set; }
        public long SurgeryId { get; set; }
        public string SurgeryName { get; set; }
        public string SurgeryDescription { get; set; }

    }
}
