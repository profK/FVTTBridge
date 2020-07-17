
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class VideoHelper{
       public dynamic pending;
       public dynamic videos;
       public dynamic locked;
       public dynamic thumbs;
       public dynamic hasVideoExtension(dynamic src){return null;}//dummy return
       public dynamic play(dynamic video){return null;}//dummy return
       public dynamic awaitFirstGesture(){return null;}//dummy return
       public dynamic _onFirstGesture(dynamic event){return null;}//dummy return
       public dynamic createThumbnail(dynamic src, dynamic options){return null;}//dummy return

    }
        
}