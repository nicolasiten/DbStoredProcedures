using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbStoredProcedures.Data
{
    public partial class IssueTrackerContext : DbContext
    {
        public IssueTrackerContext()
        {
        }

        public IssueTrackerContext(DbContextOptions<IssueTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Issue> Issue { get; set; }
        public virtual DbSet<IssueStatus> IssueStatus { get; set; }
        public virtual DbSet<OperatingSystem> OperatingSystem { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductVersionOs> ProductVersionOs { get; set; }
        public virtual DbSet<Version> Version { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Issue>(entity =>
            {
                entity.HasIndex(e => e.StatusFk);

                entity.HasIndex(e => new { e.ProductFk, e.VersionFk, e.OperatingSystemFk })
                    .HasName("IX_Issue_ProductVersionOs");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Problem).IsRequired();

                entity.Property(e => e.ResolutionDate).HasColumnType("datetime");

                entity.HasOne(d => d.StatusFkNavigation)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => d.StatusFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_Status_StatusFk");

                entity.HasOne(d => d.ProductVersionOs)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => new { d.ProductFk, d.VersionFk, d.OperatingSystemFk })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_ProductVersionOs");
            });

            modelBuilder.Entity<IssueStatus>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OperatingSystem>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ProductVersionOs>(entity =>
            {
                entity.HasKey(e => new { e.ProductFk, e.VersionFk, e.OperatingSystemFk });

                entity.HasOne(d => d.OperatingSystemFkNavigation)
                    .WithMany(p => p.ProductVersionOs)
                    .HasForeignKey(d => d.OperatingSystemFk)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductVersionOs)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionFkNavigation)
                    .WithMany(p => p.ProductVersionOs)
                    .HasForeignKey(d => d.VersionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasColumnName("Version")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
