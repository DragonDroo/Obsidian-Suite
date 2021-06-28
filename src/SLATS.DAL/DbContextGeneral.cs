using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Slats.Models;

namespace Slats.DAL
{
    // Random Comment
    public partial class DbContextGeneral : DbContext
    {
        private bool _configured = false;
        public DbContextGeneral()
        {
            base.Database.EnsureCreated();
        }
        public DbContextGeneral(DbContextOptions<DbContextGeneral> options) : base(options) 
        {
            base.Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("PersonID");
                entity.Property(e => e.EmployeeId);
                entity.HasIndex(e => e.LastName);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.MiddleNames);
                entity.Property(e => e.SectionID);
                entity.Property(e => e.SupervAdminId);
                entity.Property(e => e.SupervAlt);
                entity.Property(e => e.NtId);
                entity.Property(e => e.VistaName);
                entity.HasOne(e => e.StaffPriv)
                .WithOne(f => f.Person)
                .HasForeignKey<StaffPriv>(e => e.PersonId);
         
            });

            modelBuilder.Entity<StaffProvider>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.ProviderClass);
                entity.Property(e => e.License);
                entity.HasIndex(e => e.ClinicalSuper);
            //TODO: Add Credential Link
                entity.Property(e => e.NPI);
                entity.Property(e => e.CprPoolIdPerm);
                entity.Property(e => e.CprPoolIdTemp);
                entity.Property(e => e.TaxonomyCode);
                entity.Property(e => e.UsualCosigner);
                entity.Property(e => e.UsualCosignerNid);
                entity.HasOne(e => e.Person)
                .WithMany(f => f.ProviderRoles)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Person_Provider");
            });

            modelBuilder.Entity<StaffAdmin>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.Position);
                entity.HasOne(e => e.Person)
                .WithMany(f => f.AdminRoles)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Person_Admin");
            });

            modelBuilder.Entity<MedPrivilegeProf>(entity =>
            {
                entity.Property(e => e.Id);
                entity.HasIndex(e => e.Expiration);
                entity.Property(e => e.Activation);
                entity.Property(e => e.PsbApproval);
                entity.Property(e => e.Comments);
                entity.HasOne(e => e.Provider)
                .WithMany(f => f.MedPrivilegeProf)
                .HasForeignKey(e => e.ProviderID)
                .HasConstraintName("FK_Provider_MedPrivProf");
                entity.HasMany(e => e.MedPrivilege);
            });

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.ProviderID);
                entity.HasOne(e => e.Provider)
                .WithMany(d => d.Clinics)
                .HasForeignKey(e => e.ProviderID)
                .HasConstraintName("FK_Provider_Clinic")
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SpecLicense>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.ProviderID);
                entity.Property(e => e.State);
                entity.Property(e => e.LicenseNum);
                entity.Property(e => e.LicenseText);
                entity.Property(e => e.Active);
                entity.Property(e => e.Expiration);
                entity.HasOne(e => e.Provider)
                .WithMany(d => d.SpecLicenses)
                .HasForeignKey(e => e.ProviderID)
                .HasConstraintName("FK_Provider_SpecLicense")
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MedPrivilege>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.ShortName);
                entity.Property(e => e.LongName);
                entity.Property(e => e.CptCode);
                entity.Property(e => e.DxCode);
                entity.HasOne(e => e.MedPrivilegeProf)
                .WithMany(d => d.MedPrivilege)
                .HasForeignKey(e => e.MedPrivilegeProfID)
                .HasConstraintName("FK_MedPrivProf_MedPriv")
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DeMeasure>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.DeValue);
                entity.Property(e => e.StaffID);
                entity.Property(e => e.Quarter);
                entity.HasOne(d => d.OsMetric);
            });

            modelBuilder.Entity<StaffPriv>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.PrivateEmail);
                entity.Property(e => e.CascadeNumber);
                entity.Property(e => e.CascadeAlt);
                entity.Property(e => e.CascadePager);
                entity.Property(e => e.StationEod);
                entity.Property(e => e.SCD);
                entity.Property(e => e.ServiceStart);
                entity.Property(e => e.ServiceSeperation);
                entity.Property(e => e.DoB);                
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.Number);
                entity.Property(e => e.Status);
                entity.Property(e => e.Budgeted);
                entity.Property(e => e.DepartmentId);
                entity.Property(e => e.JobCode);
                entity.Property(e => e.OfficialPositionTitle);
                entity.Property(e => e.OccSeries);
                entity.Property(e => e.ReportsTo);
                entity.Property(e => e.PdFsNumber);
                entity.Property(e => e.PayPlan);
                entity.Property(e => e.Fte);
                entity.Property(e => e.FteEquivalent);
                entity.Property(e => e.Grade);
                entity.Property(e => e.TargetFrade);
                entity.Property(e => e.BusCode);
                entity.Property(e => e.CostCenter);
                entity.Property(e => e.OrgCode);
                entity.Property(e => e.Location);
                entity.Property(e => e.LocationDescription);
                entity.Property(e => e.PosCreated);
                entity.Property(e => e.PosRetired);
            });

            modelBuilder.Entity<PositionAssigned>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.EndDate);
                entity.Property(e => e.StartDate);
                entity.HasOne(e => e.Person)
                .WithMany(f => f.PositionsAssigned)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Positions_Person");
                entity.HasOne(e => e.Position)
                .WithMany(f => f.PositionsAssigned)
                .HasForeignKey(e => e.PositionId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Positions_Position");
            });

            modelBuilder.Entity<CprPool>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.CprPoolName);
                entity.Property(e => e.Comment);
                entity.Property(e => e.AssignReview);
                entity.Property(e => e.ReviewForm);
                entity.Property(e => e.Effective);
                entity.Property(e => e.Retired);

            });
                
        }
        
        public DbSet<Permissions> UserPermissions { get; set; }
        public DbSet<SpecLicense> Licenses { get; set; }
        public DbSet<DeMetric> Metrics { get; set; }
        public DbSet<PositionAssigned> PositionsAssigned { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<StaffProvider> Providers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<CprPool> CprPools { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        //     public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Section> Ds_Sections { get; set; }
        public DbSet<FlipPageNode> FlipPageNodes { get; set; }
        public DbSet<FlipPageNote> FlipPageNotes { get; set; }
        public DbSet<MedPrivilege> MedPrivileges { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=products20.pmt");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }

    public class AdminContext : DbContext
    {
        //        public DbSet<EmailTemplate> EmailTemplates { get; set; }


        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=admin.db");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
            
        }
    }

    public class ReferenceContext : DbContext
    {
        //        public DbSet<EmailTemplate> EmailTemplates { get; set; }


        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=reference.db");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
