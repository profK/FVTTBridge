
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ControlIcon{
       public dynamic border;
       public dynamic texture;
       public dynamic size;
       public dynamic hitArea;
       public dynamic rect;
       public dynamic interactive;
       public dynamic interactiveChildren;
       public dynamic bg;
       public dynamic icon;
       public dynamic tintColor;
       public dynamic borderColor;
       public dynamic draw(){return null;}//dummy return
       public dynamic _onHoverIn(dynamic event){return null;}//dummy return
       public dynamic _onHoverOut(dynamic event){return null;}//dummy return

    }
        
}