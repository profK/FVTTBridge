using Bridge;
using FVTTBridge.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class AmbientLight:PlaceableObject
    {
        #region fields
        public new static string embeddedName;
        public float brightRadius;
        public bool global;
        public bool isVisible;
        #endregion

        #region methods
        public dynamic computeFOV()
        {
            //dummy
            return null;
        }

        public override PlaceableObject draw()
        {
            //dummy
            return null;
        }

        public override PlaceableObject refresh()
        {
            //dummy
            return null;
        }


        #endregion
    }
}
