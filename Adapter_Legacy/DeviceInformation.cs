namespace Adapter_Legacy
{
    public class DeviceInformation
    {
        private DeviceStatus status;
        private string serialNum;
        private string onlineStatus;
        private string deviceType;
        private string connectionType;
        private string ipAddress;
        private int port;



        public string SerialNum
        {
            get { return this.serialNum; }
            set { this.serialNum = value; }
        }

        public DeviceStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public string OnlineStatus
        {
            get { return this.onlineStatus; }
            set { this.onlineStatus = value; }
        }

        public string DeviceType
        {
            get { return this.deviceType; }
            set { this.deviceType = value; }
        }

        public string ConnectionType
        {
            get { return this.connectionType; }
            set { this.connectionType = value; }
        }

        public string IpAddress
        {
            get { return this.ipAddress; }
            set { this.ipAddress = value; }
        }

        public int Port
        {
            get { return this.port; }
            set { this.port = value; }
        }
    }
}