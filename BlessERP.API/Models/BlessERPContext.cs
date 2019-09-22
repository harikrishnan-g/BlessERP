using Microsoft.EntityFrameworkCore;

namespace BlessERP.API.Models
{
    public partial class BlessERPContext : DbContext
    {
        public BlessERPContext()
        {
        }

        public BlessERPContext(DbContextOptions<BlessERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<NurseHandoverBook> NurseHandoverBook { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Values> Values { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=BlessERP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<NurseHandoverBook>(entity =>
            {
                entity.Property(e => e.BranchCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CarpediumNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CashinHand).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("date");

                entity.Property(e => e.FranchiseCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HandoverDate).HasColumnType("date");

                entity.Property(e => e.HousekeepingNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.KeyHandOverNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenenceNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime).HasColumnType("date");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.NurseEmployeecode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OtherInformation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShortstayNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialdayNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TechnicalNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.AssignedToNavigation)
                    .WithMany(p => p.TasksAssignedToNavigation)
                    .HasForeignKey(d => d.AssignedTo);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TasksCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Values>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });
        }
    }
}
