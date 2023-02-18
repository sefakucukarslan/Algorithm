using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> deviceNames = new List<string>();
            deviceNames.Add("tv");
            deviceNames.Add("lamp");
            deviceNames.Add("tv");
            deviceNames.Add("mixer");
            deviceNames.Add("tv");
            deviceNames.Add("mixer");

            Deneme deneme = new Deneme();
            List<string> newDeviceNames = deneme.DeviceNameSystem(deviceNames);
            Console.ReadLine();
        }
    }
}
