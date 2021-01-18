using FluentValidation;
using HumanResourcesSystem.Business.ValidationRules.FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<BirthCertificate>>().To<BirthCertificateValidator>().InSingletonScope();

            Bind<IValidator<Certification>>().To<CertificationValidator>().InSingletonScope();

            Bind<IValidator<DrivingLicence>>().To<DrivingLicenceValidator>().InSingletonScope();

            Bind<IValidator<Education>>().To<EducationValidator>().InSingletonScope();

            Bind<IValidator<Employee>>().To<EmployeeValidator>().InSingletonScope();

            Bind<IValidator<JobPosting>>().To<JobPostingValidator>().InSingletonScope();

            Bind<IValidator<Job>>().To<JobValidator>().InSingletonScope();

            Bind<IValidator<Material>>().To<MaterialValidator>().InSingletonScope();

            Bind<IValidator<Organization>>().To<OrganizationValidator>().InSingletonScope();

            Bind<IValidator<Payroll>>().To<PayrollValidator>().InSingletonScope();

            Bind<IValidator<SelfHistory>>().To<SelfHistoryValidator>().InSingletonScope();

            Bind<IValidator<TopOrganization>>().To<TopOrganizationValidator>().InSingletonScope();

            Bind<IValidator<User>>().To<UserValidator>().InSingletonScope();

            Bind<IValidator<Role>>().To<RoleValidator>().InSingletonScope();
        }
    }
}
