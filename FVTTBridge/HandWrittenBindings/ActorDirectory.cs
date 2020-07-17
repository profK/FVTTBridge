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
    public class ActorDirectory
    {
        public static Collection collection;
        public static Entity entity;

        #region Methods
        public bool _canDragDrop() { 
            //dummy
            return false;
        }

        public bool _canDragStart()
        {
            //dummy
            return false;
        }

        public dynamic _getEntryContextOptions() {
            //dummy
            return null;
        }

        public void _onDragStart() { }

        public void _onClickEntityName() { }

        public dynamic getData()
        {
            //dummy
            return null;
        }

        #endregion
    }
}
