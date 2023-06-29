using CafeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeAPI.DbContexts
{
    public class CafeDbContext : DbContext
    {
        public DbSet<CafeData> CafeData { get; set; }
        public DbSet<EmployeesData> EmployeesData { get; set; }

        public CafeDbContext(DbContextOptions<CafeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map entities to tables  
            modelBuilder.Entity<CafeData>().ToTable("CafeData");
            modelBuilder.Entity<EmployeesData>().ToTable("EmployeesData");

            modelBuilder.Entity<CafeData>().Property(cf => cf.Id).HasColumnType("nvarchar(10)").IsRequired();
            modelBuilder.Entity<CafeData>().Property(cf => cf.Name).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<CafeData>().Property(cf => cf.Discription).HasColumnType("nvarchar(255)").IsRequired();
            modelBuilder.Entity<CafeData>().Property(cf => cf.Location).HasColumnType("nvarchar(255)").IsRequired();
            modelBuilder.Entity<CafeData>().Property(cf => cf.Logo).HasColumnType("nvarchar(255)").IsRequired();

            modelBuilder.Entity<EmployeesData>().Property(em => em.Id).HasColumnType("nvarchar(10)").IsRequired();
            modelBuilder.Entity<EmployeesData>().Property(em => em.Name).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<EmployeesData>().Property(em => em.EmailAddress).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<EmployeesData>().Property(em => em.PhoneNumber).HasColumnType("int").IsRequired();
            modelBuilder.Entity<EmployeesData>().Property(em => em.Gender).HasColumnType("int").IsRequired();

            /*modelBuilder.Entity<EmployeesData>().Property(em => em.CafeId).HasColumnType("nvarchar(10)").IsRequired(false);*/
            /*modelBuilder.Entity<EmployeesData>().HasOne<CafeData>().WithMany().HasPrincipalKey(cf => cf.Id).HasForeignKey(em => em.CafeId);*/
        }
    }
    
}
