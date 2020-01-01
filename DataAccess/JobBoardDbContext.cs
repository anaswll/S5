using JobBoard.Entities.dbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace JobBoard.DataAccess
{
    public class JobBoardDbContext : IdentityDbContext<JBUser>
    {
        public JobBoardDbContext(DbContextOptions<JobBoardDbContext> options) : base(options)
        { }

        public DbSet<JBUser> User { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<JobOffer> JobOffer { get; set; }
        public DbSet<Educations> Educations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<WorkingExperience> WorkingExperiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JBUser>().ToTable("JBUser");
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Resume>().ToTable("Resume");

            //modelBuilder.ApplyConfiguration(new EducationConfiguration());
            //modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            //modelBuilder.ApplyConfiguration(new ResumeConfiguration());
            //modelBuilder.ApplyConfiguration(new SkillConfiguration());
            //modelBuilder.ApplyConfiguration(new WorkingExperienceConfiguration());

        }
    }
   
}
