
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ControlIcon{
       public dynamic bg;
       public dynamic borderColor;
       public dynamic interactive;
       public dynamic texture;
       public dynamic tintColor;
       public dynamic interactiveChildren;
       public dynamic size;
       public dynamic icon;
       public dynamic border;
       public dynamic hitArea;
       public dynamic rect;
       public dynamic draw(){return null;}//dummy return
       public dynamic _onHoverIn(dynamic evt){return null;}//dummy return
       public dynamic _onHoverOut(dynamic evt){return null;}//dummy return

    }
        
}