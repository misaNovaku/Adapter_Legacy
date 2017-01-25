using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Legacy
{
    //castecne nedodelany projekt
    class Program
    {
        static void Main(string[] args)
        {
            var id = new DeviceInformation
            {
                ConnectionType = "Lan",
                DeviceType = "Router",
                IpAddress = "192.168.20.0",
                OnlineStatus = "Active",
                Port = 12300,
                SerialNum = "45-23-56",
                Status = DeviceStatus.Offline
            };


            // DeviceMxNew order = new DeviceMxNew();
            IDevice vrDivice = new DeviceMxAdapterNew(new DeviceMxNew());




            if (vrDivice == null) throw new ArgumentNullException("ideDevice");

            if (id == null)
            {
                throw new ArgumentNullException("Toto je vyjimka typu nenastaveni odkazu na objekt");
            }
            else
            {
                vrDivice.GetStatus();
                vrDivice.GetDeviceType();
                vrDivice.GetSerialNumber();
            }
        }
    }
}
