using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Business.ValidationRules.FluentValidation;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Concrete
{
    public class DrivingLicenceManager : IDrivingLicenceService
    {
        private IDrivingLicenceDal _dirivingLicenceDal;
        public DrivingLicenceManager(IDrivingLicenceDal drivingLicenceDal)
        {
            _dirivingLicenceDal = drivingLicenceDal;
        }
        [FluentValidationAspect(typeof(DrivingLicenceValidator))]
        public void Add(DrivingLicence drivingLicence)
        {
            _dirivingLicenceDal.Add(drivingLicence);
        }

        public void Delete(DrivingLicence drivingLicence)
        {
            _dirivingLicenceDal.Delete(drivingLicence);
        }

        public List<DrivingLicence> GetAll()
        {
            return _dirivingLicenceDal.GetList();
        }

        public void Update(DrivingLicence drivingLicence)
        {
            _dirivingLicenceDal.Update(drivingLicence);
        }
    }
}
