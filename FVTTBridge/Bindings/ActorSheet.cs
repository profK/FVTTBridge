using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
using Bridge.jQuery2;

namespace FVTTBridge.Bindings
{


    public class ActorSheet
    {
        protected ActorSheetGlue Glue
        {
            get; private set;
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
        public ActorSheet(ActorSheetGlue glue)
        {
            Glue = glue;
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
