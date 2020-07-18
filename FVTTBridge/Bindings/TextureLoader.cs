
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class TextureLoader{
       public TextureLoader(){}//dummy body
       public dynamic cache;
       public dynamic loadSceneTextures(dynamic scene){return null;}//dummy return
       public dynamic load(dynamic sources, dynamic optionsObject){return null;}//dummy return
       public dynamic loadTexture(dynamic src){return null;}//dummy return
       public dynamic _onProgress(dynamic src, dynamic progress, dynamic message){return null;}//dummy return
       public dynamic _onError(dynamic src, dynamic progress, dynamic error){return null;}//dummy return
       public dynamic loadImageTexture(dynamic src){return null;}//dummy return
       public dynamic loadVideoTexture(dynamic src){return null;}//dummy return
       public dynamic setCache(dynamic src, dynamic tex){return null;}//dummy return
       public dynamic getCache(dynamic src){return null;}//dummy return

    }
        
}