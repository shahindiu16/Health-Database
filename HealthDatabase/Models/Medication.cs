using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthDatabase.Models
{
    public class Medication
    {
        [Key]
        public long MedicationId { get; set; }
        public string MedicineName { get; set; }
        public string MedicationSchedule { get; set; }
        [ForeignKey("Prescription")]
        public long PrescriptionId { get; set; }
        public virtual Prescription Prescription { get; set; }
    }
}
