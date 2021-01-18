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
    public class BirthCertificateManager : IBirthCerficateService
    {
        private IBirthCertificateDal _birthCertifcateDal;
        public BirthCertificateManager(IBirthCertificateDal birthCertificateDal)
        {
            _birthCertifcateDal = birthCertificateDal;
        }
        [FluentValidationAspect(typeof(BirthCertificateValidator))]
        public void Add(BirthCertificate birthCertificate)
        {
            _birthCertifcateDal.Add(birthCertificate);
        }

        public void Delete(BirthCertificate birthCertificate)
        {
            _birthCertifcateDal.Delete(birthCertificate);
        }

        public List<BirthCertificate> GetAll()
        {
          return  _birthCertifcateDal.GetList();
        }

        public BirthCertificate GetById(int id)
        {
            return _birthCertifcateDal.Get(bc => bc.Id == id);
        }

        public void Update(BirthCertificate birthCertificate)
        {
            _birthCertifcateDal.Update(birthCertificate);
        }
    }
}
