/************************************************************************/
/*  Project Name : IpSwitcher                                         */
/*  Author: luoweifeng1989                                              */
/*  Date: 2011-4-22                                                     */
/*  All Rights Reserved.                                                */
/************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Management;
using System.Text.RegularExpressions;
using ROOT.CIMV2.Win32;
using System.Net.Sockets;

namespace IpSwitcher
{
    class LocalIpChanger
    {
        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        public static  String getLocalIpAddress()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork )
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        public static bool setLocalIpAddress(String newIpAddress)
        {
            return setLocalIpAddressHelper("本地连接", newIpAddress, "255.255.255.0", newIpAddress.Substring(0, newIpAddress.LastIndexOf('.')) + ".1", "8.8.8.8");

        }

        public static bool setLocalIpAddressHelper(string nicName, string IpAddresses, string SubnetMask, string Gateway, string DnsSearchOrder)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                {
                    if (mo["Caption"].Equals(nicName))
                    {
                        ManagementBaseObject newIP = mo.GetMethodParameters("EnableStatic");
                        ManagementBaseObject newGate = mo.GetMethodParameters("SetGateways");
                        ManagementBaseObject newDNS = mo.GetMethodParameters("SetDNSServerSearchOrder");

                        newGate["DefaultIPGateway"] = new string[] { Gateway };
                        newGate["GatewayCostMetric"] = new int[] { 1 };

                        newIP["IPAddress"] = new string[] { IpAddresses };
                        newIP["SubnetMask"] = new string[] { SubnetMask };

                        newDNS["DNSServerSearchOrder"] = new string[] { DnsSearchOrder };

                        ManagementBaseObject setIP = mo.InvokeMethod("EnableStatic", newIP, null);
                        ManagementBaseObject setGateways = mo.InvokeMethod("SetGateways", newGate, null);
                        ManagementBaseObject setDNS = mo.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);

                        break;
                    }
                }
            }
            return true;
        }
         
    }
}
