using MDM.Model;
using System.Collections.Generic;

namespace MDM.IDAL
{
    public interface IDevice_DAL
    {
        List<Device> GetDeviceList();

        Device GetDevice(int DeviceId);

        bool RegisterDevice(Device device);

        bool UpdateDevice(Device device);

        bool DeleteDevice(int DeviceId);
    }
}
