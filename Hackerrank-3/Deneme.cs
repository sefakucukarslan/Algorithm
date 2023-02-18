using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_3
{
    public class Deneme
    {
        public List<string> DeviceNameSystem(List<string> deviceNames)
        {
            List<string> list = new List<string>();
            list.Add(deviceNames.First());
            bool addItem;

            for (int i = 1; i < deviceNames.Count; i++)
            {
                addItem = true;

                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] == deviceNames[i])
                    {
                        addItem = false;
                    }
                }
                if (addItem)
                {
                    list.Add(deviceNames[i]);
                }
            }
            return list;
        }
    }
}
