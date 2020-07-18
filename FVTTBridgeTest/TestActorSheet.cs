using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.jQuery2;
using FVTTBridge;
using FVTTBridge.Bindings;

namespace FVTTBridgeTest
{
    class TestActorSheet: BridgeActorSheet
    {
        public TestActorSheet(ActorSheetGlue glue) : base(glue) { }
        
    }
}
