using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthDatabase.Models
{
    public class DoctorsChamber
    {
        [Key]
        public int DoctorsChamberId { get; set; }

        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Doctor Doctor { get; set; }



    }
}