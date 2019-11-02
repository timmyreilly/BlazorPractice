using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Shared;

namespace DeviceClientWebApplication.Services
{
    public class DeviceTwinService : IDeviceTwinService
    {
        private static RegistryManager _registryManager;

        public DeviceTwinService()
        {
            _registryManager = RegistryManager.CreateFromConnectionString("HostName=monster-hub-four.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=t+5Vz+4PmWHxhoXFZWw2v3c+H/BQUwpY7Nj2S7RwztE=");
        }
        public async Task<IEnumerable<Twin>> GetDevicesAsync()
        {
            var query = _registryManager.CreateQuery("select * from devices"); 
            return await query.GetNextAsTwinAsync().ConfigureAwait(false); 
        }
        public string GetDeviceTwin(string id)
        {
            return $"We're on it! we'll look for {id}";
        }
    }
}