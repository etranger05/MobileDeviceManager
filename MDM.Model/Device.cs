using System;
using System.ComponentModel.DataAnnotations;

namespace MDM.Model
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }

        [Required]
        public string DeviceName { get; set; }

        [Required]
        public string DeviceToken { get; set; }

        [Required]
        public string SerialNumber { get; set; }

        [Required]
        public string WiFiMacAddress { get; set; }
    }
}
