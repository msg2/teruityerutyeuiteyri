using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeLTI
{
    class Server
    {
       public string id { get; set; }
       public string name { get; set; }
       public List<Link> links { get; set; }
      
        public class Link
        {
            public string rel { get; set; }
            public string href { get; set; }
        }

        public class RootObject
        {
            public List<Server> servers { get; set; }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
