using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
        public virtual ICollection<Authority> Authority { get; set; }
        
    }
}