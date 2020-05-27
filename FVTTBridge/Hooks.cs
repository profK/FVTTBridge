using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
namespace FVTTBridge
{
    [External]
    [Namespace(false)]
    static class Hooks
    {
        public static void once(string hookName,Action hookcb){}
    }
}
