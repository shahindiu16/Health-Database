using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthDatabase.Models
{
    public class OperationTheatre
    {
        [Key]
        public int OtId { get; set; }
        public DateTime Date { get; set; }
        //[ForeignKey("Surgery")]
        //public long SurgeryId { get; set; }
        //public virtual Surgery  Surgery { get; set; }
       
    }
}
