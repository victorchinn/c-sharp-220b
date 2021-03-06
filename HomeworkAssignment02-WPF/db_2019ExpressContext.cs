﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HomeworkAssignment02_WPF
{
    public partial class db_2019ExpressContext : DbContext
    {
        public db_2019ExpressContext()
        {
        }

        public db_2019ExpressContext(DbContextOptions<db_2019ExpressContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=db_2019Express;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
