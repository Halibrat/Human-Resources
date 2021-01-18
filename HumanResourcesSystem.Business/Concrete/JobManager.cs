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
    public class JobManager : IJobService
    {
        private IJobDal _jobDal;
        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }
        [FluentValidationAspect(typeof(JobValidator))]
        public void Add(Job job)
        {
            _jobDal.Add(job);
        }

        public void Delete(Job job)
        {
            _jobDal.Delete(job);
        }

        public List<Job> GetAll()
        {
            return _jobDal.GetList();
        }

        public void Update(Job job)
        {
            _jobDal.Update(job);
        }
    }
}
