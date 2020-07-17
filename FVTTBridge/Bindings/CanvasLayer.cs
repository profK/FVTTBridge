
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class CanvasLayer{
       public dynamic _active;
       public dynamic name(){return null;}//dummy return
       public dynamic tearDown(){return null;}//dummy return
       public dynamic draw(){return null;}//dummy return
       public dynamic activate(){return null;}//dummy return
       public dynamic deactivate(){return null;}//dummy return

    }
        
}