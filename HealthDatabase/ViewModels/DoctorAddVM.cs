using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthDatabase.ViewModels
{
    public class DoctorAddVM
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string AcademicDegree { get; set; }
        public string Designation { get; set; }
        public string DoctorSpecialty { get; set; } 
        public string image { get; set; }
    }
}
