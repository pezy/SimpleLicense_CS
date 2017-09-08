using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace SimpleLicense
{
    public class SystemTools
    {
        public static bool CheckMAC(string mac)
        {
            return Array.Exists(GetAllPhysicalAddress(), s => s.Equals(mac));
        }

        public static string GetLocal()
        {
            return GetAllPhysicalAddress().FirstOrDefault();
        }

        private static string[] GetAllPhysicalAddress()
        {
            var macList = NetworkInterface.GetAllNetworkInterfaces()
                .Where(nic => nic.Supports(NetworkInterfaceComponent.IPv4) && nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .Select(nic => FormatPhysicalAddress(nic))
                .ToArray();
            return macList;
        }

        private static string FormatPhysicalAddress(NetworkInterface nic)
        {
            var formatedMAC = string.Join("-", nic.GetPhysicalAddress().GetAddressBytes()
                                    .Select(b => b.ToString("X2"))
                                    .ToArray());
            return formatedMAC;
        }
    }
}
