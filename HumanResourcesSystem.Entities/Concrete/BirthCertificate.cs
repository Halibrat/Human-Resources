using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Entities.Concrete
{
   public class BirthCertificate:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public string BloodGroup { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuePlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string RegisteredProvince { get; set; }
        public string RegisteredCountry { get; set; }
        public string RegisteredVillage { get; set; }
        public string VolumeNumber { get; set; }
        public string TCKN { get; set; }
        public string SerialNo { get; set; }
        public string MartialStatus { get; set; }
        public string Religion { get; set; }
        public string FamilyNo { get; set; }
        public string RowNo { get; set; }
        public string EnrollmentNo { get; set; }
        








    }
}
