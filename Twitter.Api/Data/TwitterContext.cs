﻿#nullable disable

namespace Twitter_backend.Data
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.Extensions.Configuration;
    using Twitter_backend.Models;

    /// <summary>
    /// Application Database Context.
    /// </summary>
    public partial class TwitterContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public TwitterContext()
        {
        }

        public TwitterContext(DbContextOptions<TwitterContext> options)
            : base(options)
        {
        }

        public TwitterContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public virtual DbSet<Comment> Comments { get; set; } = null!;

        public virtual DbSet<Tweet> Tweets { get; set; } = null!;

        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_configuration["DefaultConnection"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 2345123L);

                entity.Property(e => e.DateComment).HasColumnType("date");
            });

            modelBuilder.Entity<Tweet>(entity =>
            {
                entity.ToTable("Tweet");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 2345123L);

                entity.Property(e => e.DateTweet).HasColumnType("date");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 2345123L);

                entity.Property(e => e.Date).HasColumnType("date");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
