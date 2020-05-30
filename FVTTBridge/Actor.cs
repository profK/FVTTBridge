using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge.Bindings
{
    public class Actor
    {
        public virtual dynamic PrepareData(dynamic data)
        {
            Console.WriteLine(">>> PrepareData");
            return data;
        }
    }
}
