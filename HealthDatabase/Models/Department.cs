using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DeptName { get; set; }
        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }

        public virtual Hospital Hospital { get; set; }
    }
}