using HealthDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthDatabase.ViewModels
{
    public class HospitalAddVM
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public HospitalType Type { get; set; }
        public string address { get; set; }
        
    }
}
