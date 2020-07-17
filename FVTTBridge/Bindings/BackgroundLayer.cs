
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class BackgroundLayer{
       public dynamic img;
       public dynamic layerOptions(){return null;}//dummy return
       public dynamic source(){return null;}//dummy return
       public dynamic isVideo(){return null;}//dummy return
       public dynamic tearDown(){return null;}//dummy return
       public dynamic draw(){return null;}//dummy return
       public dynamic activate(){return null;}//dummy return
       public dynamic createThumbnail(dynamic texture, dynamic optionsObject){return null;}//dummy return

    }
        
}