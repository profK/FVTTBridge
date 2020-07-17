
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SquareGrid{
       public dynamic draw(){return null;}//dummy return
       public dynamic _drawLine(dynamic points, dynamic lineColor, dynamic lineAlpha){return null;}//dummy return
       public dynamic getTopLeft(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getCenter(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getGridPositionFromPixels(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getPixelsFromGridPosition(dynamic row, dynamic col){return null;}//dummy return
       public dynamic getSnappedPosition(dynamic x, dynamic y, dynamic interval){return null;}//dummy return
       public dynamic shiftPosition(dynamic x, dynamic y, dynamic dx, dynamic dy){return null;}//dummy return
       public dynamic _getNearestVertex(dynamic x, dynamic y){return null;}//dummy return
       public dynamic highlightGridPosition(dynamic layer, optionsObject){return null;}//dummy return
       public dynamic measureDistances(dynamic segments, dynamic options){return null;}//dummy return
       public dynamic getNeighbors(dynamic row, dynamic col){return null;}//dummy return

    }
        
}