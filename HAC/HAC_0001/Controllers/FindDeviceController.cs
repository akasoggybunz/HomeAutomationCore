using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HAC.Models;
using Microsoft.AspNetCore.Mvc;
using SharpPcap.AirPcap;
using SharpPcap.WinPcap;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HAC.Controllers
{
    [Route("api/[controller]")]
    public class FindDeviceController : ControllerBase
    {
        /// <summary>
        /// Sniff devices on the network.
        /// </summary>
        /// <returns>List of Sniff Devices</returns>
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<SniffDevice> Get()
        {
            List<SniffDevice> devices = new List<SniffDevice>();
            DeviceFinder.Sniffer networkSniffer = new DeviceFinder.Sniffer();
            var traffic = networkSniffer.sniff();

            // Build output using Model
            foreach (WinPcapDevice t in traffic)
            {
                devices.Add(new SniffDevice()
                {
                    Name = t.Name,
                    Description = t.Description,
                    IpAddress = t.Addresses.Select(x=>x.Addr.ipAddress).ToString(),
                });
            }
            return devices;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }


    }
}
