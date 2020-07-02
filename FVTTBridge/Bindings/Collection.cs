using Bridge;
using System;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class Collection
    {

        public dynamic[] entries;

        public dynamic[] filter(Func<dynamic, bool> condition)
        {
            //dummy
            return null;
        }

        public dynamic find(Func<dynamic, bool> condition)
        {
            //dummy
            return null;
        }

        public dynamic get(string key, bool strict)
        {
            //dummy
            return null;
        }

        public dynamic[] map(Func<dynamic, dynamic> transformer)
        {
            //dummy
            return null;
        }

        //reduce func has params partialSolution,additionalData, returns result
        public dynamic reduce(Func<dynamic, dynamic, dynamic> reduceFunc)
        {
            //dummy
            return null;
        }
    }
}