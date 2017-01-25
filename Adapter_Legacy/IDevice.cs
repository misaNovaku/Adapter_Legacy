namespace Adapter_Legacy
{
    public interface IDevice
    {
        string GetSerialNumber();
        string GetDeviceType();
        bool SendCommand(string cmd);
        bool IsReplyReady();
        string GetReply();
        bool Reset();
        void Restart();
        bool IsAvailable();
        void Initialize();
        int GetStatus();
    }
}