
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Playlists{
       public Playlists(params dynamic[] args){}//dummy body
       [Name("object")]
       public dynamic jsobject(){return null;}//dummy return
       public dynamic playing(){return null;}//dummy return
       public dynamic _onUpdateScene(dynamic scene, dynamic data, dynamic options){return null;}//dummy return

    }
        
}