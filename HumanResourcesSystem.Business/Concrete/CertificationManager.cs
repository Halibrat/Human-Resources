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
    public class CertificationManager : ICertificationService
    {
        private ICertificationDal _certficationDal;
        public CertificationManager(ICertificationDal certificationDal)
        {
            _certficationDal = certificationDal;
        }
        [FluentValidationAspect(typeof(CertificationValidator))]
        public void Add(Certification certification)
        {
            _certficationDal.Add(certification);
        }

        public void Delete(Certification certification)
        {
            _certficationDal.Delete(certification);
        }

        public List<Certification> GetAll()
        {
            return _certficationDal.GetList();
        }

        public void Update(Certification certification)
        {
            _certficationDal.Update(certification);   
        }
    }
}
