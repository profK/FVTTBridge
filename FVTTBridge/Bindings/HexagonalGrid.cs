
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class HexagonalGrid{
       public HexagonalGrid(dynamic options){}//dummy body
       public dynamic h;
       public dynamic w;
       public dynamic even;
       public dynamic columns;
       public dynamic pointyHexPoints(){return null;}//dummy return
       public dynamic flatHexPoints(){return null;}//dummy return
       public dynamic draw(){return null;}//dummy return
       public dynamic getFlatHexPolygon(dynamic x, dynamic y, dynamic w, dynamic h){return null;}//dummy return
       public dynamic getPointyHexPolygon(dynamic x, dynamic y, dynamic w, dynamic h){return null;}//dummy return
       public dynamic _drawGrid(){return null;}//dummy return
       public dynamic _drawRows(dynamic grid, dynamic nrows, dynamic ncols){return null;}//dummy return
       public dynamic _drawColumns(dynamic grid, dynamic nrows, dynamic ncols){return null;}//dummy return
       public dynamic getGridPositionFromPixels(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getPixelsFromGridPosition(dynamic row, dynamic col){return null;}//dummy return
       public dynamic getTopLeft(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getCenter(dynamic x, dynamic y){return null;}//dummy return
       public dynamic getSnappedPosition(dynamic x, dynamic y, dynamic interval){return null;}//dummy return
       public dynamic shiftPosition(dynamic x, dynamic y, dynamic dx, dynamic dy){return null;}//dummy return
       public dynamic highlightGridPosition(dynamic layer, dynamic optionsObject){return null;}//dummy return
       public dynamic getNeighbors(dynamic row, dynamic col){return null;}//dummy return
       public dynamic measureDistances(dynamic segments, dynamic options){return null;}//dummy return
       public dynamic _offsetToCube(dynamic row, dynamic col){return null;}//dummy return
       public dynamic _cubeDistance(dynamic a, dynamic b){return null;}//dummy return

    }
        
}