using System; 

namespace DeviceManagementClassLibrary
{
    public interface IDevice 
    {

         IDeviceProperties GetProperties(); 
    }
}