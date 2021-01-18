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
   public class BirthCertificateValidator:AbstractValidator<BirthCertificate>
    {
        public BirthCertificateValidator()
        {
            RuleFor(bc => bc.FirstName).NotEmpty();
            RuleFor(bc => bc.LastName).NotEmpty();
            RuleFor(bc => bc.FatherName).NotEmpty();
            RuleFor(bc => bc.MotherName).NotEmpty();
            RuleFor(bc => bc.BirthPlace).NotEmpty();
            RuleFor(bc => bc.BloodGroup).NotEmpty();
            RuleFor(bc => bc.BirthDate).LessThan(DateTime.Now).NotEmpty();
            RuleFor(bc => bc.IssuePlace).NotEmpty();
            RuleFor(bc => bc.IssueDate).NotEmpty();
            RuleFor(bc => bc.RegisteredCountry).NotEmpty();
            RuleFor(bc => bc.RegisteredProvince).NotEmpty();
            RuleFor(bc => bc.RegisteredVillage).NotEmpty();
            RuleFor(bc => bc.Religion).NotEmpty();
            RuleFor(bc => bc.RowNo).NotEmpty();
            RuleFor(bc => bc.VolumeNumber).NotEmpty();
            RuleFor(bc => bc.TCKN).Length(11).NotEmpty();
            RuleFor(bc => bc.SerialNo).NotEmpty();
            RuleFor(bc => bc.MartialStatus).NotEmpty();
            RuleFor(bc => bc.FamilyNo).NotEmpty();
            RuleFor(bc => bc.EnrollmentNo).NotEmpty();


        }
    }
}
