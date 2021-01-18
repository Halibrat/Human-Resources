﻿using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Entities.Concrete
{
   public class User:IEntity
    {
        public int UserId { get; set; }
        public string TckNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
      
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
        public string RoleName { get; set; }

        public DateTime BirthDate { get; set; }
      
    }
    
}