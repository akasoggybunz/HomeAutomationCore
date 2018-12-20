using SharpPcap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace HAC.Models
{
    public class SniffDevice
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string IpAddress { get; set; }
    }
}
