using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using TracertIP.Comm;

namespace TracertIP
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //检查文件
            var path = Application.StartupPath;
            if (!File.Exists($"{path}/qqwry.dat"))
            {
                var internalFile = new InternalFile();
                var isOk = internalFile.OutFile($"TracertIP.IPLibrary.qqwry.dat", $"/qqwry.dat");
            }
            //启动
            Application.Run(new Main());
        }
    }
}
