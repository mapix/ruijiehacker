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
using Microsoft.Win32;
using System.Windows.Forms;

namespace RuiJieHacker
{
    class RegeditHelper
    {
        /************************************************************************/
        /* 检索本地连接所用网卡并返回注册表项                                   */
        /************************************************************************/
        public static RegistryKey searchNetWorkInterface()
        {
            RegistryKey localNic = null;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey nics = hkml.OpenSubKey("SYSTEM", true)
                .OpenSubKey("CurrentControlSet", true)
                .OpenSubKey("Control", true)
                .OpenSubKey("Class", true)
                .OpenSubKey("{4D36E972-E325-11CE-BFC1-08002BE10318}",true);

            for (int i = 0; i < nics.SubKeyCount - 1; i++)
            {
                RegistryKey tmpNic = nics.OpenSubKey(i.ToString("0000"), true);
                if(
                   (tmpNic.GetValueNames().Contains("DriverDesc") && tmpNic.GetValue("DriverDesc").ToString().Contains("TM") )||
                   (tmpNic.GetValueNames().Contains("DriverDesc") && tmpNic.GetValue("DriverDesc").ToString().Contains("Realtek"))||
                  (tmpNic.GetValueNames().Contains("DriverDesc") && tmpNic.GetValue("DriverDesc").ToString().Contains("Ethernet"))
                )
                {
                    localNic = tmpNic;
                    MessageBox.Show("Detected Your NIC: " + localNic.GetValue("DriverDesc").ToString());
                    return localNic;
                }
                
            }
            return null;
        }


        /************************************************************************/
        /* 读取指定名称的注册表的值                                             */
        /************************************************************************/
        public static string GetRegistData(RegistryKey key,string name) 
        {
            if (key.GetValueNames().Contains(name))
                return key.GetValue(name).ToString();
            return null;
        } 



        /************************************************************************/
        /* 向注册表中写数据                                                     */
        /************************************************************************/

        public static bool setRegeditData(RegistryKey key, string name,string value) 
        {
            try
            {
                 key.SetValue(name, value);
                 MessageBox.Show("Your " + name + "changed to " + value + " sucessfully!");
                 return true;
            }catch(Exception e){
                 MessageBox.Show(e.Message);
                 return false;
            }
        } 
    }
}
