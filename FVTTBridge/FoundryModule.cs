using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
using FVTTBridge.Bindings;
using System.Collections.Generic;

namespace FVTTBridge
{


    public class FoundryModule
    {
        private static Dictionary<string, FoundryModule> Instances = new Dictionary<string, FoundryModule>();


        
        public virtual dynamic GetOptions(dynamic options)
        {
            return options;
        }

        public FoundryModule Instance
        {
            get
            {
                return Instances[this.GetType().FullName];
            }
        }

        public FoundryModule()
        {
            FoundryModule.Instances.Add(this.GetType().FullName,this);
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