using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class Diagnostics
    {
        [Key]
        public long DiagnosticsId { get; set; }
        [Required]
        public string DiagnosticsName { get; set; }
        [Required]
        public DateTime date { get; set; }
        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Diagnosis>  Diagnoses { get; set; }
    }
}