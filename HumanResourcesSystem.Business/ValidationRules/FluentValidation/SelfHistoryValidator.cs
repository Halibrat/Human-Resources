using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class SelfHistoryValidator:AbstractValidator<SelfHistory>
    {
        public SelfHistoryValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty();
            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.BirthPlace).NotEmpty();
            RuleFor(s => s.Phone).NotEmpty();
            RuleFor(s => s.Email).EmailAddress().NotEmpty();
            RuleFor(s => s.Photo).NotEmpty();

        }
    }
}
