using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;


namespace FVTTBridge
{

    public class System
    {
        [External]
        [Namespace(false)]
        static public class Globals
        {
            static public readonly dynamic CONFIG;
        }

        public virtual Type ActorType
        {
            get
            {
                return typeof(Actor);
            }
        }
        public virtual Type ActorSheetType
        {
            get
            {
                return typeof(ActorSheet);
            }
        }
        public virtual Type ItemSheetType { get; }

        public System()
        {
            Hooks.once("init",SystemInit);
            
        }

        protected virtual void SystemInit()
        {
            Console.WriteLine("SystemInit Called!");
            Actors.registerSheet("core",ActorSheetType);

        }

        
    }
}
