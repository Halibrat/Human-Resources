﻿using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class OrganizationValidator:AbstractValidator<Organization>
    {
        public OrganizationValidator()
        {
            RuleFor(o => o.OrganizationName).NotEmpty();
            RuleFor(o => o.TopOrganizationId).NotEmpty();
        }
    }
}
