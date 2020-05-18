using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeLTI
{
    public class NamespacesList
    {
        public string kind { get; set; }
        public string apiVersion { get; set; }
        public Metadata1 metadata1 { get; set; }
        public List<Item> items { get; set; }
    }

    public class Metadata1
    {
        public string selfLink { get; set; }
        public string resourceVersion { get; set; }
    }

    public class FPhase
    {
    }

    public class FStatus
    {
        public FPhase f_phase { get; set; }


    }


    public class FieldsV1
    {
        public FStatus fstatus { get; set; }
    }

    public class ManagedField
    {
        public string manager { get; set; }
        public string operation { get; set; }
        public string apiVersion { get; set; }
        public DateTime time { get; set; }
        public string fieldsType { get; set; }
        public FieldsV1 fieldsV1 { get; set; }
    }

    public class Annotations
    {
        public string kubectl_kubernetes_io_last_applied_configuration { get; set; }
    }

    public class Metadata
    {
        public string name { get; set; }
        public string selfLink { get; set; }
        public string uid { get; set; }
        public string resourceVersion { get; set; }
        public DateTime creationTimestamp { get; set; }
        public IList<ManagedField> managedFields { get; set; }
        public Annotations annotations { get; set; }
        public Spec spec { get; set; }
        public StatusKubernetes status { get; set; }

    }

    public class Spec
    {
        public IList<string> finalizers { get; set; }
    }

    public class Status
    {
        public string phase { get; set; }
    }

    public class Item
    {
        public Metadata metadata { get; set; }
        public Spec spec { get; set; }
        public Status status { get; set; }
    }

}
