namespace DeviceManagementClassLibrary
{
    public interface IDevice
    {

        IDeviceProperties GetProperties();
        IDeviceProperties GetDeviceProperties();
    }

    public class Device : IDevice {
        
    }
}