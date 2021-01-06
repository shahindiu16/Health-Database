using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HealthDatabase.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<CaseHistory> CaseHistories { get; set; }
        public DbSet<Diagnostics> Diagnostics { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<DoctorsChamber> DoctorsChambers { get; set; }
        public DbSet<Surgery>  Surgeries { get; set; }
        //public DbSet<OperationTheatre>  OperationTheatres { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CaseHistory>()
        //        .HasKey(x => new { x.PatientId, x.DiseaseId });
        //    modelBuilder.Entity<CaseHistory>()
        //        .HasOne(e => e.Disease)
        //        .WithMany(e => e.CaseHistories)
        //        .HasForeignKey(e => e.DiseaseId);
        //    modelBuilder.Entity<CaseHistory>()
        //        .HasOne(e => e.Patient)
        //        .WithMany(e => e.CaseHistories)
        //        .HasForeignKey(e => e.PatientId);

        //    modelBuilder.Entity<Appointment>()
        //        .HasKey(x => new { x.PatientId, x.HospitalId, x.PrescriptionId });
        //    modelBuilder.Entity<Appointment>()
        //        .HasOne(e => e.Patient)
        //        .WithMany(e => e.Appointments)
        //        .HasForeignKey(e => e.AppointmentId);
        //    modelBuilder.Entity<Appointment>()
        //        .HasOne(e => e.Hospital)
        //        .WithMany(e => e.Appointments)
        //        .HasForeignKey(e => e.HospitalId);
        //    modelBuilder.Entity<Appointment>()
        //       .HasOne(e => e.Prescription)
        //       .WithMany(e => e.Appointments)
        //       .HasForeignKey(e => e.PrescriptionId);

        //    modelBuilder.Entity<DoctorsChamber>()
        //        .HasKey(x => new { x.HospitalId, x.DoctorId });
        //    modelBuilder.Entity<DoctorsChamber>()
        //        .HasOne(e => e.Doctor)
        //        .WithMany(e => e.DoctorsChambers)
        //        .HasForeignKey(e => e.DoctorId);
        //    modelBuilder.Entity<DoctorsChamber>()
        //        .HasOne(e => e.Hospital)
        //        .WithMany(e => e.DoctorsChambers)
        //        .HasForeignKey(e => e.HospitalId);

        //    modelBuilder.Entity<Surgery>()
        //        .HasKey(x => new { x.DoctorId, x.HospitalId, x.PatientId });
        //    modelBuilder.Entity<Surgery>()
        //        .HasOne(e => e.Doctor)
        //        .WithMany(e => e.Surgeries)
        //        .HasForeignKey(e => e.DoctorId);
        //    modelBuilder.Entity<Surgery>()
        //        .HasOne(e => e.Hospital)
        //        .WithMany(e => e.Surgeries)
        //        .HasForeignKey(e => e.HospitalId);
        //    modelBuilder.Entity<Surgery>()
        //        .HasOne(e => e.Patient)
        //        .WithMany(e => e.Surgeries)
        //        .HasForeignKey(e => e.PatientId);
        //}
    }
    
}