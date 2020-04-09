using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeLTI
{
    class DashLimitInfo
    {
        
            public int maxTotalInstances { get; set; }
            public int maxTotalCores { get; set; }
            public int maxTotalRAMSize { get; set; }
            public int maxServerMeta { get; set; }
            public int maxImageMeta { get; set; }
            public int maxPersonality { get; set; }
            public int maxPersonalitySize { get; set; }
            public int maxTotalKeypairs { get; set; }
            public int maxServerGroups { get; set; }
            public int maxServerGroupMembers { get; set; }
            public int maxTotalFloatingIps { get; set; }
            public int maxSecurityGroups { get; set; }
            public int maxSecurityGroupRules { get; set; }
            public int totalRAMUsed { get; set; }
            public int totalCoresUsed { get; set; }
            public int totalInstancesUsed { get; set; }
            public int totalFloatingIpsUsed { get; set; }
            public int totalSecurityGroupsUsed { get; set; }
            public int totalServerGroupsUsed { get; set; }
        
        
    }
}
