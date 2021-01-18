using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class RoleValidator:AbstractValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(r => r.RoleName).NotEmpty();
        }
    }
}
