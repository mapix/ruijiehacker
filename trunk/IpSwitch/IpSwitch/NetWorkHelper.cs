
/************************************************************************/
/*  Project Name : IpSwitcher                                         */
/*  Author: luoweifeng1989                                              */
/*  Date: 2011-4-23                                                     */
/*  All Rights Reserved.                                                */
/************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using ROOT.CIMV2.Win32;
using NETCONLib;

namespace IpSwitcher
{
    class NetWorkHelper
    {


        //public static void restartEthernet2()
        //{
        //    SelectQuery query = new SelectQuery("Win32_NetworkAdapter", "NetConnectionStatus=2");
        //    ManagementObjectSearcher search = new ManagementObjectSearcher(query);
        //    foreach (ManagementObject result in search.Get())
        //    {
        //        NetworkAdapter adapter = new NetworkAdapter(result);

        //        // Here, we're selecting the LAN adapters.  
        //        if (adapter.AdapterType.Equals("Ethernet 802.3"))
        //        {
        //            adapter.Disable();
        //            MessageBox.Show("OK to automatic restart your network!");
        //            adapter.Enable();
        //        }
        //    }
        //}
        public static void restartEthernet()
        {
            NetSharingManagerClass netSharingMgr = new NetSharingManagerClass();
            INetSharingEveryConnectionCollection connections = netSharingMgr.EnumEveryConnection;
            foreach (INetConnection connection in connections)
            {
                
                INetConnectionProps connProps = netSharingMgr.get_NetConnectionProps(connection);
                if (connProps.MediaType == tagNETCON_MEDIATYPE.NCM_LAN )
                {
                    connection.Disconnect();
                    connection.Connect();
                }
            }

        }
    }
}
