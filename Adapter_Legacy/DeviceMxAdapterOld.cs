using System;

namespace Adapter_Legacy
{
    public class DeviceMxAdapterOld : IDevice
    {
        private DeviceOutOfOrder deviceMx;
        public DeviceMxAdapterOld(DeviceOutOfOrder deviceMx)
        {
            this.deviceMx = deviceMx;
        }
        public string GetDeviceType()
        {
            throw new NotImplementedException();
        }

        public string GetReply()
        {
            throw new NotImplementedException();
        }

        public string GetSerialNumber()
        {
            throw new NotImplementedException();
        }

        public int GetStatus()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public bool IsAvailable()
        {
            throw new NotImplementedException();
        }

        public bool IsReplyReady()
        {
            throw new NotImplementedException();
        }

        public bool Reset()
        {
            throw new NotImplementedException();
        }

        public void Restart()
        {
            throw new NotImplementedException();
        }

        public bool SendCommand(string cmd)
        {
            throw new NotImplementedException();
        }
    }
}