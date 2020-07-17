
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class DoorControl{
       public dynamic wall;
       public dynamic draw(){return null;}//dummy return
       public dynamic drawIcon(){return null;}//dummy return
       public dynamic _getTexture(){return null;}//dummy return
       public dynamic reposition(){return null;}//dummy return
       public dynamic isVisible(){return null;}//dummy return
       public dynamic _onMouseOver(dynamic ev){return null;}//dummy return
       public dynamic _onMouseOut(dynamic ev){return null;}//dummy return
       public dynamic _onMouseDown(dynamic event){return null;}//dummy return
       public dynamic _onRightDown(dynamic event){return null;}//dummy return

    }
        
}