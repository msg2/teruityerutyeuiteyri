using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeLTI
{
    class Image
    {
        public string hw_rng_model { get; set; }
        public string name { get; set; }
        public string disk_format { get; set; }
        public string container_format { get; set; }
        public string visibility { get; set; }
        public int size { get; set; }
        public object virtual_size { get; set; }
        public string status { get; set; }
        public string checksum { get; set; }
        public bool @protected { get; set; }
        public int min_ram { get; set; }
        public int min_disk { get; set; }
        public string owner { get; set; }
        public bool os_hidden { get; set; }
        public string os_hash_algo { get; set; }
        public string os_hash_value { get; set; }
        public string id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public List<object> tags { get; set; }
        public string self { get; set; }
        public string file { get; set; }
        public string schema { get; set; }

        public override string ToString()
        {
            return this.name;
        }
    }
}
