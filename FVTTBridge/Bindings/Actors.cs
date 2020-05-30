using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public static class Actors
    {
        public static void unregisterSheet(string sheetName, Type sheetToRemove){}
        public static void registerSheet(string sheetName, Type sheetToAdd, dynamic sheetOptions) { }
    }
}
