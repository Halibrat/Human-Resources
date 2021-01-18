using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface IJobService
    {
        void Add(Job job);
        void Delete(Job job);
        void Update(Job job);
        List<Job> GetAll();
    }
}
