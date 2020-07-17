using Bridge;
using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class CanvasLayer
    {
        public virtual Promise draw()
        {
            //dummy
            return null;
        }

        public virtual void tearDown() { }


    }
}
