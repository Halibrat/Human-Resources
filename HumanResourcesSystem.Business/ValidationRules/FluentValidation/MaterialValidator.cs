using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class MaterialValidator:AbstractValidator<Material>
    {
        public MaterialValidator()
        {
            RuleFor(m => m.MaterialName).NotEmpty();
            RuleFor(m => m.OrganizationName).NotEmpty();
            RuleFor(m => m.Quantity).NotEmpty();
        }
    }
}
