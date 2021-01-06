using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthDatabase.Models
   
{
    public class Appointment
    {
        [Key]
        public long AppointmentId { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Patient")]
        public long PatientId { get; set; }
        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}