﻿// <auto-generated />
using System;
using HealthDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthDatabase.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20201019171329_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthDatabase.Models.Appointment", b =>
                {
                    b.Property<long>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("HospitalId");

                    b.Property<long>("PatientId");

                    b.HasKey("AppointmentId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("HealthDatabase.Models.Authority", b =>
                {
                    b.Property<int>("AuthorityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .IsRequired();

                    b.Property<string>("Designation");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Organization")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<long>("UserId");

                    b.HasKey("AuthorityId");

                    b.HasIndex("UserId");

                    b.ToTable("Authorities");
                });

            modelBuilder.Entity("HealthDatabase.Models.CaseHistory", b =>
                {
                    b.Property<long>("CaseHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaseDescription")
                        .IsRequired();

                    b.Property<int>("DiseaseId");

                    b.Property<long>("PatientId");

                    b.HasKey("CaseHistoryId");

                    b.HasIndex("DiseaseId");

                    b.HasIndex("PatientId");

                    b.ToTable("CaseHistories");
                });

            modelBuilder.Entity("HealthDatabase.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptName")
                        .IsRequired();

                    b.Property<int>("HospitalId");

                    b.HasKey("DepartmentId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HealthDatabase.Models.Diagnosis", b =>
                {
                    b.Property<long>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("DiagnosisName");

                    b.Property<long>("DiagnosticsId");

                    b.Property<int>("Type");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("DiagnosticsId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("HealthDatabase.Models.Diagnostics", b =>
                {
                    b.Property<long>("DiagnosticsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiagnosticsName")
                        .IsRequired();

                    b.Property<int>("HospitalId");

                    b.Property<DateTime>("date");

                    b.HasKey("DiagnosticsId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Diagnostics");
                });

            modelBuilder.Entity("HealthDatabase.Models.Disease", b =>
                {
                    b.Property<int>("DiseaseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("DiseaseName");

                    b.Property<int>("Type");

                    b.HasKey("DiseaseId");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("HealthDatabase.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcademicDegree");

                    b.Property<string>("Designation")
                        .IsRequired();

                    b.Property<string>("DoctorName")
                        .IsRequired();

                    b.Property<string>("DoctorSpecialty");

                    b.Property<string>("image");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HealthDatabase.Models.DoctorsChamber", b =>
                {
                    b.Property<int>("DoctorsChamberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorId");

                    b.Property<int>("HospitalId");

                    b.Property<long?>("PatientId");

                    b.HasKey("DoctorsChamberId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorsChambers");
                });

            modelBuilder.Entity("HealthDatabase.Models.Hospital", b =>
                {
                    b.Property<int>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HospitalName");

                    b.Property<int>("Type");

                    b.Property<string>("address");

                    b.HasKey("HospitalId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("HealthDatabase.Models.Medication", b =>
                {
                    b.Property<long>("MedicationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MedicationSchedule");

                    b.Property<string>("MedicineName");

                    b.Property<long>("PrescriptionId");

                    b.HasKey("MedicationId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("HealthDatabase.Models.Patient", b =>
                {
                    b.Property<long>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<DateTime>("DathOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FathersName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Gender");

                    b.Property<string>("MothersName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NID_BirthCertificate_Passport")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Occupation")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HealthDatabase.Models.Prescription", b =>
                {
                    b.Property<long>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AppointmentId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int?>("DoctorId");

                    b.Property<long?>("PatientId");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("HealthDatabase.Models.Surgery", b =>
                {
                    b.Property<long>("SurgeryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("DoctorId");

                    b.Property<int>("HospitalId");

                    b.Property<long>("PatientId");

                    b.Property<string>("SurgeryDescription");

                    b.Property<string>("SurgeryName");

                    b.HasKey("SurgeryId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PatientId");

                    b.ToTable("Surgeries");
                });

            modelBuilder.Entity("HealthDatabase.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<string>("userName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HealthDatabase.Models.Appointment", b =>
                {
                    b.HasOne("HealthDatabase.Models.Hospital", "Hospital")
                        .WithMany("Appointments")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthDatabase.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthDatabase.Models.Authority", b =>
                {
                    b.HasOne("HealthDatabase.Models.User", "User")
                        .WithMany("Authority")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthDatabase.Models.CaseHistory", b =>
                {
                    b.HasOne("HealthDatabase.Models.Disease", "Disease")
                        .WithMany("CaseHistories")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthDatabase.Models.Patient", "Patient")
                        .WithMany("CaseHistories")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthDatabase.Models.Department", b =>
                {
                    b.HasOne("HealthDatabase.Models.Hospital", "Hospital")
                        .WithMany("Departments")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthDatabase.Models.Diagnosis", b =>
                {
                    b.HasOne("HealthDatabase.Models.Diagnostics", "Diagnostics")
                        .WithMany("Diagnoses")
                        .HasForeignKey("DiagnosticsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthDatabase.Models.Diagnostics", b =>
                {
                    b.HasOne("HealthDatabase.Models.Hospital", "Hospital")
                        .WithMany("Diagnostics")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthDatabase.Models.DoctorsChamber", b =>
                {
                    b.HasOne("HealthDatabase.Models.Doctor", "Doctor")
                        .WithMany("DoctorsChambers")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthDatabase.Models.Hospital", "Hospital")
                        .WithMany("DoctorsChambers")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthDatabase.Models.Patient")
                        .WithMany("DoctorsChambers")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("HealthDatabase.Models.Medication", b =>
                {
                    b.HasOne("HealthDatabase.Models.Prescription", "Prescription")
                        .WithMany("Medications")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthDatabase.Models.Prescription", b =>
                {
                    b.HasOne("HealthDatabase.Models.Appointment", "Appointment")
                        .WithMany("Prescriptions")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthDatabase.Models.Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId");

                    b.HasOne("HealthDatabase.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("HealthDatabase.Models.Surgery", b =>
                {
                    b.HasOne("HealthDatabase.Models.Doctor", "Doctor")
                        .WithMany("Surgeries")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthDatabase.Models.Hospital", "Hospital")
                        .WithMany("Surgeries")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthDatabase.Models.Patient", "Patient")
                        .WithMany("Surgeries")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
