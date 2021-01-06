using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required]
        public string DoctorName { get; set; }
        public string AcademicDegree { get; set; }
        public string DoctorSpecialty { get; set; }
        public string image { get; set; }
        [Required]
        public string Designation { get; set; }
        //[ForeignKey("Hospital")]
        //public int HospitalId { get; set; }
        //public virtual Hospital Hospital { get; set; }
        public virtual ICollection<DoctorsChamber> DoctorsChambers { get; set; }
        public virtual ICollection<Surgery> Surgeries { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        

    }
}