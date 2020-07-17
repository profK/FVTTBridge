
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Draggable{
       public dynamic handle;
       public dynamic app;
       public dynamic handlers;
       public dynamic position;
       public dynamic element;
       public dynamic _initializeDrag(){return null;}//dummy return
       public dynamic _initializeResize(){return null;}//dummy return
       public dynamic _onDragMouseDown(dynamic event){return null;}//dummy return
       public dynamic _onDragMouseMove(dynamic event){return null;}//dummy return
       public dynamic _onDragMouseUp(dynamic event){return null;}//dummy return
       public dynamic _onResizeMouseDown(dynamic event){return null;}//dummy return
       public dynamic _onResizeMouseMove(dynamic event){return null;}//dummy return
       public dynamic _onResizeMouseUp(dynamic event){return null;}//dummy return
       public dynamic _floatToTop(){return null;}//dummy return

    }
        
}