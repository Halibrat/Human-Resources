using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface IPayrollService
    {
        void Add(Payroll payroll);
        void Delete(Payroll payroll);
        void Update(Payroll payroll);
        List<Payroll> GetAll();
        Payroll GetById(int id);
    }
}
