
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class BaseGrid{
       public BaseGrid(dynamic options){}//dummy body
       public dynamic highlight;
       public dynamic h;
       public dynamic w;
       public dynamic options;
       public dynamic draw(){return null;}//dummy return
       public dynamic highlightGridPosition(dynamic layer, dynamic optionsObject){return null;}//dummy return
       public dynamic getTopLeft(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getCenter(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getSnappedPosition(dynamic x, dynamic y, dynamic interval){return null;}//dummy return
       public dynamic getGridPositionFromPixels(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getPixelsFromGridPosition(dynamic x, dynamic y){return null;}//dummy return
       public dynamic shiftPosition(dynamic x, dynamic y, dynamic dx, dynamic dy){return null;}//dummy return
       public dynamic measureDistances(dynamic segments, dynamic options){return null;}//dummy return
       public dynamic getNeighbors(dynamic row, dynamic col){return null;}//dummy return

    }
        
}