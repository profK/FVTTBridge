
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SoundsLayer{
       public SoundsLayer(params dynamic[] args){}//dummy body
       public dynamic _initialized;
       public dynamic layerOptions(){return null;}//dummy return
       public dynamic tearDown(){return null;}//dummy return
       public dynamic initialize(){return null;}//dummy return
       public dynamic update(){return null;}//dummy return
       public dynamic stopAll(){return null;}//dummy return
       public dynamic _onDragLeftStart(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftMove(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftDrop(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftCancel(dynamic evt){return null;}//dummy return

    }
        
}