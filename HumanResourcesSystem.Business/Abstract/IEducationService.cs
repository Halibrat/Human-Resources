using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface IEducationService
    {
        void Add(Education education);
        void Deleet(Education education);
        void Update(Education education);
        List<Education> GetAll();
    }
}
