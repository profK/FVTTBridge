using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;

namespace FVTTBridge
{

    [External]
    [Namespace(false)]
    public class Actor
    {
        public virtual dynamic prepareData()
        {
            return default(object); // stub not actually generated
        }
    }
}