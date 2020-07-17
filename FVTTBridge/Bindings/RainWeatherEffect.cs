
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class RainWeatherEffect{
       public dynamic label(){return null;}//dummy return
       public dynamic getParticleEmitters(){return null;}//dummy return
       public dynamic _getRainEmitter(dynamic parent){return null;}//dummy return
       public dynamic _getSplashEmitter(dynamic parent){return null;}//dummy return

    }
        
}