using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthDatabase.Models
{
    public class Diagnosis
    {
        [Key]
        public long DiagnosisId { get; set; }

        public string DiagnosisName { get; set; }
        public DateTime Date { get; set; }
        public DiagnosisType Type { get; set; }
        public string Description { get; set; }
        [ForeignKey("Diagnostics")]
        public long DiagnosticsId { get; set; }
        //[ForeignKey("Prescription")]
        //public long PrescriptionId { get; set; }
        public virtual Diagnostics Diagnostics { get; set; }
        //public virtual Prescription Prescription { get; set; }


    }
    public  enum DiagnosisType
    {
        Radiology, Pathology, Others
    }
}
