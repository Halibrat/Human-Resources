using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Entities.Concrete
{
   public class Payroll:IEntity
    {
        public int Id { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal LaborShare { get; set; }
        public decimal UIShare { get; set; }
        public decimal IncomeTaxBase { get; set; }
        public decimal IncomeTaxAmount { get; set; }
        public decimal StampDutAmount { get; set; }
        public decimal SumOfDeductions { get; set; }
        public decimal NetWage { get; set; }
        public decimal EmployerShare { get; set; }
        public decimal UIEShare { get; set; }




    }
}
