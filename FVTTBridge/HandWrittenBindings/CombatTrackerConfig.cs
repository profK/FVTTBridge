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
    public class CombatTrackerConfig
    {
        public virtual Promise getAttributeChoices()
        {
            //dummy
            return null;
        }

        public virtual dynamic getData()
        {
            //dummy
            return null;
        }
    }
}
