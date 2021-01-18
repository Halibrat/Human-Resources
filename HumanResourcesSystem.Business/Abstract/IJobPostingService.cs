using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface IJobPostingService
    {
        void Add(JobPosting jobPosting);
        void Delete(JobPosting jobPosting);
        void Update(JobPosting jobPosting);
        List<JobPosting> GetAll();
        JobPosting GetById(int id);

        List<JobPosting> GetByPosition(string text);
        List<JobPosting> GetByDescription(string text);
        List<JobPosting> GetByDate(string text);
    }
}
