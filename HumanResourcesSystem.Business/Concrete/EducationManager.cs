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
    public class EducationManager : IEducationService
    {
        private IEducationDal _educationDal;
        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }
        [FluentValidationAspect(typeof(EducationValidator))]
        public void Add(Education education)
        {
            _educationDal.Add(education);
        }

        public void Deleet(Education education)
        {
            _educationDal.Delete(education);
        }

        public List<Education> GetAll()
        {
            return _educationDal.GetList();
        }

        public void Update(Education education)
        {
            _educationDal.Update(education);
        }
    }
}
