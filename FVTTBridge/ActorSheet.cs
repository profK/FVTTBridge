using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
using Bridge.jQuery2;

namespace FVTTBridge
{

    public class ActorSheet
    {
        public ActorSheet()
        {
            Console.WriteLine("made an ActorSheet");
        }

        public virtual dynamic GetOptions(dynamic options)
        {
            Console.WriteLine(">> getting options");
            return options;
        }

        public void ActivateListeners(jQuery htmlObject)
        {
            Console.WriteLine(htmlObject.Text());
        }
    }
}
