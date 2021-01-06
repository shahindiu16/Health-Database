using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class CaseHistory
    {
        [Key]
        public long CaseHistoryId { get; set; }
        [Required]
        public string CaseDescription { get; set; }
        [ForeignKey("Patient")]
        public long PatientId { get; set; }
        [ForeignKey("Disease")]
        public int DiseaseId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Disease  Disease { get; set; }
        

    }
}