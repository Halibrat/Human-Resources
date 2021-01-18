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
   public class CertificationMap:EntityTypeConfiguration<Certification>
    {
        public CertificationMap()
        {
            ToTable(@"Certications", @"dbo");
            HasKey(c => c.Id);

            Property(c => c.CertificateName).HasColumnName("CerticateName");
            Property(c => c.CertificationInstitution).HasColumnName("CerticationInstitution");
        }
    }
}
