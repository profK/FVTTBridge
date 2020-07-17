
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SpecialEffect{
       public dynamic _stop;
       public dynamic emitters;
       public dynamic parent;
       public dynamic options;
       public dynamic label(){return null;}//dummy return
       public dynamic effectOptions(){return null;}//dummy return
       public dynamic getParticleEmitters(){return null;}//dummy return
       public dynamic play(dynamic duration){return null;}//dummy return
       public dynamic stop(){return null;}//dummy return
       public dynamic _startEmitter(dynamic emitter){return null;}//dummy return

    }
        
}