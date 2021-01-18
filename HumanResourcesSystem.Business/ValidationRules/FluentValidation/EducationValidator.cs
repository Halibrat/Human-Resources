using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class EducationValidator:AbstractValidator<Education>
    {
        public EducationValidator()
        {
            RuleFor(e => e.HighSchoolName).NotEmpty();
            RuleFor(e => e.UniversityName).NotEmpty();
            RuleFor(e => e.Section).NotEmpty();
            RuleFor(e => e.StartingDate).NotEmpty();
            RuleFor(e => e.EndDate).NotEmpty();
        }
    }
}
