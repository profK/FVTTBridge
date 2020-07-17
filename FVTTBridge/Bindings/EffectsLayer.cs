
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class EffectsLayer{
       public dynamic emitters;
       public dynamic weatherEffect;
       public dynamic weather;
       public dynamic tearDown(){return null;}//dummy return
       public dynamic draw(){return null;}//dummy return
       public dynamic drawWeather(){return null;}//dummy return

    }
        
}