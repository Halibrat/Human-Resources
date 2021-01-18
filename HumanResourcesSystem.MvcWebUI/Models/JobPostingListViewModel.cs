using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace HumanResourcesSystem.MvcWebUI.Models
{
    public class JobPostingListViewModel
    {
        public List<JobPosting> JobPostings { get; set; }
    }
}