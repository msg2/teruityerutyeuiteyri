using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeLTI
{
    class Volume
    {
        public string id { get; set; }
        public string status { get; set; }
        public int size { get; set; }
        public string availability_zone { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public List<object> attachments { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string volume_type { get; set; }
        public object snapshot_id { get; set; }
        public object source_volid { get; set; }
        public List<Link> links { get; set; }
        public string user_id { get; set; }
        public string bootable { get; set; }
        public bool encrypted { get; set; }
        public object replication_status { get; set; }
        public object consistencygroup_id { get; set; }
        public bool multiattach { get; set; }
        public string __invalid_name__os { get; set; }
        public VolumeImageMetadata volume_image_metadata { get; set; }

        public class VolumeImageMetadata
        {
            public string signature_verified { get; set; }
            public string hw_rng_model { get; set; }
            public string image_id { get; set; }
            public string image_name { get; set; }
            public string checksum { get; set; }
            public string container_format { get; set; }
            public string disk_format { get; set; }
            public string min_disk { get; set; }
            public string min_ram { get; set; }
            public string size { get; set; }
        }

        public class Link
        {
            public string rel { get; set; }
            public string href { get; set; }
        }

        public override string ToString()
        {
            return this.name.Length>0 ? this.name : this.id;
        }
    }
}
