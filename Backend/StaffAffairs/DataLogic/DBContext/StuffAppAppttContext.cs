using System;
using System.Collections.Generic;
using StaffAffairs.DataLayer.Models;
using Microsoft.EntityFrameworkCore;


namespace StaffAffairs.DataLayer.DBContext
{
    public partial class StuffAppAppttContext : DbContext
    {
        public StuffAppAppttContext()
        {
        }

        public StuffAppAppttContext(DbContextOptions<StuffAppAppttContext> options) : base(options)
        {
        }


        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<DayName> DayNames { get; set; }

        public virtual DbSet<Degree> Degrees { get; set; }

        public virtual DbSet<Dept> Depts { get; set; }

        public virtual DbSet<Email> Emails { get; set; }

        public virtual DbSet<EntedabType> EntedabTypes { get; set; }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<EventActivity> EventActivities { get; set; }

        public virtual DbSet<EventImage> EventImages { get; set; }

        public virtual DbSet<Fac> Facs { get; set; }

        public virtual DbSet<Grade> Grades { get; set; }

        public virtual DbSet<Job> Jobs { get; set; }

        public virtual DbSet<JobType> JobTypes { get; set; }

        public virtual DbSet<LastAllowanceDate> LastAllowanceDates { get; set; }

        public virtual DbSet<MilitaryState> MilitaryStates { get; set; }

        public virtual DbSet<Montadab> Montadabs { get; set; }

        public virtual DbSet<Month> Months { get; set; }

        public virtual DbSet<Nationality> Nationalities { get; set; }

        public virtual DbSet<News> News { get; set; }

        public virtual DbSet<Place> Places { get; set; }

        public virtual DbSet<PlaceType> PlaceTypes { get; set; }

        public virtual DbSet<PlaceUser> PlaceUsers { get; set; }

        public virtual DbSet<PunishType> PunishTypes { get; set; }

        public virtual DbSet<QmemberJobsBefor> QmemberJobsBefors { get; set; }

        public virtual DbSet<Qualify> Qualifys { get; set; }

        public virtual DbSet<RelationType> RelationTypes { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<RoleClaim> RoleClaims { get; set; }

        public virtual DbSet<ScientificLevel> ScientificLevels { get; set; }

        public virtual DbSet<Setting> Settings { get; set; }

        public virtual DbSet<Social> Socials { get; set; }

        public virtual DbSet<Specialisation> Specialisations { get; set; }

        public virtual DbSet<StaffCourse> StaffCourses { get; set; }

        public virtual DbSet<StaffDegree> StaffDegrees { get; set; }

        public virtual DbSet<StaffJob> StaffJobs { get; set; }

        public virtual DbSet<StaffMember> StaffMembers { get; set; }

        public virtual DbSet<StaffPunish> StaffPunishs { get; set; }

        public virtual DbSet<StaffQualify> StaffQualifys { get; set; }

        public virtual DbSet<StaffRelation> StaffRelations { get; set; }

        public virtual DbSet<StaffVac> StaffVacs { get; set; }

        public virtual DbSet<Transaction> Transactions { get; set; }

        public virtual DbSet<Univ> Univs { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserClaim> UserClaims { get; set; }

        public virtual DbSet<UserLogin> UserLogins { get; set; }

        public virtual DbSet<UserToken> UserTokens { get; set; }

        public virtual DbSet<VacType> VacTypes { get; set; }

        public virtual DbSet<View1> View1s { get; set; }

        public virtual DbSet<WorkStatus> WorkStatuses { get; set; }

#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=IUGYI\\SQLEXPRESS;Initial Catalog=StuffAppApptt;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;Command Timeout=300");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.NameEn).HasMaxLength(100);
            });

            modelBuilder.Entity<DayName>(entity =>
            {
                entity.Property(e => e.Language).HasMaxLength(30);
                entity.Property(e => e.Name).HasMaxLength(30);
                entity.Property(e => e.NameEn).HasMaxLength(30);
            });

