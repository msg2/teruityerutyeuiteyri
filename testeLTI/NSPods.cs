using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeLTI
{
    public class NSPods
    {
        public string kind { get; set; }
        public string apiVersion { get; set; }
        public Metadata1 metadata1 { get; set; }
        public List<ItemKubernetes> items { get; set; }
    }

    public class ContainerStatus
    {

        public string name { get; set; }
        public StatusKubernetes state { get; set; }
        public bool ready { get; set; }
        public int restartCount { get; set; }
        public string image { get; set; }
        public string imageID { get; set; }
        public string containerID { get; set; }
        public bool started { get; set; }
    }

    public class StatusKubernetes
    {
        public string phase { get; set; }
        public List<Condition> conditions { get; set; }
        public string hostIP { get; set; }
        public string podIP { get; set; }
        public List<PodIP> podIPs { get; set; }
        public DateTime startTime { get; set; }
        public List<ContainerStatus> containerStatuses { get; set; }
        public string qosClass { get; set; }
    }

    public class ItemKubernetes
    {
        public Metadata metadata { get; set; }
        public Spec spec { get; set; }
        public StatusKubernetes status { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Condition
    {
        public string type { get; set; }
        public string status { get; set; }
        public object lastProbeTime { get; set; }
        public DateTime lastTransitionTime { get; set; }
    }

    public class PodIP
    {
        public string ip { get; set; }
    }
}
