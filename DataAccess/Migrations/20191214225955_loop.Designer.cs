﻿// <auto-generated />
using System;
using JobBoard.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;

namespace JobBoard.DataAccess.Migrations
{
    [DbContext(typeof(JobBoardDbContext))]
    [Migration("20191214225955_loop")]
    partial class loop
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JobBoard.Entities.dbModels.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("entrepriseId");

                    b.Property<double>("capitalStock");

                    b.Property<DateTime>("creationDate");

                    b.Property<string>("location")
                        .IsRequired();

                    b.Property<long>("numOfEmployee");

                    b.Property<string>("sectorField")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EducationId");

                    b.Property<string>("AreaField")
                        .IsRequired();

                    b.Property<string>("Degree")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("ResumeId");

                    b.Property<string>("ResumeId1");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("University")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ResumeId1");

                    b.ToTable("education");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.JBUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("userId");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Adress");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("JBUser");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.JobOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OfferId");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnName("About");

                    b.Property<string>("CompanyId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Offer");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LanguageId");

                    b.Property<string>("LanguageTitle")
                        .IsRequired();

                    b.Property<int>("Level");

                    b.Property<int>("ResumeId");

                    b.Property<string>("ResumeId1");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId1");

                    b.ToTable("language");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.Resume", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ResumeId");

                    b.Property<string>("Address");

                    b.Property<int>("Age");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<int>("Experience");

                    b.Property<string>("FirstName");

                    b.Property<string>("Label")
                        .IsRequired();

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Resume");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SkillId");

                    b.Property<int>("Level");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ResumeId");

                    b.Property<string>("ResumeId1");

                    b.Property<int>("YearExperience");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId1");

                    b.ToTable("skill");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.WorkingExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("WExperienceId");

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("Descritpion")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Position")
                        .IsRequired();

                    b.Property<int>("ResumeId");

                    b.Property<string>("ResumeId1");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId1");

                    b.ToTable("workingexperience");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.Company", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.JBUser", "User")
                        .WithOne("Company")
                        .HasForeignKey("JobBoard.Entities.dbModels.Company", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.Education", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.Resume", "Resume")
                        .WithMany("ResumeEducations")
                        .HasForeignKey("ResumeId1");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.JobOffer", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.Company")
                        .WithMany("CompanyJobOffers")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.Language", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.Resume", "Resume")
                        .WithMany("ResumeLanguages")
                        .HasForeignKey("ResumeId1");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.Resume", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.JBUser", "User")
                        .WithOne("Resume")
                        .HasForeignKey("JobBoard.Entities.dbModels.Resume", "UserId");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.Skill", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.Resume", "Resume")
                        .WithMany("ResumeSkills")
                        .HasForeignKey("ResumeId1");
                });

            modelBuilder.Entity("JobBoard.Entities.dbModels.WorkingExperience", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.Resume", "Resume")
                        .WithMany("ResumeWorkingExperiences")
                        .HasForeignKey("ResumeId1");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.JBUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.JBUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JobBoard.Entities.dbModels.JBUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JobBoard.Entities.dbModels.JBUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}