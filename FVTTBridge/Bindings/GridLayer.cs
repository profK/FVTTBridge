
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class GridLayer{
       public dynamic highlight;
       public dynamic highlightLayers;
       public dynamic grid;
       public dynamic type(){return null;}//dummy return
       public dynamic size(){return null;}//dummy return
       public dynamic w(){return null;}//dummy return
       public dynamic h(){return null;}//dummy return
       public dynamic draw(optionsObject){return null;}//dummy return
       public dynamic getSnappedPosition(dynamic x, dynamic y, dynamic interval){return null;}//dummy return
       public dynamic getTopLeft(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getCenter(dynamic x, dynamic y){return null;}//dummy return
       public dynamic measureDistance(dynamic origin, dynamic target){return null;}//dummy return
       public dynamic measureDistances(dynamic segments, dynamic options){return null;}//dummy return
       public dynamic addHighlightLayer(dynamic name){return null;}//dummy return
       public dynamic clearHighlightLayer(dynamic name){return null;}//dummy return
       public dynamic destroyHighlightLayer(dynamic name){return null;}//dummy return
       public dynamic getHighlightLayer(dynamic name){return null;}//dummy return
       public dynamic highlightPosition(dynamic name, dynamic options){return null;}//dummy return
       public dynamic isNeighbor(dynamic r0, dynamic c0, dynamic r1, dynamic c1){return null;}//dummy return

    }
        
}