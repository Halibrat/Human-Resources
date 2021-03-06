﻿using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class TopOrganizationValidator:AbstractValidator<TopOrganization>
    {
        public TopOrganizationValidator()
        {
            RuleFor(t => t.TopOrganizationName).NotEmpty();
        }
    }
}
