using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace IpSwitcher
{
    class ReadIni
    {
        public static ArrayList ReadAllIps()
        {
            if (!File.Exists("IpSwitcher.ini"))
            {
                SampleIniHelper.CreateSampleIni("IpSwitcher.ini");
            }
            ArrayList ips = new ArrayList();
            StreamReader objReader = new StreamReader("IpSwitcher.ini");
            string sLine = "";
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null && !sLine.Equals("") && !sLine.StartsWith("#"))
                    ips.Add(sLine);
            }
            objReader.Close();
            return ips;
        }
    }
}
