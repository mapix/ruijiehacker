/************************************************************************/
/*  Project Name : RuiJieHacker                                         */
/*  Author: luoweifeng1989                                              */
/*  Date: 2011-4-22                                                     */
/*  All Rights Reserved.                                                */
/************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Management;
using Microsoft.Win32;
using System.Windows.Forms;

namespace RuiJieHacker
{
    class LocalMacChanger
    {
        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        public static bool setLocalMacAddress(String macAddress)
        {
            RegistryKey nic = RegeditHelper.searchNetWorkInterface();
            if(nic == null)
            {
                MessageBox.Show("No NIC Found!");
            }
            return RegeditHelper.setRegeditData(nic, "NetworkAddress", macAddress);
        }

        /************************************************************************/
        /* 获取本地Mac Address                                                   */
        /************************************************************************/
        public static String getLocalMacAddress( )
        {
            ManagementClass mAdapter = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection mo = mAdapter.GetInstances();
            foreach (ManagementBaseObject m in mo)
            {
                if ((bool)m["IpEnabled"] == true)
                {
                    return m["MacAddress"].ToString();
                }
            }
            mo.Dispose();
            return null;
        }
    }
}
