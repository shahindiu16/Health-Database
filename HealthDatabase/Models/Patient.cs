using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthDatabase.Models
{
    public class Patient
    {
        [Key]
        public long PatientId { get; set; }
        [Required(ErrorMessage = "Name is required"), StringLength(100), Display(Name ="Full Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Father's name is required"), StringLength(100), Display(Name = "Father's Name")]
        public string FathersName { get; set; }
        [Required(ErrorMessage = "Father's name is required"), StringLength(100), Display(Name = "Mother's Name")]
        public string MothersName { get; set; }
        [Required(ErrorMessage = "Date of Birth is required"), Display(Name = "Date of Birth")]
        public DateTime DathOfBirth { get; set; }
        [Required]
        public string Occupation { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }
        [Required] 
        public string NID_BirthCertificate_Passport { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<CaseHistory> CaseHistories { get; set; }
        public virtual ICollection<Surgery> Surgeries { get; set; }
        public virtual ICollection<DoctorsChamber>  DoctorsChambers { get; set; }
    }
    public enum Gender
    {
        Male, Female, Others
    }
}