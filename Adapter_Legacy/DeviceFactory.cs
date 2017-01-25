namespace Adapter_Legacy
{
    public class DeviceFactory
    {
        private static ConnectedDevice connected;

        public DeviceFactory()
        {
            connected = ConnectedDevice.None;
        }
        public static IDevice GetDevice()
        {
            IDevice dev = null;

            if (connected == ConnectedDevice.Old)
            {
                dev = new DeviceMxAdapterOld(new DeviceOutOfOrder());
            }
            else if (connected == ConnectedDevice.New)
            {
                dev = new DeviceMxAdapterNew(new DeviceMxNew());
            }

            return dev;
        }
    }
}