using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class Disease
    {
        [Key]
        public int DiseaseId { get; set; }
        [Required]
        public DiseaseType Type { get; set; }
        public string DiseaseName  { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<CaseHistory>  CaseHistories { get; set; }
    }
    public enum DiseaseType
    {
        Communicable, Noncommunicable
    }
}