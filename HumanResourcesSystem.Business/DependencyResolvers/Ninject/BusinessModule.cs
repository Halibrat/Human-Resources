using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Business.Concrete;
using HumanResourcesSystem.Business.ServiceAdapters;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBirthCerficateService>().To<BirthCertificateManager>().InSingletonScope();
            Bind<IBirthCertificateDal>().To<EfBirthCertificateDal>().InSingletonScope();

            Bind<ICertificationService>().To<CertificationManager>().InSingletonScope();
            Bind<ICertificationDal>().To<EfCertificationDal>().InSingletonScope();

            Bind<IDrivingLicenceService>().To<DrivingLicenceManager>().InSingletonScope();
            Bind<IDrivingLicenceDal>().To<EfDrivingLicenceDal>().InSingletonScope();

            Bind<IEducationService>().To<EducationManager>().InSingletonScope();
            Bind<IEducationDal>().To<EfEducationDal>().InSingletonScope();

            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();
            Bind<IEmployeeDal>().To<EfEmployeeDal>().InSingletonScope();

            Bind<IJobService>().To<JobManager>().InSingletonScope();
            Bind<IJobDal>().To<EfJobDal>().InSingletonScope();

            Bind<IJobPostingService>().To<JobPostingManager>().InSingletonScope();
            Bind<IJobPostingDal>().To<EfJobPostingDal>().InSingletonScope();

            Bind<IMaterialService>().To<MaterialManager>().InSingletonScope();
            Bind<IMaterialDal>().To<EfMaterialDal>().InSingletonScope();

            Bind<IOrganizationService>().To<OrganizationManager>().InSingletonScope();
            Bind<IOrganizationDal>().To<EfOrganizationDal>().InSingletonScope();

            Bind<IPayrollService>().To<PayrollManager>().InSingletonScope();
            Bind<IPayrollDal>().To<EfPayrollDal>().InSingletonScope();

            Bind<ISelfHistoryService>().To<SelfHistoryManager>().InSingletonScope();
            Bind<ISelfHistoryDal>().To<EfSelfHistoryDal>().InSingletonScope();

            Bind<ITopOrganizationService>().To<TopOrganizationManager>().InSingletonScope();
            Bind<ITopOrganizationDal>().To<EfTopOrganizationDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            Bind<IRoleService>().To<RoleManager>().InSingletonScope();
            Bind<IRoleDal>().To<EfRoleDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<HumanResourcesContext>().InSingletonScope();

            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();

        }
    }
}
