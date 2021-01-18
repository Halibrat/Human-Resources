using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using HumanResourcesSystem.MvcWebUI.Filters;
using HumanResourcesSystem.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumanResourcesSystem.MvcWebUI.Controllers
{
    public class MaterialController : Controller
    {
        private IMaterialService _materialService;
        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }
        // GET: Material
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
        public ActionResult Add(Material material)
        {
            _materialService.Add(material);
            return RedirectToAction("GetAll");
        }
        public ActionResult Delete()
        {
            List<Material> materials = _materialService.GetAll();
            return View(materials);
        }
        [ExceptionHandler]
        public ActionResult DeleteMaterial(string id)
        {
            Material material = _materialService.GetById(Convert.ToInt32(id));
            _materialService.Delete(material);
            List<Material> materials = _materialService.GetAll();
            return View("Delete",materials);
        }
        public ActionResult GetAll()
        {
            var model = new MaterialListViewModel
            {
                Materials = _materialService.GetAll()
            };
            return View(model);
        }
        public ActionResult Update(string id)
        {
            Material material = _materialService.GetById(Convert.ToInt32(id));
            return View("Update",material);
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Update(Material material)
        {
            _materialService.Update(material);
            return RedirectToAction("GetAll");
        }
        public ActionResult Search(string text)
        {
            List<Material> materials = _materialService.GetAll();
            if (!string.IsNullOrEmpty(text))
            {
                materials= _materialService.GetByMaterialName(text);
                if (!string.IsNullOrEmpty(text))
                {
                    materials = _materialService.GetByOrganizationName(text);
                }
               
            }

            return View(materials);
        }
    }
}