
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class WorldSettingsStorage{
       public WorldSettingsStorage(dynamic settings){}//dummy body
       public dynamic getItem(dynamic key){return null;}//dummy return
       public dynamic setItem(dynamic key, dynamic value){return null;}//dummy return

    }
        
}