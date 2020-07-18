
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Actors{
       public Actors(params dynamic[] args){}//dummy body
       public dynamic tokens;
       [Name("object")]
       public dynamic jsobject(){return null;}//dummy return
       public static void registerSheet(params dynamic[] sheets){}
       public dynamic unregisterSheet(params dynamic[] args){return null;}//dummy return
       public dynamic registeredSheets(){return null;}//dummy return

    }
        
}