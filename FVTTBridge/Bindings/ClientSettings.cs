using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Retyped.es2015_collection;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class ClientSettings
    {
        public Map<string,dynamic> menus; // guess at <> param types
        public Map<string, dynamic> settings; // as above
        public Application sheet; //docs say GameSettingsApp is returned
        public dynamic storage; //unsure of class returned, docs not complete

        public static dynamic socketListeners; // again docs unclear
        public virtual dynamic get(string module, string key) 
        {
            //dummy
            return null;
        }

        public void register(string module, string key, dynamic data) { }

        public void registerMenu(string module, string key, dynamic data) { }

        public void set(string module, string key, dynamic value) { }


}
