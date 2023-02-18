using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> devicenames = new List<string>();
            devicenames.Add("tv");
            devicenames.Add("lamp");
            devicenames.Add("tv");
            devicenames.Add("mixer");
            devicenames.Add("tv");
            devicenames.Add("mixer");

            Deneme deneme = new Deneme();

            List<string> newDeviceNames = deneme.DeviceNameSystem(devicenames);

            foreach (var item in newDeviceNames)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
