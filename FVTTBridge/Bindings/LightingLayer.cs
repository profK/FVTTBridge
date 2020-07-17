
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class LightingLayer{
       public dynamic _darkness;
       public dynamic _animating;
       public dynamic layerOptions(){return null;}//dummy return
       public dynamic draw(){return null;}//dummy return
       public dynamic _drawLightingContainer(){return null;}//dummy return
       public dynamic initialize(){return null;}//dummy return
       public dynamic update(dynamic alpha){return null;}//dummy return
       public dynamic animateDarkness(dynamic target, dynamic optionsObject){return null;}//dummy return
       public dynamic _onDragLeftStart(dynamic evt){return null;}//dummy return
       public dynamic _onDragLeftMove(dynamic evt){return null;}//dummy return

    }
        
}