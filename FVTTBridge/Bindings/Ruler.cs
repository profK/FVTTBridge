
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Ruler{
       public Ruler(dynamic user, dynamic optionsObject){}//dummy body
       public dynamic user;
       public dynamic _state;
       public dynamic color;
       public dynamic name;
       public dynamic destination;
       public dynamic waypoints;
       public dynamic labels;
       public dynamic ruler;
       public dynamic active(){return null;}//dummy return
       public dynamic measure(dynamic destination, dynamic optionsObject){return null;}//dummy return
       public dynamic _getSegmentLabel(dynamic segmentDistance, dynamic totalDistance, dynamic isTotal){return null;}//dummy return
       public dynamic _highlightMeasurement(dynamic ray){return null;}//dummy return
       public dynamic moveToken(){return null;}//dummy return
       public dynamic _getMovementToken(){return null;}//dummy return
       public dynamic _getRaysFromWaypoints(dynamic waypoints, dynamic destination){return null;}//dummy return
       public dynamic clear(){return null;}//dummy return
       public dynamic _onDragStart(dynamic evt){return null;}//dummy return
       public dynamic _onClickLeft(dynamic evt){return null;}//dummy return
       public dynamic _onClickRight(dynamic evt){return null;}//dummy return
       public dynamic _onMouseMove(dynamic evt){return null;}//dummy return
       public dynamic _onMouseUp(dynamic evt){return null;}//dummy return
       public dynamic _addWaypoint(dynamic point){return null;}//dummy return
       public dynamic _removeWaypoint(dynamic point, dynamic optionsObject){return null;}//dummy return
       public dynamic _endMeasurement(){return null;}//dummy return
       public dynamic toJSON(){return null;}//dummy return
       public dynamic update(dynamic data){return null;}//dummy return

    }
        
}