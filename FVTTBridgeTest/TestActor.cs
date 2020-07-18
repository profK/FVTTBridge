using FVTTBridge;
using FVTTBridge.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridgeTest

{
    class TestActor : BridgeActor
    {
        public TestActor(ActorGlue glue) : base(glue)
        {
            Console.WriteLine("in test actor");
        }

        
    }
}
