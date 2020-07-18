
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Macros{
       [Name("object")]
       public dynamic jsobject(){return null;}//dummy return
       public dynamic instance(){return null;}//dummy return
       public dynamic directory(){return null;}//dummy return
       public dynamic canUseScripts(dynamic user){return null;}//dummy return

    }
        
}