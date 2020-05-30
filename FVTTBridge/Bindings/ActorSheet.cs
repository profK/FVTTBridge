using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
using Bridge.jQuery2;

namespace FVTTBridge.Bindings
{

    public class ActorSheet
    {
        private ActorSheetGlue _glue;

        protected dynamic Actor
        {
            get { return _glue.actor; }
        }

        protected dynamic Options
        {
            get { return ActorSheetGlue.defaultOptions; }
        }


        public ActorSheet(ActorSheetGlue glue)
        {
            _glue = glue;
        }

        public virtual dynamic GetOptions(dynamic options)
        {
            Console.WriteLine(">> getting options");
            return options;
        }

        public virtual void ActivateListeners(jQuery htmlObject)
        {
            Console.WriteLine(htmlObject.Text());
        }

        public dynamic GetData()
        {
            return _glue.getData();
        }

        public void Render(bool b)
        {
            _glue.render(b);
        }

        public void DeleteOwnedItem(string id)
        {
            _glue.deleteOwnedItem(id);
        }
    }
}
