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
using System.Collections;
using System.Windows.Forms;


namespace RuiJieHacker
{
    class DoHacker
    {
        public Hashtable usableIpMacPairs = new Hashtable();
        public void execute(String macAddr)
        {
            if(macAddr != "")
            {
                LocalMacChanger.setLocalMacAddress(macAddr);
            }else{
                MessageBox.Show("No Mac Address Found In Your LAN！You Should Do Search First!");
                return;
            }
            //LocalIpChanger.setLocalIpAddress("172.30.142.244");
            NetWorkHelper.restartEthernet();
            MessageBox.Show("Ok,Now to restart your network with your self!");
        }
    }
}
