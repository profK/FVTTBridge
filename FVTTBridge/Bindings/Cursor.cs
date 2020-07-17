
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Cursor{
       public dynamic target;
       public dynamic draw(dynamic user){return null;}//dummy return
       public dynamic _animate(){return null;}//dummy return
       public dynamic destroy(dynamic options){return null;}//dummy return

    }
        
}