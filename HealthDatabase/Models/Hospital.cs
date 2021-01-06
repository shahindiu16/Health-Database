using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public HospitalType Type { get; set; }
        public string address { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<DoctorsChamber> DoctorsChambers { get; set; }
        public virtual ICollection<Diagnostics> Diagnostics { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        //public virtual ICollection<Doctor>  Doctors { get; set; }
        public virtual ICollection<Surgery> Surgeries { get; set; }
    }
    public enum HospitalType
    {
        Public, Private, Specialized
    }

}