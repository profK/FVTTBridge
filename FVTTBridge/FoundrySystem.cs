using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;


namespace FVTTBridge.Bindings
{
   
    static public class Globals
    {
        static public  dynamic CONFIG;
        static public dynamic GAME;

        [Init(InitPosition.Bottom)]
        public static void TopInit()
        {
            CONFIG = Global.Get("CONFIG");
            GAME = Global.Get("game");
        }
    }

    [ObjectLiteral]
    public class RawJSObject
    {

    }

    public class FoundrySystem
    {
        private static FoundrySystem Instance;
     


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

        public Actor MakeActor(ActorGlue glue)
        {
            Actor actor =  Activator.CreateInstance(ActorType) as Actor;
            actor.Glue = glue;
            return actor;
        }

        public ActorSheet MakeActorSheet(ActorSheetGlue glue)
        {
            ActorSheet actorSheet = Activator.CreateInstance(ActorSheetType) as ActorSheet;
            actorSheet.Glue = glue;
            return actorSheet;
        }

        public virtual dynamic GetOptions(dynamic options)
        {
            return options;
        }


        public FoundrySystem()
        {
            FoundrySystem.Instance = this;
            Hooks.once("init",SystemInit);
        }

        protected virtual void SystemInit()
        {
            Console.WriteLine("SystemInit Called!");
            //Actors.registerSheet("core",ActorSheetType);
            Globals.CONFIG.Actor.entityClass = ActorType;
            dynamic sheetOptions = new RawJSObject();
            sheetOptions.makeDefault = true;
            Actors.registerSheet("dnd5e", typeof(ActorSheetGlue), sheetOptions);
            //Items.registerSheet("dnd5e", SimpleItemSheet, { makeDefault: true});
        }

       
    }
}
