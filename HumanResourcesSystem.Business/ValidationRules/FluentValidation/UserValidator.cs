using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            
                RuleFor(u => u.TckNo).Length(11).NotEmpty();
                RuleFor(u => u.FirstName).NotEmpty();
                RuleFor(u => u.LastName).NotEmpty();
                RuleFor(u => u.UserName).NotEmpty();
                RuleFor(u => u.Password).MinimumLength(8).NotEmpty();  
                RuleFor(u => u.Email).EmailAddress().NotEmpty();
                RuleFor(u => u.Photo).Empty();
                RuleFor(u => u.BirthDate).LessThan(DateTime.Now).NotEmpty();
                RuleFor(u => u.PhoneNumber).NotEmpty();
                RuleFor(u => u.RoleName).NotEmpty();
               
           
        }
    }
}
