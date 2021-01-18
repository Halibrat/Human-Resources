using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface IBirthCerficateService
    {
        void Add(BirthCertificate birthCertificate);
        void Delete(BirthCertificate birthCertificate);
        void Update(BirthCertificate birthCertificate);
        List<BirthCertificate> GetAll();
        BirthCertificate GetById(int id);

    }
}
