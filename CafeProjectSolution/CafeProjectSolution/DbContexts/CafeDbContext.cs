using CafeProjectSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeProjectSolution.DbContexts
{
    public class CafeDbContext : DbContext
    {
        public DbSet<CafeData> CafeData { get; set; }
        public DbSet<EmployeesData> EmployeesData { get; set; }
        public DbSet<CafeEmployees> CafeEmployees { get; set; }

        public CafeDbContext(DbContextOptions<CafeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  

            // Map entities to tables  
            modelBuilder.Entity<CafeData>().ToTable("CafeData");
            modelBuilder.Entity<EmployeesData>().ToTable("EmployeesData");
            modelBuilder.Entity<CafeEmployees>().ToTable("CafeEmployees");

            // Configure Primary Keys  
            //modelBuilder.Entity<CafeData>().HasKey(ug => ug.Id).HasName("PK_CafeData");
            //modelBuilder.Entity<EmployeesData>().HasKey(em => em.Id).HasName("PK_EmployeesData");
            //modelBuilder.Entity<CafeEmployees>().HasKey(ce => ce.Id).HasName("PK_CafeEmployees");

            // Configure indexes  
            /*modelBuilder.Entity<UserGroup>().HasIndex(p => p.Name).IsUnique().HasDatabaseName("Idx_Name");
            modelBuilder.Entity<User>().HasIndex(u => u.FirstName).HasDatabaseName("Idx_FirstName");
            modelBuilder.Entity<User>().HasIndex(u => u.LastName).HasDatabaseName("Idx_LastName");*/

            // Configure columns  
            //modelBuilder.Entity<CafeData>().Property(cf => cf.Id).HasColumnType("nvarchar(10)").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<CafeData>().Property(cf => cf.Id).HasColumnType("nvarchar(10)").IsRequired();
            modelBuilder.Entity<CafeData>().Property(cf => cf.Name).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<CafeData>().Property(cf => cf.Discription).HasColumnType("nvarchar(255)").IsRequired();
            modelBuilder.Entity<CafeData>().Property(cf => cf.Location).HasColumnType("nvarchar(255)").IsRequired();
            modelBuilder.Entity<CafeData>().Property(cf => cf.Logo).HasColumnType("nvarchar(255)").IsRequired();
            

            //modelBuilder.Entity<EmployeesData>().Property(em => em.Id).HasColumnType("nvarchar(10)").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<EmployeesData>().Property(em => em.Id).HasColumnType("nvarchar(10)").IsRequired();
            modelBuilder.Entity<EmployeesData>().Property(em => em.Name).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<EmployeesData>().Property(em => em.EmailAddress).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<EmployeesData>().Property(em => em.PhoneNumber).HasColumnType("int").IsRequired();
            modelBuilder.Entity<EmployeesData>().Property(em => em.Gender).HasColumnType("int").IsRequired();


            //modelBuilder.Entity<CafeEmployees>().Property(ce => ce.Id).HasColumnType("nvarchar(10)").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<CafeEmployees>().Property(ce => ce.Id).HasColumnType("nvarchar(10)").IsRequired();
            modelBuilder.Entity<CafeEmployees>().Property(ce => ce.CafeId).HasColumnType("nvarchar(10)").IsRequired();
            modelBuilder.Entity<CafeEmployees>().Property(ce => ce.EmployeesId).HasColumnType("nvarchar(10)").IsRequired();


        }
    }
}
