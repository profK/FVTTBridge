using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
using System.Collections;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class Actors:EntityCollection
    {
        #region statics
        public static void unregisterSheet(string sheetName, Type sheetToRemove){}
        public static void registerSheet(string sheetName, Type sheetToAdd, dynamic sheetOptions) { }
        #endregion

        #region members
        public static dynamic[] registeredSheets;
        public dynamic[] _source;
        public dynamic[] apps;
        public SidebarDirectory directory;
        public string entity;
        public dynamic[] entires;
        public string name;
        [Name("object")] 
        public dynamic entityObj; //maps to Actors.object in Actors.js
        public dynamic tokens;
        #endregion

        #region Methods
        
        #endregion



    }
}
