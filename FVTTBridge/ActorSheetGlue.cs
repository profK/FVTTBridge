using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class ActorSheetGlue
    {
        public dynamic actor;
        public static dynamic defaultOptions;
        public dynamic Options { get; }

        public ActorGlue ActorGlue{
            get {
                return actor;
            }
        }

        public void deleteOwnedItem(string itemId)
        {
            //dummy not generated
        }

        public void render(bool b)
        {
            //dummy not generated
        }

        public dynamic getData()
        {
            //dummy not generated
            return null;
        }

        internal void Render(bool v)
        {
           //dummy
        }
    }
}
