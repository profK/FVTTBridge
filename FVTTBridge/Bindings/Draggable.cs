
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Draggable{
       public dynamic app;
       public dynamic element;
       public dynamic handle;
       public dynamic handlers;
       public dynamic position;
       public dynamic _initializeDrag(){return null;}//dummy return
       public dynamic _initializeResize(){return null;}//dummy return
       public dynamic _onDragMouseDown(dynamic evt){return null;}//dummy return
       public dynamic _onDragMouseMove(dynamic evt){return null;}//dummy return
       public dynamic _onDragMouseUp(dynamic evt){return null;}//dummy return
       public dynamic _onResizeMouseDown(dynamic evt){return null;}//dummy return
       public dynamic _onResizeMouseMove(dynamic evt){return null;}//dummy return
       public dynamic _onResizeMouseUp(dynamic evt){return null;}//dummy return
       public dynamic _floatToTop(){return null;}//dummy return

    }
        
}