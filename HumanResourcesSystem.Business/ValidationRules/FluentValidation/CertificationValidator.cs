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
   public class CertificationValidator:AbstractValidator<Certification>
    {
        public CertificationValidator()
        {
            RuleFor(c => c.CertificateName).NotEmpty();
            RuleFor(c => c.CertificationInstitution).NotEmpty();
        }
    }
}
