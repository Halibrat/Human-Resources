using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
    public class BirthCertificateMap : EntityTypeConfiguration<BirthCertificate>
    {
        public BirthCertificateMap()
        {
            ToTable(@"BirthCertificates", @"dbo");
            HasKey(bc => bc.Id);

            Property(bc => bc.FirstName).HasColumnName("FirstName");
            Property(bc => bc.LastName).HasColumnName("LastName");
            Property(bc => bc.FatherName).HasColumnName("FatherName");
            Property(bc => bc.MotherName).HasColumnName("MotherName");
            Property(bc => bc.BirthDate).HasColumnName("BirthPlace");
            Property(bc => bc.BloodGroup).HasColumnName("BloodGroup");
            Property(bc => bc.IssueDate).HasColumnName("IssueDate");
            Property(bc => bc.IssuePlace).HasColumnName("IssuePlace");
            Property(bc => bc.RegisteredProvince).HasColumnName("RegisteredProvince");
            Property(bc => bc.RegisteredCountry).HasColumnName("ProvinceCountry");
            Property(bc => bc.VolumeNumber).HasColumnName("VolumeNumber");
            Property(bc => bc.TCKN).HasColumnName("TCKN");
            Property(bc => bc.SerialNo).HasColumnName("SerialNo");
            Property(bc => bc.MartialStatus).HasColumnName("MartialStatus");
            Property(bc => bc.Religion).HasColumnName("Religion");
            Property(bc => bc.FamilyNo).HasColumnName("FamilyNo");
            Property(bc => bc.RowNo).HasColumnName("RowNo");
            Property(bc => bc.EnrollmentNo).HasColumnName("EnrollmentNo");
            Property(bc => bc.RegisteredVillage).HasColumnName("RegisteredVillage");
            Property(bc => bc.BirthDate).HasColumnName("BirthDate");

        }

    }
}
