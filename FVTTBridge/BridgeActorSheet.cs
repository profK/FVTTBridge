using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
using Bridge.jQuery2;
using FVTTBridge.Bindings;

namespace FVTTBridge
{


    public class BridgeActorSheet
    {
        internal ActorSheetGlue Glue
        {
            get; set;
        }

        public BridgeActorSheet() { }
        public BridgeActorSheet(ActorSheetGlue glue)
        {
            Glue = glue;
        }

        public dynamic Options
        {
            get
            {
                return Glue.Options;
            }
        }

        public Actor Actor
        {
            get
            {
                return Glue.ActorGlue.Actor;
            }
        }

        public virtual void ActivateListeners(jQuery html)
        {

        }

        public void Render(bool v)
        {
            Glue.Render(v);
        }

        public dynamic getData()
        {
            return Glue.getData();
        }

    }
}
