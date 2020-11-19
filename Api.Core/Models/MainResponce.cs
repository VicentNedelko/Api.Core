using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Core.Models
{
    public class MainResponce
    {
        public string name { get; set; }
        public string full_name { get; set; }
        public string type { get; set; }
        public string locality { get; set; }
        public string region { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int landing_attempts { get; set; }
        public int landing_successes { get; set; }
        public string wikipedia { get; set; }
        public string details { get; set; }
        public IList<string> launches { get; set; }
        public string status { get; set; }
        public string id { get; set; }
    }
}
