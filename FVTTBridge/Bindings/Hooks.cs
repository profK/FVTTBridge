
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Hooks{
       public dynamic on(dynamic hook, dynamic fn){return null;}//dummy return
       public dynamic once(dynamic hook, dynamic fn){return null;}//dummy return
       public dynamic off(dynamic hook, dynamic fn){return null;}//dummy return
       public dynamic callAll(dynamic hook, params dynamic[] args){return null;}//dummy return
       public dynamic call(dynamic hook, params dynamic[] args){return null;}//dummy return
       public dynamic _call(dynamic hook, dynamic fn, dynamic args){return null;}//dummy return

    }
        
}