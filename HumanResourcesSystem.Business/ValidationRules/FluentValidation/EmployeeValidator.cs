using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty();
            RuleFor(e => e.LastName).NotEmpty();
            RuleFor(e => e.SgkNo).NotEmpty();
            RuleFor(e => e.InagurationDate).NotEmpty();
            RuleFor(e => e.TckNo).NotEmpty();
           
          
        }
    }
}
