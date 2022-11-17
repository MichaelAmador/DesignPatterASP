using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DesignPatterns.Models.Data
{
    public partial class DesignPatternsContext : DbContext
    {
        public DesignPatternsContext()
        {
        }

        public DesignPatternsContext(DbContextOptions<DesignPatternsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beer> Beer { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=MICHAEL\\SQLSERVERLOCAL; Database=DesignPatterns; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beer>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Style)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bran)
                    .WithMany(p => p.Beer)
                    .HasForeignKey(d => d.BranId)
                    .HasConstraintName("fk_beer_brand");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.BrandId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
