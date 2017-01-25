using System;

namespace Adapter_Legacy
{
    public class DeviceMxNew
    {
        private DeviceInformation deviceInformation;
        private DeviceHandler DeviceHandlerEvent;
        public DeviceMxNew()
        {
            deviceInformation = new DeviceInformation();
        }

        public void Subscribe(DeviceHandler device)
        {
            device += new DeviceHandler(device);
            device("Subscribe");
        }
        public DeviceInformation GetDeviceInformation()
        {
            Console.WriteLine("Device information");
            return deviceInformation;
        }

        public string SendSynchCommand(string cmd)
        {
            Console.WriteLine("SendSynchCommand( ) =>command");
            return cmd;
        }
        //public bool SendSynchCommand(string cmd)
        //{
        //    return true;
        //}

        private void OnAsynchCommandReply()
        {
            Console.WriteLine("Asynch operation");
            var reply = ReadReply();
            if (DeviceHandlerEvent != null)
            {
                DeviceHandlerEvent(reply);
            }
        }

        public void Connect()
        {
            Console.WriteLine("Device is conected");
        }

        public bool IsConnected()
        {
            Console.WriteLine("Device is Connected?");
            return true;
        }

        public string ReadReply()
        {
            Console.WriteLine("reply operation ");
            return "reply : 12 63 85";
        }
    }
}