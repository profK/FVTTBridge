
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Ray{
       public dynamic y0;
       public dynamic angle;
       public dynamic distance;
       public dynamic B;
       public dynamic dy;
       public dynamic x0;
       public dynamic slope;
       public dynamic dx;
       public dynamic A;
       public dynamic normAngle(){return null;}//dummy return
       public dynamic fromAngle(dynamic x, dynamic y, dynamic radians, dynamic distance){return null;}//dummy return
       public dynamic fromArrays(dynamic A, dynamic B){return null;}//dummy return
       public dynamic project(dynamic t){return null;}//dummy return
       public dynamic shiftAngle(dynamic offset, dynamic distance){return null;}//dummy return
       public dynamic intersectSegment(dynamic coords){return null;}//dummy return
       public dynamic _getIntersection(dynamic x1, dynamic y1, dynamic x2, dynamic y2, dynamic x3, dynamic y3, dynamic x4, dynamic y4){return null;}//dummy return

    }
        
}