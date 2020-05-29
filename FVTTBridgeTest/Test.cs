using System;
using FVTTBridge;

namespace FVTTBridgeTest
{
    public class Test
    {
        public static void Main(string[] args)
        {
            new MySystem();
        }
    }

    public class MySystem : FVTTBridge.FoundrySystem
    {
       
       
        protected override void SystemInit()
        {
            Console.WriteLine("in MySystem Init");
            base.SystemInit();
        }

        
    }
}
