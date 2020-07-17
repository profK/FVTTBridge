
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Hooks{
       public static void on(string evt,Action fn){}
       public static void once(string evt,Action fn){}
       public static void off(string evt,Action fn){}
       public dynamic callAll(dynamic hook, params dynamic[] args){return null;}//dummy return
       public dynamic call(dynamic hook, params dynamic[] args){return null;}//dummy return
       public dynamic _call(dynamic hook, dynamic fn, dynamic args){return null;}//dummy return

    }
        
}