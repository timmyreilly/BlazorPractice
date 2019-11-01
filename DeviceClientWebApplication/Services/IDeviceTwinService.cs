using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Shared;

namespace DeviceClientWebApplication.Services
{
    public interface IDeviceTwinService
    {
         string GetDeviceTwin(string id); 
         Task<IEnumerable<Twin>> GetDevicesAsync(); 
    }
}