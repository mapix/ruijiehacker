using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IpSwitcher
{
    class SampleIniHelper
    {
        static String sampleini = "# Config file of IpSwitcher\r\n"
            +"##############################################################\r\n"
            +"# lines begin with a '#' takes as comments \r\n"
            +"# use this file like below (just one ip address one line)\r\n"
            +"# enjoy yourself \r\n"
            +"# feedback: luoweifeng1989@gmail.com\r\n"
            +"##############################################################\r\n";
        public static Boolean CreateSampleIni(String filename)
        {
            bool sucess = false;
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(sampleini);
                sw.Flush();
                sw.Close();
                fs.Close();
                sucess = true;
            }
            catch (System.Exception ex)
            {	
            }
            return sucess;
        }
    }
}
