using System;
using System.Collections.Generic;

using System.Text;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    //根据纸张名称获取其所在本地机上的PaperSize：
    //调用的是PaperSizeGetter. GetPaperSizeId静态方法（是从水晶报表中reflect精

    //简出来的，版权归原作者所有） 
    class PaperSizeGetter
    {
        public static string OutputPort = String.Empty;
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DeviceCapabilities(string pDevice, string pPort, short fwCapabilities, IntPtr pOutput, IntPtr pDevMode);
        /// <summary>
        /// 获得pagesize对应的ID
        /// </summary>
        /// <param name="printer"></param>
        /// <param name="papersizeName"></param>
        /// <returns></returns>
        public static short GetPaperSizeId(string printer, string papersizeName)
        {
            string[] pagename = Get_PaperSizesName(printer);

            for (int i = 0; i < pagename.Length; i++)
            {
                string text1 = printer;
                if (pagename[i] == papersizeName)
                {
                    int num1 = FastDeviceCapabilities(0x10, IntPtr.Zero, -1, text1);
                    if (num1 == -1)
                    {
                        return 0;
                    }
                    int num2 = Marshal.SystemDefaultCharSize * 0x40;
                    IntPtr ptr1 = Marshal.AllocCoTaskMem(num2 * num1);
                    FastDeviceCapabilities(0x10, ptr1, -1, text1);
                    IntPtr ptr2 = Marshal.AllocCoTaskMem(2 * num1);
                    FastDeviceCapabilities(2, ptr2, -1, text1);
                    IntPtr ptr3 = Marshal.AllocCoTaskMem(8 * num1);
                    FastDeviceCapabilities(3, ptr3, -1, text1);

                    short num5 = Marshal.ReadInt16((IntPtr)(((long)ptr2) + (i * 2)));
                    Marshal.FreeCoTaskMem(ptr1);
                    Marshal.FreeCoTaskMem(ptr2);
                    Marshal.FreeCoTaskMem(ptr3);

                    return num5;
                }
            }
            return 0;
        }

        private static string[] Get_PaperSizesName(string printer)
        {
            Microsoft.Win32.RegistryKey rk;
            if (!printer.StartsWith(@"\\"))                 //本地打印机 
            {
                rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Print\\Printers\\" + printer + "\\DsDriver");
            }
            else                                                      //网络打印机 
            {
                string[] p = printer.Remove(0, 2).Split(new char[] { '\\' });
                string path = "SOFTWARE\\Microsoft\\Windows   NT\\CurrentVersion\\Print\\Providers\\LanMan Print Services\\Servers\\" + p[0] + "\\Printers\\" + p[1] + "\\DsDriver";
                rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(path);
            }
            string[] papers = (string[])(rk.GetValue("printMediaSupported"));
            return papers;
        }

        private static int FastDeviceCapabilities(short capability, IntPtr pointerToBuffer, int defaultValue, string printerName)
        {
            int num1 = DeviceCapabilities(printerName, OutputPort, capability, pointerToBuffer, IntPtr.Zero);
            if (num1 == -1)
            {
                return defaultValue;
            }
            return num1;
        }
    }
}
