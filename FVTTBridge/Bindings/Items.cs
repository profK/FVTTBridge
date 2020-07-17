
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Items{
       public dynamic object(){return null;}//dummy return
       public dynamic registerSheet(params dynamic[] args){return null;}//dummy return
       public dynamic unregisterSheet(params dynamic[] args){return null;}//dummy return
       public dynamic registeredSheets(){return null;}//dummy return

    }
        
}