using DataAccesLayer.Entities;
using DataAccesLayer.Entities.Base;
using DataAccesLayer.Entities.Base.Contracts;
using DataAccesLayer.Entities.Base.Defaults;
using DataAccesLayer.Entities.Base.Departments;
using DataAccesLayer.Entities.Base.Employees;
using DataAccesLayer.Entities.Base.Groups;
using DataAccesLayer.Entities.Base.Permisions;
using DataAccesLayer.Entities.Base.Roles;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace DataAccesLayer
{
    public class DataBaseContext  : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        #region Tables mapping
        public DataBaseContext() { }
        public DbSet<User> Users { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionRole> PermissionRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Default> Defaults { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ContractEntity> Contracts { get; set; }


        #endregion
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermissionRole>()
         .HasKey(pr => new { pr.RoleId, pr.PermissionId }); // Cheia primară compusă
            modelBuilder.Entity<PermissionRole>()
                .HasOne(pr => pr.Role)
                .WithMany(r => r.PermissionRoles)
                .HasForeignKey(pr => pr.RoleId);

            modelBuilder.Entity<PermissionRole>()
                .HasOne(pr => pr.Permission)
                .WithMany(p => p.PermissionRoles)
                .HasForeignKey(pr => pr.PermissionId);
            modelBuilder.Entity<Employee>()
                  .HasOne(e => e.User)           // Employee are un User asociat
                  .WithOne()                     // User nu are o referință directă la Employee
                  .HasForeignKey<Employee>(e => e.UserId);
            modelBuilder.Entity<Default>()
                .HasOne(e => e.User)           
                .WithOne()                    
                .HasForeignKey<Default>(e => e.UserId);
            modelBuilder.Entity<Group>()
               .HasMany(g=>g.DepartmentGroups)
               .WithOne()
               .HasForeignKey(e => e.GroupId);
            modelBuilder.Entity<Group>()
               .HasMany(e => e.Users)
               .WithOne()
               .HasForeignKey(e => e.GroupId);
            modelBuilder.Entity<ContractEntity>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.Contracts)
                .HasForeignKey(c => c.EmployeeId);
            modelBuilder.Entity<ContractEntity>()
                .HasOne(c => c.Cor)
                .WithMany(c => c.Contracts);
        }



    }
}
//dotnet ef migrations add InitialCreate --project DataAccesLayer.csproj --startup-project ../HrApp
//dotnet ef database update  --project DataAccesLayer.csproj --startup-project ../HrApp
