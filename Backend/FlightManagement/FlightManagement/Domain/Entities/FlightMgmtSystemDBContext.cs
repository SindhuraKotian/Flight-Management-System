using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalCodingChallenge.Domain.Entities
{
    public partial class FlightMgmtSystemDBContext : DbContext
    {
        public FlightMgmtSystemDBContext()
        {
        }

        public FlightMgmtSystemDBContext(DbContextOptions<FlightMgmtSystemDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Flight> Flight { get; set; }
        public virtual DbSet<Passenger> Passenger { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\M1056109;Database=FlightMgmtSystemDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>(entity =>
            {
                entity.Property(e => e.FlightName).HasMaxLength(50);
            });

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.Property(e => e.PassengerName).HasMaxLength(50);

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.Passenger)
                    .HasForeignKey(d => d.FlightId)
                    .HasConstraintName("FK_Passenger_Flight");
            });
        }
    }
}
