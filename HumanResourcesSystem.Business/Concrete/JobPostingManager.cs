using DevFramework.Core.Aspects.Postsharp.AuthorizationAspects;
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
    public class JobPostingManager : IJobPostingService
    {
        private IJobPostingDal _jobPostingDal;
        public JobPostingManager(IJobPostingDal jobPostingDal)
        {
            _jobPostingDal = jobPostingDal;
        }
        [FluentValidationAspect(typeof(JobPostingValidator))]
        [SecuredOperation(Roles ="Admin")]
        public void Add(JobPosting jobPosting)
        {
            _jobPostingDal.Add(jobPosting);
        }
        [SecuredOperation(Roles ="Admin")]
        public void Delete(JobPosting jobPosting)
        {
            _jobPostingDal.Delete(jobPosting);
        }
        [SecuredOperation(Roles = "Visitor,Personnel,Admin")]
        public List<JobPosting> GetAll()
        {
            return _jobPostingDal.GetList();
        }

        public List<JobPosting> GetByDate(string text)
        {
            return _jobPostingDal.GetList(jp => jp.CreatedTime.ToString().Contains(text.ToString()));
        }

        public List<JobPosting> GetByDescription(string text)
        {
            return _jobPostingDal.GetList(jp => jp.Description.ToLower().Contains(text.ToLower()));
        }

        public JobPosting GetById(int id)
        {
            return _jobPostingDal.Get(jp => jp.Id == id);
        }

        public List<JobPosting> GetByPosition(string text)
        {
            return _jobPostingDal.GetList(jp => jp.Position.ToLower().Contains(text.ToLower()));
        }
        [SecuredOperation(Roles ="Admin")]
        public void Update(JobPosting jobPosting)
        {
            _jobPostingDal.Update(jobPosting);
        }
    }
}
