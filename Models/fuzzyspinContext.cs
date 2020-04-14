using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FuzzySpin.Models
{
    public partial class fuzzyspinContext : DbContext
    {
        public fuzzyspinContext()
        {
        }

        public fuzzyspinContext(DbContextOptions<fuzzyspinContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Conversation> Conversation { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LMKOL-LP-0114;Initial Catalog=fuzzyspin;Persist Security Info=True;User ID=sa;Password=P@ssw0rd;Pooling=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Conversation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Conversation)
                    .HasForeignKey(d => d.CreatorId)
                    .HasConstraintName("FK_Conversation_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(150);

                entity.Property(e => e.PasswordHash).HasMaxLength(150);

                entity.Property(e => e.ProfilePicture).HasMaxLength(200);
            });
        }
    }
}
