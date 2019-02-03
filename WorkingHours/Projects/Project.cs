using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours.Projects
{
    public class Project
    {
        public string name;
        public string code;
        public string description;
        public Active active;

        public Project(string name, string code, string description, Active active)
        {
            this.name = name;
            this.code = code;
            this.description = description;
            this.active = active;
        }

        public enum Active { ACTIVE = 1, INACTIVE = 2 }
    }
}
