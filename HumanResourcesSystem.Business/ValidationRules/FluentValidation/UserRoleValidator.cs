using FluentValidation;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ValidationRules.FluentValidation
{
   public class UserRoleValidator:AbstractValidator<UserRole>
    {
        public UserRoleValidator()
        {
            
        }
    }
}
