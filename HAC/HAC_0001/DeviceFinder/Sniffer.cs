using System;
using System.Collections.Generic;
using System.Linq;
using SharpPcap;

namespace HAC.DeviceFinder
{
    /// <summary>
    ///Requires to work <see href="https://www.winpcap.org/install/default.htm">wincap download </see>
    /// </summary>
    public class Sniffer
    {
        public Sniffer()
        {
        }
        public CaptureDeviceList sniff()
        {

            // Retrieve all capture devices
            var devices = CaptureDeviceList.Instance;

            return devices;
        }


    }
}
