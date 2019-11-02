using System;
using System.Collections.Generic;
using DeviceClientWebApplication.Services;
using Microsoft.Azure.Devices.Shared;
using Xunit;

namespace UnitTests
{
    public class DeviceTwinServiceTest
    {
        [Fact]
        public async void DeviceService_should_not_be_null()
        {
            IDeviceTwinService DeviceTwinService = new DeviceTwinService();
            IEnumerable<Twin> devices = await DeviceTwinService.GetDevicesAsync();

            Console.WriteLine(devices);
            Assert.NotNull(devices);
            foreach(Twin d in devices) 
            {
                Assert.NotNull(d); 

            }
        }
    }
}

