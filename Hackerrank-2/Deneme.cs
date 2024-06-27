using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_2
{
    public class Deneme
    {
        public List<string> DeviceNameSystem(List<string> devicenames)
        {
            if (devicenames.Count > 1)
            {
                int uniqueCount;

                for (int i = 0; i < devicenames.Count; i++)
                {
                    uniqueCount = 0;
                    for (int j = i + 1; j < devicenames.Count; j++)
                    {
                        if (devicenames[i] == devicenames[j])
                        {
                            uniqueCount++;
                            devicenames[j] += uniqueCount;
                        }
                    }
                }
            }
            return devicenames;
        }
    }
}
