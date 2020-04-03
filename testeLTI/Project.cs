using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeLTI
{
    public class Project
    {
        public string id { get; set; }
        public string name { get; set; }
        public string domain_id { get; set; }
        public string description { get; set; }
        public bool enabled { get; set; }
        public string parent_id { get; set; }
        public bool is_domain { get; set; }
        public List<object> tags { get; set; }
        public Options options { get; set; }
        public Links links { get; set; }

        public class Options
        {
        }

        public class Links
        {
            public string self { get; set; }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
