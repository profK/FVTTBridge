
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Canvas{
       public Canvas(){}//dummy body
       public dynamic _zoomTime;
       public dynamic _panTime;
       public dynamic _reload;
       public dynamic scene;
       public dynamic ready;
       public dynamic dimensions;
       public dynamic _dragDrop;
       public dynamic pendingOperations;
       public dynamic stage;
       public dynamic mouseInteractionManager;
       public dynamic app;
       public dynamic id;
       public dynamic hud;
       public dynamic _pendingOperationNames;
       public dynamic _createLayers(dynamic stage){return null;}//dummy return
       public dynamic layers(){return null;}//dummy return
       public dynamic activeLayer(){return null;}//dummy return
       public dynamic tearDown(){return null;}//dummy return
       public dynamic draw(dynamic scene){return null;}//dummy return
       public dynamic getDimensions(dynamic optionsObject){return null;}//dummy return
       public dynamic _initialize(){return null;}//dummy return
       public dynamic _initializeCanvasPosition(){return null;}//dummy return
       public dynamic _initializeCanvasLayer(){return null;}//dummy return
       public dynamic _initializeTokenControl(){return null;}//dummy return
       public dynamic getLayer(dynamic layerName){return null;}//dummy return
       public dynamic getLayerByEmbeddedName(dynamic embeddedName){return null;}//dummy return
       public dynamic pan(dynamic optionsObject){return null;}//dummy return
       public dynamic animatePan(dynamic optionsObject){return null;}//dummy return
       public dynamic _constrainView(dynamic optionsObject){return null;}//dummy return
       public dynamic recenter(dynamic coordinates){return null;}//dummy return
       public dynamic _addListeners(){return null;}//dummy return
       public dynamic _onClickLeft(dynamic evt){return null;}//dummy return
       public dynamic _onClickLeft2(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftStart(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftMove(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftDrop(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftCancel(dynamic evt){return null;}//dummy return
       public dynamic _onClickRight(dynamic evt){return null;}//dummy return
       public dynamic _onDragRightMove(dynamic evt){return null;}//dummy return
       public dynamic _onDragRightDrop(dynamic evt){return null;}//dummy return
       public dynamic _onDragSelect(dynamic evt){return null;}//dummy return
       public dynamic _onDragCanvasPan(dynamic evt){return null;}//dummy return
       public dynamic _onResize(dynamic evt){return null;}//dummy return
       public dynamic _onMouseWheel(dynamic evt){return null;}//dummy return
       public dynamic _onDrop(dynamic evt){return null;}//dummy return
       public dynamic addPendingOperation(dynamic name, dynamic fn, dynamic scope, dynamic args){return null;}//dummy return
       public dynamic triggerPendingOperations(){return null;}//dummy return

    }
        
}