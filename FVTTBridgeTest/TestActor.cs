using FVTTBridge.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridgeTest

{
    class TestActor : Actor
    {
        public TestActor() : base()
        {

        }

        public override dynamic PrepareData(dynamic data)
        {
            data.Skills = new String[] { "foo" };
            return data;
        }
    }
}
