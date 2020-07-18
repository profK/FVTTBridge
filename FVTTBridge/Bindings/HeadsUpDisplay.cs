
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class HeadsUpDisplay{
       public HeadsUpDisplay(params dynamic[] args){}//dummy body
       public dynamic bubbles;
       public dynamic drawing;
       public dynamic tile;
       public dynamic token;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic getData(){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic align(){return null;}//dummy return

    }
        
}