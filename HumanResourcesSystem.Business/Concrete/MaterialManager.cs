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
    public class MaterialManager : IMaterialService
    {
        private IMaterialDal _materialDal;
        public MaterialManager(IMaterialDal materialDal)
        {
            _materialDal = materialDal;
        }
        [FluentValidationAspect(typeof(MaterialValidator))]
        [SecuredOperation(Roles ="Admin,Personnel")]
        public void Add(Material material)
        {
            _materialDal.Add(material);
        }
        [SecuredOperation(Roles = "Admin,Personnel")]
        public void Delete(Material material)
        {
            _materialDal.Delete(material);
        }
        [SecuredOperation(Roles = "Admin,Personnel")]
        public List<Material> GetAll()
        {
            return _materialDal.GetList();
        }
        [SecuredOperation(Roles = "Admin,Personnel")]
        public Material GetById(int id)
        {
            return _materialDal.Get(m => m.Id == id);
        }

        public List<Material> GetByMaterialName(string text)
        {
            return _materialDal.GetList(m => m.MaterialName.ToLower().Contains(text.ToLower()));
        }

        public List<Material> GetByOrganizationName(string text)
        {
            return _materialDal.GetList(m => m.OrganizationName.ToLower().Contains(text.ToLower()));
        }
        [SecuredOperation(Roles = "Admin,Personnel")]
        public void Update(Material material)
        {
            _materialDal.Update(material);
        }
    }
}
