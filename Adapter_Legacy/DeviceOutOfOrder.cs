using System;

namespace Adapter_Legacy
{
    public class DeviceOutOfOrder
    {
        private readonly Int16 status;
        private readonly Int16 deviceType;
        private DeviceInformation infos;
        public DeviceOutOfOrder()
        {
            infos = new DeviceInformation();
            this.status = 0;
            this.deviceType = 0;
        }

        public string GetSerialNumber()
        {
            Console.WriteLine("serial number of device");
            return "123-321";
        }

        public string GetDeviceType()
        {
            Console.WriteLine("Device type");
            var temp = "";
            if (this.deviceType == 1)
            {
                temp = "MGH 123-789";
            }
            else if (this.deviceType == 2)
            {
                temp = "Serial -1 6";
            }
            else
            {
                temp = "000000";
            }
            return temp;
        }
    }
}