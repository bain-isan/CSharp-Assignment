using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    //[System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    internal class SoftwareAttribute : Attribute
    {
        string projectName;
        string description;
        string clientName;
        string startedDate;
        string endDate;

        public string ProjectName{get{ return this.projectName; } }
        public string Description { get{ return this.description; } }
        public string ClientName { get{ return this.clientName; } }
        public string StartedDate { get{ return this.startedDate; } }
        public string EndDate { get{ return this.endDate; } }

        public SoftwareAttribute(string projectName, string description, string clientName, string startedDate, string endDate)
        {
            this.projectName = projectName;
            this.description = description;
            this.clientName = clientName;
            this.startedDate = startedDate;
            this.endDate = endDate;
        }

        public string GetProjectName() {  return this.ProjectName;  }
        public string GetDescription() {  return this.Description;  }
        public string GetClientName() {  return this.ClientName;  }
        public string GetStartedDate() {  return this.StartedDate;  }
        public string GetEndDate() { return this.EndDate;  }
    }
}
