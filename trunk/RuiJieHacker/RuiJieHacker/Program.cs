/************************************************************************/
/*  Project Name : RuiJieHacker                                         */
/*  Author: luoweifeng1989                                              */
/*  Date: 2011-4-22                                                     */
/*  All Rights Reserved.                                                */
/************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RuiJieHacker
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
