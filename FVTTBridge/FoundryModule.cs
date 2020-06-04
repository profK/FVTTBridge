using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;


namespace FVTTBridge.Bindings
{


    public class FoundryModule
    {
        private static FoundryModule Instance;


        
        public virtual dynamic GetOptions(dynamic options)
        {
            return options;
        }


        public FoundryModule()
        {
            FoundryModule.Instance = this;
            Hooks.on("init", ModuleInit);
            Hooks.on("ready", ModuleReady);
        }

        protected virtual void ModuleInit()
        {
            Console.WriteLine("ModuleInit Called!");
            
        }

        protected virtual void ModuleReady()
        {
            Console.WriteLine("ModuleReady Called!");
        }


    }
}