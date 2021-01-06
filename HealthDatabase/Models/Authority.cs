using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class Authority
    {
        [Key]
        public int AuthorityId { get; set; }
        [Required(ErrorMessage = "Name is required"), Display(Name = "Full Name")]
        public string Name { get; set; }
        public string Designation { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Organization { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }
        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}