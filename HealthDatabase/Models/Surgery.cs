using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthDatabase.Models
{
    public class Surgery
    {
        [Key]
        public long SurgeryId { get; set; }
        public string SurgeryName { get; set; }
        public string SurgeryDescription { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Patient")]
        public long PatientId { get; set; }
        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Doctor Doctor { get; set; }
        //public virtual ICollection<Surgery> Surgeries  { get; set; }
    }
}
