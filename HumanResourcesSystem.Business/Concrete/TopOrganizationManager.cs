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
    public class TopOrganizationManager : ITopOrganizationService
    {
        private ITopOrganizationDal _topOrganizationDal;
        public TopOrganizationManager(ITopOrganizationDal topOrganizationDal)
        {
            _topOrganizationDal = topOrganizationDal;
        }
        [FluentValidationAspect(typeof(TopOrganizationValidator))]
        public void Add(TopOrganization topOrganization)
        {
            _topOrganizationDal.Add(topOrganization);
        }

        public void Delete(TopOrganization topOrganization)
        {
            _topOrganizationDal.Delete(topOrganization);
        }

        public List<TopOrganization> GetAll()
        {
            return _topOrganizationDal.GetList();
        }

        public TopOrganization GetById(int id)
        {
            return _topOrganizationDal.Get(t => t.Id == id);
        }

        public void Update(TopOrganization topOrganization)
        {
            _topOrganizationDal.Update(topOrganization);
        }
    }
}
