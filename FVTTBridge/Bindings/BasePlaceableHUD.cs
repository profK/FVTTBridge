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
    public class BasePlaceableHUD
    {
        public static dynamic defaultOptions;

        public PlaceablesLayer layer;
        [Name("object")]
        public PlaceableObject placeableObj;

        public void activateListeners(jQuery html) { }
        public void bind(PlaceableObject obj) { }
        public void clear() { }
    }
}
