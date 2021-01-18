using HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework
{
   public class HumanResourcesContext:DbContext
    {
        public HumanResourcesContext()
        {
            Database.SetInitializer<HumanResourcesContext>(null);
        }
        public DbSet<BirthCertificate> BirthCertificates { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<DrivingLicence> DrivingLicences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<SelfHistory> SelfHistories { get; set; }
        public DbSet<TopOrganization> TopOrganizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BirthCertificateMap());
            modelBuilder.Configurations.Add(new CertificationMap());
            modelBuilder.Configurations.Add(new DrivingLicenceMap());
            modelBuilder.Configurations.Add(new EducationMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new JobMap());
            modelBuilder.Configurations.Add(new JobPostingMap());
            modelBuilder.Configurations.Add(new MaterialMap());
            modelBuilder.Configurations.Add(new OrganizationMap());
            modelBuilder.Configurations.Add(new PayrollMap());
            modelBuilder.Configurations.Add(new SelfHistoryMap());
            modelBuilder.Configurations.Add(new TopOrganizationMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            
        }
    }
}
