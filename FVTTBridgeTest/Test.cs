using System;
using FVTTBridge.Bindings;

namespace FVTTBridgeTest
{
    public class Test
    {
        public static void Main(string[] args)
        {
            new MySystem();
        }
    }

    public class MySystem : FVTTBridge.Bindings.FoundrySystem
    {
       
       
        protected override void SystemInit()
        {
            Console.WriteLine("in MySystem Init");
            base.SystemInit();
        }

        
    }
}
