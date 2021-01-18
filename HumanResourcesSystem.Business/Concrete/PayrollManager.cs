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
    public class PayrollManager : IPayrollService
    {
        private IPayrollDal _payrollDal;
        public PayrollManager(IPayrollDal payrollDal)
        {
            _payrollDal = payrollDal;
        }
        [FluentValidationAspect(typeof(PayrollValidator))]
        public void Add(Payroll payroll)
        {
            _payrollDal.Add(payroll);
        }

        public void Delete(Payroll payroll)
        {
            _payrollDal.Delete(payroll);
        }

        public List<Payroll> GetAll()
        {
            return _payrollDal.GetList();
        }

        public Payroll GetById(int id)
        {
            return _payrollDal.Get(p => p.Id == id);
        }

        public void Update(Payroll payroll)
        {
             _payrollDal.Update(payroll); ;
        }
    }
}
