using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbDeviceApp
{
    class Program
    {
        static string CheckValue(int value)
        {
            string result = value.ToString();

            if ((value % 3) == 0)
                result = "usb";

            if ((value % 5) == 0)
                result = (value % 3) == 0 ? "usbdevice" : "device";

            return result;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(CheckValue(i));
            }
        }
    }
}
