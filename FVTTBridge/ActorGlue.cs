using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class ActorGlue
    {
        public Actor Actor { get; }

        internal Item getOwnedItem(object v)
        {
            // dummy body
            return null;
        }

        internal void DeleteOwnedItem(object v)
        {
           // dummy body
        }
    }
}
