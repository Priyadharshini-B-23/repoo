﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recruitment_Portal_Project.Data;

#nullable disable

namespace Recruitment_Portal_Project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240325090614_edd")]
    partial class edd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Recruitment_Portal_Project.Models.ApplicationDetailsModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("JobID")
                        .HasColumnType("int");

                    b.Property<string>("JobProviderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("JobSeekerID")
                        .HasColumnType("int");

                    b.Property<string>("PreferredLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("JobID");

                    b.HasIndex("JobSeekerID");

                    b.ToTable("ApplicationDetails");
                });

            modelBuilder.Entity("Recruitment_Portal_Project.Models.JobDetailsModel", b =>
                {
                    b.Property<int>("JobID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("JobID"));

                    b.Property<string>("AboutCompany")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmployeeType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("JobProviderID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("JobID");

                    b.HasIndex("JobProviderID");

                    b.ToTable("JobDetails");
                });

            modelBuilder.Entity("Recruitment_Portal_Project.Models.JobProviderSignupModel", b =>
                {
                    b.Property<int>("JobProviderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("JobProviderID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobProviderCompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobProviderCompanyType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobProviderConfirmPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobProviderEmailId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobProviderLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobProviderPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("JobProviderPhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("JobProviderID");

                    b.ToTable("ProviderSignup");
                });

            modelBuilder.Entity("Recruitment_Portal_Project.Models.JobSeekerSignupModel", b =>
                {
                    b.Property<int>("JobSeekerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("JobSeekerID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobSeekerConfirmPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobSeekerEmailId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobSeekerPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("JobSeekerPhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("JobSeekerQualification")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("JobSeekerID");

                    b.ToTable("SeekerSignup");
                });

            modelBuilder.Entity("Recruitment_Portal_Project.Models.PdfDocumentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("FIelData")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("JobSeekerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("JobSeekerID");

                    b.ToTable("PdfDocument");
                });

            modelBuilder.Entity("Recruitment_Portal_Project.Models.ProfileModel", b =>
                {
                    b.Property<int>("JobSeekerRegistrationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("JobSeekerRegistrationID"));

                    b.Property<float>("CGPA")
                        .HasColumnType("float");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("JobSeekerSignupModel")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Resume")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("SkillSet")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("TenthPercentage")
                        .HasColumnType("float");

                    b.Property<float>("TwelvethPercentage")
                        .HasColumnType("float");

                    b.Property<string>("UniqueFileName")
                        .HasColumnType("longtext");

                    b.HasKey("JobSeekerRegistrationID");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("Recruitment_Portal_Project.Models.ApplicationDetailsModel", b =>
                {
                    b.HasOne("Recruitment_Portal_Project.Models.JobDetailsModel", "jobId")
                        .WithMany()
                        .HasForeignKey("JobID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recruitment_Portal_Project.Models.JobSeekerSignupModel", "SeekerSignupModel")
                        .WithMany()
                        .HasForeignKey("JobSeekerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SeekerSignupModel");

                    b.Navigation("jobId");
                });

            modelBuilder.Entity("Recruitment_Portal_Project.Models.JobDetailsModel", b =>
                {
                    b.HasOne("Recruitment_Portal_Project.Models.JobProviderSignupModel", "SignupModel")
                        .WithMany()
                        .HasForeignKey("JobProviderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SignupModel");
                });

            modelBuilder.Entity("Recruitment_Portal_Project.Models.PdfDocumentModel", b =>
                {
                    b.HasOne("Recruitment_Portal_Project.Models.JobSeekerSignupModel", "JobSeekerId")
                        .WithMany()
                        .HasForeignKey("JobSeekerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobSeekerId");
                });
#pragma warning restore 612, 618
        }
    }
}
