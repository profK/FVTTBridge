
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ControlIcon{
       public ControlIcon(dynamic optionsObject, params dynamic[] args){}//dummy body
       public dynamic texture;
       public dynamic bg;
       public dynamic icon;
       public dynamic interactiveChildren;
       public dynamic tintColor;
       public dynamic borderColor;
       public dynamic interactive;
       public dynamic size;
       public dynamic hitArea;
       public dynamic rect;
       public dynamic border;
       public dynamic draw(){return null;}//dummy return
       public dynamic _onHoverIn(dynamic evt){return null;}//dummy return
       public dynamic _onHoverOut(dynamic evt){return null;}//dummy return

    }
        
}