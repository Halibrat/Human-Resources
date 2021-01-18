using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface ISelfHistoryService
    {
        void Add(SelfHistory selfHistory);
        void Delete(SelfHistory selfHistory);
        void Update(SelfHistory selfHistory);
        List<SelfHistory> GetAll();
        SelfHistory GetById(int id);
    }
}
