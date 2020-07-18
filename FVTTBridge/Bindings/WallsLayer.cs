
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class WallsLayer{
       public WallsLayer(){}//dummy body
       public dynamic _cloneType;
       public dynamic chain;
       public dynamic endpoints;
       public dynamic walls;
       public dynamic _chain;
       public dynamic _lastActive;
       public dynamic _forceSnap;
       public dynamic layerOptions(){return null;}//dummy return
       public dynamic blockVision(){return null;}//dummy return
       public dynamic blockMovement(){return null;}//dummy return
       public dynamic doors(){return null;}//dummy return
       public dynamic gridPrecision(){return null;}//dummy return
       public dynamic initialize(){return null;}//dummy return
       public dynamic draw(){return null;}//dummy return
       public dynamic activate(){return null;}//dummy return
       public dynamic deactivate(){return null;}//dummy return
       public dynamic _getVisionEndpoints(){return null;}//dummy return
       public dynamic _getClosestEndpoint(dynamic point, dynamic wall){return null;}//dummy return
       public dynamic checkCollision(dynamic ray){return null;}//dummy return
       public dynamic getWallCollisionsForRay(dynamic ray, dynamic walls, dynamic optionsObject){return null;}//dummy return
       public dynamic _getClosestCollisionPoint(dynamic ray, dynamic collisions){return null;}//dummy return
       public dynamic highlightControlledSegments(){return null;}//dummy return
       public dynamic releaseAll(){return null;}//dummy return
       public dynamic pasteObjects(dynamic position, dynamic options){return null;}//dummy return
       public dynamic _panCanvasEdge(dynamic evt, dynamic x, dynamic y){return null;}//dummy return
       public dynamic _getWallEndpointCoordinates(dynamic point, dynamic optionsObject){return null;}//dummy return
       public dynamic _getWallDataFromActiveTool(dynamic tool){return null;}//dummy return
       public dynamic _onClickLeft(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftStart(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftMove(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftDrop(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftCancel(dynamic evt){return null;}//dummy return
       public dynamic _onClickRight(dynamic evt){return null;}//dummy return

    }
        
}