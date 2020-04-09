using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeLTI
{
    class Network
    {
        public string id { get; set; }
        public string name { get; set; }
        public string tenant_id { get; set; }
        public bool admin_state_up { get; set; }
        public int mtu { get; set; }
        public string status { get; set; }
        public List<string> subnets { get; set; }
        public bool shared { get; set; }
        public List<object> availability_zone_hints { get; set; }
        public List<string> availability_zones { get; set; }
        public object ipv4_address_scope { get; set; }
        public object ipv6_address_scope { get; set; }
        public bool __invalid_name__router { get; set; }
        public string description { get; set; }
        public bool port_security_enabled { get; set; }
        public bool is_default { get; set; }
        public List<object> tags { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int revision_number { get; set; }
        public string project_id { get; set; }

        public override string ToString()
        {
            return this.name;
        }
    }
}
