
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class LightingLayer{
       public dynamic _animating;
       public dynamic _darkness;
       public dynamic layerOptions(){return null;}//dummy return
       public dynamic draw(){return null;}//dummy return
       public dynamic _drawLightingContainer(){return null;}//dummy return
       public dynamic initialize(){return null;}//dummy return
       public dynamic update(dynamic alpha){return null;}//dummy return
       public dynamic animateDarkness(dynamic target, optionsObject){return null;}//dummy return
       public dynamic _onDragLeftStart(dynamic event){return null;}//dummy return
       public dynamic _onDragLeftMove(dynamic event){return null;}//dummy return

    }
        
}