using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    static class Hooks
    {
        public static void once(string hookName,Action hookcb){}
        public static void on(string hookName, Action hookcb) { }
        public static void off(string hookName, Action hookcb) { }
    }
}
