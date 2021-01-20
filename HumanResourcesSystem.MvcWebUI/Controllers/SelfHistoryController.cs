using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.DataAccess.Concrete.EntityFramework;
using HumanResourcesSystem.Entities.Concrete;
using HumanResourcesSystem.MvcWebUI.Filters;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumanResourcesSystem.MvcWebUI.Controllers
{
    public class SelfHistoryController : Controller
    {
        private ISelfHistoryService _selfHistoryService;
        private IJobPostingService _jobPostingService;

        public SelfHistoryController(ISelfHistoryService selfHistoryService, IJobPostingService jobPostingService)
        {
            _selfHistoryService = selfHistoryService;
            _jobPostingService = jobPostingService;

        }
        // GET: SelfHistory
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
        public ActionResult Add(SelfHistory selfHistory)
        {
            UploadPhoto(selfHistory);
            _selfHistoryService.Add(selfHistory);
            return RedirectToAction("Delete");
        }

        public ActionResult Update(string id)
        {
            SelfHistory selfHistory = _selfHistoryService.GetById(Convert.ToInt32(id));
            return View("Update", selfHistory);
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Update(SelfHistory selfHistory)
        {
            _selfHistoryService.Update(selfHistory);
            return RedirectToAction("Index");
        }
        public ActionResult GetAll(int page = 1)
        {
            List<JobPosting> jobPostings = _jobPostingService.GetAll();
            return View(jobPostings.ToPagedList(page, 5));

        }
        public ActionResult Delete()
        {
            List<SelfHistory> selves = _selfHistoryService.GetAll();
            return View(selves);
        }
        [ExceptionHandler]
        public ActionResult SelfHistoryDelete(string id)
        {
            SelfHistory selfHistory = _selfHistoryService.GetById(Convert.ToInt32(id));
            _selfHistoryService.Delete(selfHistory);
            List<SelfHistory> selves = _selfHistoryService.GetAll();
            return View("Delete", selves);
        }
        private void UploadPhoto(SelfHistory selfHistory)
        {

            if (Request.Files.Count > 0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string url = "~/Image/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(url));
                selfHistory.Photo = "/Image/" + fileName + url;

            }

        }

    }
}