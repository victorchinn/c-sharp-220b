using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalProjectDB
{
    public partial class FinalProjectDBContext : DbContext
    {
        public FinalProjectDBContext()
        {
        }

        public FinalProjectDBContext(DbContextOptions<FinalProjectDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Component> Component { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=FinalProjectDB;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Component>(entity =>
            {
                entity.Property(e => e.ComponentCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComponentDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ComponentMemberOf).HasMaxLength(50);

                entity.Property(e => e.ComponentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ComponentNotes).HasMaxLength(1000);

                entity.Property(e => e.ComponentPartNumber).HasMaxLength(50);

                entity.Property(e => e.ComponentType).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
