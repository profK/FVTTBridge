using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;


namespace FVTTBridge
{
   
    static public class Globals
    {
        static public  dynamic CONFIG;

        [Init(InitPosition.Bottom)]
        public static void TopInit()
        {
            CONFIG = Global.Get("CONFIG");
        }
    }

    [ObjectLiteral]
    public class RawJSObject
    {

    }

    public class FoundrySystem
    {
        private static FoundrySystem Instance;

        public virtual Actor MakeActor()
        {
            return new Actor();
        }

        public virtual ActorSheet MakeActorSheet(ActorSheetGlue glue)
        {
            return new ActorSheet(glue);
        }

        public virtual dynamic GetOptions(dynamic options)
        {
            return options;
        }


        public FoundrySystem()
        {
            Hooks.once("init",SystemInit);
            Instance = this;
        }

        protected virtual void SystemInit()
        {
            Console.WriteLine("SystemInit Called!");
            //Actors.registerSheet("core",ActorSheetType);
            Globals.CONFIG.Actor.entityClass = typeof(ActorGlue);
            dynamic sheetOptions = new RawJSObject();
            sheetOptions.makeDefault = true;
            Actors.registerSheet("dnd5e", typeof(ActorSheetGlue), sheetOptions);
            //Items.registerSheet("dnd5e", SimpleItemSheet, { makeDefault: true});
        }

       
    }
}
