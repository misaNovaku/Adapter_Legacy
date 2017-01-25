namespace Adapter_Legacy
{
    public class DeviceMxAdapterNew : IDevice
    {
        private DeviceMxNew _deviceMxNew;
        private string reply;


        public DeviceMxAdapterNew(DeviceMxNew _deviceMxNew)
        {
            this._deviceMxNew = _deviceMxNew;
        }
        public string GetDeviceType()
        {
            DeviceInformation device = this._deviceMxNew.GetDeviceInformation();
            return device.DeviceType;
        }

        public string GetReply()
        {
            var retTemp = reply;
            reply = " ";
            return retTemp;
        }

        public string GetSerialNumber()
        {
            var device = this._deviceMxNew.GetDeviceInformation();
            var serial = device.SerialNum;
            return serial;
        }

        public int GetStatus()
        {
            var d = this._deviceMxNew.GetDeviceInformation();
            return (int)d.Status;
        }

        public void Initialize()
        {
            this._deviceMxNew.Connect();
        }

        public bool IsAvailable()
        {
            var info = this._deviceMxNew.GetDeviceInformation();
            if (this._deviceMxNew.IsConnected())
            {

                info.Status = DeviceStatus.Online;
            }
            else
            {
                info.Status = DeviceStatus.Offline;
            }
            return false;
        }

        public bool IsReplyReady()
        {
            return !string.IsNullOrEmpty(reply);
        }

        public bool Reset()
        {
            return true;
        }

        public void Restart()
        {
        }

        public bool SendCommand(string cmd)
        {
            reply = this._deviceMxNew.SendSynchCommand(cmd);
            return !string.IsNullOrEmpty(reply);
        }
    }
}