            modelBuilder.Entity<Degree>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasIndex(e => e.FacId, "IX_Depts_FacId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Fac).WithMany(p => p.Depts).HasForeignKey(d => d.FacId);
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("EMails");

                entity.Property(e => e.Code).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.Title).HasMaxLength(255);
                entity.Property(e => e.TitleEn).HasMaxLength(255);
            });

            modelBuilder.Entity<EntedabType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Cdate).HasColumnName("CDate");
                entity.Property(e => e.Header).HasMaxLength(300);
                entity.Property(e => e.HeaderEn).HasMaxLength(300);
                entity.Property(e => e.Image).HasMaxLength(100);
            });

            modelBuilder.Entity<EventActivity>(entity =>
            {
                entity.Property(e => e.Cdate).HasColumnName("CDate");
                entity.Property(e => e.Header).HasMaxLength(300);
                entity.Property(e => e.HeaderEn).HasMaxLength(300);
                entity.Property(e => e.Image).HasMaxLength(100);
            });

            modelBuilder.Entity<Fac>(entity =>
            {
                entity.HasIndex(e => e.UnivId, "IX_Facs_UnivId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Univ).WithMany(p => p.Facs).HasForeignKey(d => d.UnivId);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasIndex(e => e.JobTypeId, "IX_Jobs_JobTypeId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.JobType).WithMany(p => p.Jobs).HasForeignKey(d => d.JobTypeId);
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<LastAllowanceDate>(entity =>
            {
                entity.HasIndex(e => e.StaffMemberNationalId, "IX_LastAllowanceDates_StaffMemberNationalId");

                entity.HasOne(d => d.StaffMemberNational).WithMany(p => p.LastAllowanceDates).HasForeignKey(d => d.StaffMemberNationalId);
            });

            modelBuilder.Entity<MilitaryState>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Month>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationality");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Cdate).HasColumnName("CDate");
                entity.Property(e => e.Header).HasMaxLength(300);
                entity.Property(e => e.HeaderEn).HasMaxLength(300);
                entity.Property(e => e.Image).HasMaxLength(100);
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<PunishType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<QmemberJobsBefor>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("QMemberJobsBefor");

                entity.Property(e => e.DescisionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("descision_date");
                entity.Property(e => e.DescisionNo)
                    .HasMaxLength(255)
                    .HasColumnName("descision_no");
                entity.Property(e => e.EndJobDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_job_date");
                entity.Property(e => e.EntedabType).HasColumnName("Entedab_type");
                entity.Property(e => e.JobDate)
                    .HasColumnType("datetime")
                    .HasColumnName("job_date");
                entity.Property(e => e.JobDescription)
                    .HasMaxLength(200)
                    .HasColumnName("job_description");
                entity.Property(e => e.JobPlace)
                    .HasMaxLength(50)
                    .HasColumnName("job_place");
                entity.Property(e => e.NationNumber)
                    .HasMaxLength(50)
                    .HasColumnName("nation_number");
                entity.Property(e => e.PartId)
                    .HasMaxLength(15)
                    .HasColumnName("part_id");
            });

            modelBuilder.Entity<Qualify>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<RelationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);
                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<RoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_RoleClaims_RoleId");

                entity.HasOne(d => d.Role).WithMany(p => p.RoleClaims).HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<ScientificLevel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Name).HasMaxLength(25);
                entity.Property(e => e.NameEn).HasMaxLength(25);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.CurrentAcademicYear).HasMaxLength(100);
                entity.Property(e => e.NotAvailableMessage).HasMaxLength(300);
                entity.Property(e => e.PlaceAvailable).HasColumnName("placeAvailable");
                entity.Property(e => e.PlaceUpdateAvailable).HasColumnName("placeUpdateAvailable");
            });

            modelBuilder.Entity<Social>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Specialisation>(entity =>
            {
                entity.HasIndex(e => e.DeptId, "IX_Specialisations_DeptId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Dept).WithMany(p => p.Specialisations).HasForeignKey(d => d.DeptId);
            });

            modelBuilder.Entity<StaffCourse>(entity =>
            {
                entity.HasIndex(e => e.StaffMemberNationalId, "IX_StaffCourses_StaffMemberNationalId");

                entity.HasOne(d => d.StaffMemberNational).WithMany(p => p.StaffCourses).HasForeignKey(d => d.StaffMemberNationalId);
            });

            modelBuilder.Entity<StaffDegree>(entity =>
            {
                entity.HasIndex(e => e.DegreeId, "IX_StaffDegrees_DegreeId");

                entity.HasIndex(e => e.StaffMemberNationalId, "IX_StaffDegrees_StaffMemberNationalId");

                entity.HasOne(d => d.Degree).WithMany(p => p.StaffDegrees).HasForeignKey(d => d.DegreeId);

                entity.HasOne(d => d.StaffMemberNational).WithMany(p => p.StaffDegrees).HasForeignKey(d => d.StaffMemberNationalId);
            });

            modelBuilder.Entity<StaffJob>(entity =>
            {
                entity.HasIndex(e => e.JobId, "IX_StaffJobs_JobId");

                entity.HasIndex(e => e.StaffMemberNationalId, "IX_StaffJobs_StaffMemberNationalId");

                entity.Property(e => e.JobDecisionDate).HasColumnType("datetime");
                entity.Property(e => e.JobEndtDate).HasColumnType("datetime");
                entity.Property(e => e.JobStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Job).WithMany(p => p.StaffJobs).HasForeignKey(d => d.JobId);

                entity.HasOne(d => d.StaffMemberNational).WithMany(p => p.StaffJobs)
                    .HasForeignKey(d => d.StaffMemberNationalId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<StaffMember>(entity =>
            {
                entity.HasKey(e => e.NationalId);

                entity.HasIndex(e => e.DeptId, "IX_StaffMembers_DeptId");

                entity.HasIndex(e => e.MilitaryStateId, "IX_StaffMembers_MilitaryStateId");

                entity.HasIndex(e => e.NationalityId, "IX_StaffMembers_NationalityId");

                entity.HasIndex(e => e.SocialId, "IX_StaffMembers_SocialId");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");
                entity.Property(e => e.EndWorkDate).HasColumnType("datetime");
                entity.Property(e => e.SpecialiseId).HasMaxLength(50);
            });

            modelBuilder.Entity<StaffPunish>(entity =>
            {
                entity.HasIndex(e => e.PunishtypeId, "IX_StaffPunishs_PunishtypeId");

                entity.HasIndex(e => e.StaffMemberNationalId, "IX_StaffPunishs_StaffMemberNationalId");

                entity.HasOne(d => d.Punishtype).WithMany(p => p.StaffPunishes).HasForeignKey(d => d.PunishtypeId);

                entity.HasOne(d => d.StaffMemberNational).WithMany(p => p.StaffPunishes).HasForeignKey(d => d.StaffMemberNationalId);
            });

            modelBuilder.Entity<StaffQualify>(entity =>
            {
                entity.HasIndex(e => e.MonthId, "IX_StaffQualifys_MonthId");

                entity.HasIndex(e => e.StaffMemberNationalId, "IX_StaffQualifys_StaffMemberNationalId");

                entity.HasOne(d => d.Month).WithMany(p => p.StaffQualifies).HasForeignKey(d => d.MonthId);

                entity.HasOne(d => d.StaffMemberNational).WithMany(p => p.StaffQualifies).HasForeignKey(d => d.StaffMemberNationalId);
            });

            modelBuilder.Entity<StaffRelation>(entity =>
            {
                entity.HasIndex(e => e.StaffMemberNationalId, "IX_StaffRelations_StaffMemberNationalId");

                entity.HasOne(d => d.StaffMemberNational).WithMany(p => p.StaffRelations)
                    .HasForeignKey(d => d.StaffMemberNationalId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<StaffVac>(entity =>
            {
                entity.HasIndex(e => e.StaffMemberNationalId, "IX_StaffVacs_StaffMemberNationalId");

                entity.HasIndex(e => e.VacTypeId, "IX_StaffVacs_VacTypeId");

                entity.HasOne(d => d.StaffMemberNational).WithMany(p => p.StaffVacs).HasForeignKey(d => d.StaffMemberNationalId);

                entity.HasOne(d => d.VacType).WithMany(p => p.StaffVacs).HasForeignKey(d => d.VacTypeId);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_Transactions_UserId");

                entity.HasOne(d => d.User).WithMany(p => p.Transactions).HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Univ>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.ForeignUniversity).HasColumnName("Foreign_University");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);
                entity.Property(e => e.MemberId).HasMaxLength(450);
                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserRole",
                        r => r.HasOne<Role>().WithMany().HasForeignKey("RoleId"),
                        l => l.HasOne<User>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");
                            j.ToTable("UserRoles");
                            j.HasIndex(new[] { "RoleId" }, "IX_UserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<UserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserClaims_UserId");

                entity.HasOne(d => d.User).WithMany(p => p.UserClaims).HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_UserLogins_UserId");

                entity.HasOne(d => d.User).WithMany(p => p.UserLogins).HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User).WithMany(p => p.UserTokens).HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<VacType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_1");
            });

            modelBuilder.Entity<WorkStatus>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("WorkStatus");

                entity.Property(e => e.WorkStatus1).HasColumnName("WorkStatus");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}

