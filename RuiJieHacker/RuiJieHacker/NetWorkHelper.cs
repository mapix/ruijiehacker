
/************************************************************************/
/*  Project Name : RuiJieHacker                                         */
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
using System.ServiceProcess;
using System.Management;
using ROOT.CIMV2.Win32;

namespace RuiJieHacker
{
    class NetWorkHelper
    {
        /************************************************************************/
        /*  导入依赖的Win Socket相关的DLL文件                                   */
        /************************************************************************/
        [DllImport("ws2_32.dll")]
        private static extern int inet_addr(string cp);
        [DllImport("IPHLPAPI.dll")]
        private static extern int SendARP(Int32 DestIP, Int32 SrcIP, ref Int64 pMacAddr, ref Int32 PhyAddrLen);

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        public static void restartEthernet()
        {
            SelectQuery query = new SelectQuery("Win32_NetworkAdapter", "NetConnectionStatus=2");
            ManagementObjectSearcher search = new ManagementObjectSearcher(query);
            foreach (ManagementObject result in search.Get())
            {
                NetworkAdapter adapter = new NetworkAdapter(result);  

                // Here, we're selecting the LAN adapters.  
                if (adapter.AdapterType.Equals("Ethernet 802.3"))
                {
                    adapter.Disable();
                    adapter.Enable();
                }
            }  
        }

        /************************************************************************/
        /*  根据远程主机的 IP 地址取得主机的 MAC Address（IP必须是局域网网段）      */
        /************************************************************************/
        public static  string GetMacAddress(string hostip)
        {
            string Mac = "";
            try
            {
                Int32 ldest = inet_addr(hostip);                               
                Int64 macinfo = new Int64();
                Int32 len = 6;
                SendARP(ldest, 0, ref macinfo, ref len);
                string temmac = Convert.ToString(macinfo, 16).PadLeft(12, '0'); 
                Mac = temmac.Substring(0, 2).ToUpper();
                for (int i = 2; i < temmac.Length; i = i + 2)
                {
                    Mac = temmac.Substring(i, 2).ToUpper() + Mac;
                }
            }
            catch (Exception Mye)
            {
                MessageBox.Show(Mye.Message);
            }
            return Mac;
        }
    }
}
