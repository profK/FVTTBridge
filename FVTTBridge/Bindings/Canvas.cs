
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Canvas{
       public dynamic hud;
       public dynamic mouseInteractionManager;
       public dynamic _dragDrop;
       public dynamic ready;
       public dynamic app;
       public dynamic _panTime;
       public dynamic pendingOperations;
       public dynamic _pendingOperationNames;
       public dynamic _zoomTime;
       public dynamic id;
       public dynamic _reload;
       public dynamic dimensions;
       public dynamic stage;
       public dynamic scene;
       public dynamic _createLayers(dynamic stage){return null;}//dummy return
       public dynamic layers(){return null;}//dummy return
       public dynamic activeLayer(){return null;}//dummy return
       public dynamic tearDown(){return null;}//dummy return
       public dynamic draw(dynamic scene){return null;}//dummy return
       public dynamic getDimensions(optionsObject){return null;}//dummy return
       public dynamic _initialize(){return null;}//dummy return
       public dynamic _initializeCanvasPosition(){return null;}//dummy return
       public dynamic _initializeCanvasLayer(){return null;}//dummy return
       public dynamic _initializeTokenControl(){return null;}//dummy return
       public dynamic getLayer(dynamic layerName){return null;}//dummy return
       public dynamic getLayerByEmbeddedName(dynamic embeddedName){return null;}//dummy return
       public dynamic pan(optionsObject){return null;}//dummy return
       public dynamic animatePan(optionsObject){return null;}//dummy return
       public dynamic _constrainView(optionsObject){return null;}//dummy return
       public dynamic recenter(dynamic coordinates){return null;}//dummy return
       public dynamic _addListeners(){return null;}//dummy return
       public dynamic _onClickLeft(dynamic event){return null;}//dummy return
       public dynamic _onClickLeft2(dynamic event){return null;}//dummy return
       public dynamic _onDragLeftStart(dynamic event){return null;}//dummy return
       public dynamic _onDragLeftMove(dynamic event){return null;}//dummy return
       public dynamic _onDragLeftDrop(dynamic event){return null;}//dummy return
       public dynamic _onDragLeftCancel(dynamic event){return null;}//dummy return
       public dynamic _onClickRight(dynamic event){return null;}//dummy return
       public dynamic _onDragRightMove(dynamic event){return null;}//dummy return
       public dynamic _onDragRightDrop(dynamic event){return null;}//dummy return
       public dynamic _onDragSelect(dynamic event){return null;}//dummy return
       public dynamic _onDragCanvasPan(dynamic event){return null;}//dummy return
       public dynamic _onResize(dynamic event){return null;}//dummy return
       public dynamic _onMouseWheel(dynamic event){return null;}//dummy return
       public dynamic _onDrop(dynamic event){return null;}//dummy return
       public dynamic addPendingOperation(dynamic name, dynamic fn, dynamic scope, dynamic args){return null;}//dummy return
       public dynamic triggerPendingOperations(){return null;}//dummy return

    }
        
}