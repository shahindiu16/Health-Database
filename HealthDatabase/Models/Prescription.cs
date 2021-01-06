using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class Prescription
    {
        [Key]
        public long PrescriptionId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        //[ForeignKey("Patient")]
        //public long PatientId { get; set; }
        [ForeignKey("Appointment")]
        public long AppointmentId { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Appointment Appointment { get; set; }
        //public virtual ICollection<Appointment> Appointments { get; set; }
        //public virtual ICollection<Diagnosis> Diagnoses { get; set; }
        public virtual ICollection<Medication> Medications { get; set; }
    }
}