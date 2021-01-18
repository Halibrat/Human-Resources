using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using HumanResourcesSystem.MvcWebUI.Filters;
using HumanResourcesSystem.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace HumanResourcesSystem.MvcWebUI.Controllers
{
    public class JobPostingController : Controller
    {
        private IJobPostingService _jobPostingService;
        public JobPostingController(IJobPostingService jobPostingService)
        {
            _jobPostingService = jobPostingService;
        }
        // GET: JobPosting
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(JobPosting jobPosting)
        {
            _jobPostingService.Add(jobPosting);
            return RedirectToAction("GetAll");
        }

        public ActionResult Delete()
        {
            List<JobPosting> jobPostings = _jobPostingService.GetAll();
            return View(jobPostings);
        }
        [ExceptionHandler]
        public ActionResult DeleteJobPosting(string id)
        {
            JobPosting jobPosting = _jobPostingService.GetById(Convert.ToInt32(id));
            _jobPostingService.Delete(jobPosting);
            List<JobPosting> jobPostings = _jobPostingService.GetAll();
            return View("Delete", jobPostings);
        }

        public ActionResult GetAll()
        {
            var model = new JobPostingListViewModel
            {
                JobPostings = _jobPostingService.GetAll()
            };
            return View(model);
        }

        public ActionResult Update(string id)
        {
            JobPosting jobPosting = _jobPostingService.GetById(Convert.ToInt32(id));
            return View("Update", jobPosting);
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Update(JobPosting jobPosting)
        {
            _jobPostingService.Update(jobPosting);
            return RedirectToAction("GetAll");
        }

        public ActionResult Search(string text)
        {
            List<JobPosting> jobPostings = _jobPostingService.GetAll();
            if (!string.IsNullOrEmpty(text))
            {
                jobPostings = _jobPostingService.GetByPosition(text);
                if (!string.IsNullOrEmpty(text))
                {
                    jobPostings = _jobPostingService.GetByDescription(text);

                }

            }

            return View(jobPostings);
            
        }
    }
}