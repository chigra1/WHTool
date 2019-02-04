using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours.Projects
{
    public class Project
    {
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public Active active { get; set; }

        public enum Active { ACTIVE = 1, INACTIVE = 2 }

        public Project(string name, string code, string description, Active active)
        {
            this.name = name;
            this.code = code;
            this.description = description;
            this.active = active;
        }



    }
}
