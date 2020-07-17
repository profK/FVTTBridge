
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class CanvasAnimation{
       public dynamic ticker(){return null;}//dummy return
       public dynamic animateLinear(dynamic attributes, dynamic optionsObject){return null;}//dummy return
       public dynamic terminateAnimation(dynamic name){return null;}//dummy return
       public dynamic _animatePromise(dynamic fn, dynamic context, dynamic name, params dynamic[] args){return null;}//dummy return
       public dynamic _animateFrame(dynamic deltaTime, dynamic resolve, dynamic reject, dynamic attributes, dynamic duration, dynamic ontick){return null;}//dummy return

    }
        
}