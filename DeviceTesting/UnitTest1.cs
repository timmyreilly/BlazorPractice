using System;
using Xunit;

namespace DeviceTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test_For_DeviceFactoryConnection_ToRegistry() 
        {
            IDevice systemUnderTest = new Device("1"); 
            IDeviceProperties results = systemUnderTest.GetDeviceProperties(); 

            // assert 
            Assert.IsNotNull(results); 

        }
    }
}
