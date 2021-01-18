using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
  public class PayrollValidator:AbstractValidator<Payroll>
    {
        public PayrollValidator()
        {
            RuleFor(p => p.GrossSalary).NotEmpty();
            RuleFor(p => p.LaborShare).NotEmpty();
            RuleFor(p => p.UIShare).NotEmpty();
            RuleFor(p => p.IncomeTaxAmount).NotEmpty();
            RuleFor(p => p.IncomeTaxBase).NotEmpty();
            RuleFor(p => p.StampDutAmount).NotEmpty();
            RuleFor(p => p.SumOfDeductions).NotEmpty();
            RuleFor(p => p.NetWage).NotEmpty();
            RuleFor(p => p.EmployerShare).NotEmpty();
            RuleFor(p => p.UIEShare).NotEmpty();
        }
    }
}
