using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class CombatTracker
    {
        public static dynamic defaultOptions;

        public Combat combat;
        public dynamic trackedResources;

        public virtual void activateListenbers() { }
        public virtual void createPopout() { }
        public virtual dynamic getData() {
            //dummy
            return null;
        }

        public virtual void initialize(Combat combat, bool render) { }

        public virtual void scrollToTurn() { }
        public virtual dynamic updateTrackedResources()
        {
            //dummy
            return null;
        }

    }
}
