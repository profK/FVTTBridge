
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Ruler{
       public dynamic user;
       public dynamic waypoints;
       public dynamic name;
       public dynamic destination;
       public dynamic _state;
       public dynamic color;
       public dynamic ruler;
       public dynamic labels;
       public dynamic active(){return null;}//dummy return
       public dynamic measure(dynamic destination, optionsObject){return null;}//dummy return
       public dynamic _getSegmentLabel(dynamic segmentDistance, dynamic totalDistance, dynamic isTotal){return null;}//dummy return
       public dynamic _highlightMeasurement(dynamic ray){return null;}//dummy return
       public dynamic moveToken(){return null;}//dummy return
       public dynamic _getMovementToken(){return null;}//dummy return
       public dynamic _getRaysFromWaypoints(dynamic waypoints, dynamic destination){return null;}//dummy return
       public dynamic clear(){return null;}//dummy return
       public dynamic _onDragStart(dynamic event){return null;}//dummy return
       public dynamic _onClickLeft(dynamic event){return null;}//dummy return
       public dynamic _onClickRight(dynamic event){return null;}//dummy return
       public dynamic _onMouseMove(dynamic event){return null;}//dummy return
       public dynamic _onMouseUp(dynamic event){return null;}//dummy return
       public dynamic _addWaypoint(dynamic point){return null;}//dummy return
       public dynamic _removeWaypoint(dynamic point, optionsObject){return null;}//dummy return
       public dynamic _endMeasurement(){return null;}//dummy return
       public dynamic toJSON(){return null;}//dummy return
       public dynamic update(dynamic data){return null;}//dummy return

    }
        
}