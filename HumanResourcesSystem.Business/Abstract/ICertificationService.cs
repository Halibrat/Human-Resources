using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface ICertificationService
    {
        void Add(Certification certification);
        void Delete(Certification certification);
        void Update(Certification certification);
        List<Certification> GetAll();
    }
}
