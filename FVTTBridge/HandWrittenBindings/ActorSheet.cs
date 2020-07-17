using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
using Bridge.jQuery2;

namespace FVTTBridge.Bindings
{


    public class ActorSheet
    {
        internal ActorSheetGlue Glue
        {
            get; set;
        }

        public ActorSheet() { }
        public ActorSheet(ActorSheetGlue glue)
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

        public  void Render(bool v)
        {
            Glue.Render(v);
        }

        public dynamic getData()
        {
            return Glue.getData();
        }

    }
}
