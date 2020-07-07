using MDM.IDAL;
using MDM.Model;
using System;
using System.Collections.Generic;

namespace MDM.BLL
{
    public class MDM_BLL
    {
        private readonly IDevice_DAL _DeviceDAL;

        public MDM_BLL(IDevice_DAL device)
        {
            this._DeviceDAL = device;
        }

        public List<Device> GetDeviceList()
        {
            return _DeviceDAL.GetDeviceList();
        }

        public Device GetDevice(int DeviceNo)
        {
            if (DeviceNo <= 0) throw new ArgumentException();
            return _DeviceDAL.GetDevice(DeviceNo);
        }

        public bool RegisterDevice(Device Device)
        {
            if (Device == null) throw new ArgumentNullException();
            return _DeviceDAL.RegisterDevice(Device);
        }

        public bool UpdateDevice(Device Device)
        {
            if (Device == null) throw new ArgumentNullException();
            return _DeviceDAL.UpdateDevice(Device);
        }

        public bool DeleteDevice(int DeviceNo)
        {
            if (DeviceNo <= 0) throw new ArgumentException();
            return _DeviceDAL.DeleteDevice(DeviceNo);
        }
    }
}
