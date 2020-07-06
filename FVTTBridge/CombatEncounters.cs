using Bridge;
using FVTTBridge.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Retyped.es2015_core;

namespace FVTTBridge
{
    [External]
    [Namespace(false)]
    public class CombatEncounters
    {
        public static CombatEncounters Instance;

        public Combat active;
        public Array<Combat> combats;
        [Name("object")]
        public Type typeObj;
        public dynamic settings;
        public Combat viewed; //?  docs say combat encounter but there is no encounter type in API

    }
}
