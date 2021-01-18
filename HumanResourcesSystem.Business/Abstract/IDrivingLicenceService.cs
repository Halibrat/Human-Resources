using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
    public interface IDrivingLicenceService
    {
        void Add(DrivingLicence drivingLicence);
        void Delete(DrivingLicence drivingLicence);
        void Update(DrivingLicence drivingLicence);
        List<DrivingLicence> GetAll();
    }
}
