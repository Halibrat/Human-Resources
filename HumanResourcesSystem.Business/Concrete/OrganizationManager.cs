using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Business.ValidationRules.FluentValidation;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Concrete
{
    public class OrganizationManager : IOrganizationService
    {
        private IOrganizationDal _organizationDal;
        public OrganizationManager(IOrganizationDal organizationDal)
        {
            _organizationDal = organizationDal;
        }
        [FluentValidationAspect(typeof(OrganizationValidator))]
        public void Add(Organization organization)
        {
            _organizationDal.Add(organization);
        }

        public void Delete(Organization organization)
        {
            _organizationDal.Delete(organization);
        }

        public List<Organization> GetAll()
        {
            return _organizationDal.GetList();
        }

        public Organization GetById(int id)
        {
            return _organizationDal.Get(o => o.Id == id);
        }

        public void Update(Organization organization)
        {
            _organizationDal.Update(organization);
        }
    }
}
