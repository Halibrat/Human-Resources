using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
    public interface IMaterialService
    {
        void Add(Material material);
        void Delete(Material material);
        void Update(Material material);
        List<Material> GetAll();
        Material GetById(int id);
        List<Material> GetByMaterialName(string text);
        List<Material> GetByOrganizationName(string text);

    }
}
