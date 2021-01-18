using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class JobValidator:AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(e => e.JobName).NotEmpty();
            RuleFor(e => e.OrganizationName).NotEmpty();
        }
    }
}
