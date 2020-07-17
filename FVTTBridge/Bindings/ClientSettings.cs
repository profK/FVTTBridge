
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ClientSettings{
       public dynamic menus;
       public dynamic settings;
       public dynamic storage;
       public dynamic sheet(){return null;}//dummy return
       public dynamic register(dynamic module, dynamic key, dynamic data){return null;}//dummy return
       public dynamic registerMenu(dynamic module, dynamic key, dynamic data){return null;}//dummy return
       public dynamic get(dynamic module, dynamic key){return null;}//dummy return
       public dynamic set(dynamic module, dynamic key, dynamic value){return null;}//dummy return
       public dynamic _update(dynamic setting, dynamic key, dynamic value){return null;}//dummy return
       public dynamic socketListeners(dynamic socket){return null;}//dummy return

    }
        
}