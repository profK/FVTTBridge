
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class CameraPopoutAppWrapper{
       public CameraPopoutAppWrapper(dynamic view, dynamic userId, dynamic element){}//dummy body
       public dynamic userId;
       public dynamic view;
       public dynamic element;
       public dynamic position(){return null;}//dummy return
       public dynamic setPosition(dynamic optionsObject){return null;}//dummy return
       public dynamic _onResize(dynamic evt){return null;}//dummy return
       public dynamic displayToFront(){return null;}//dummy return

    }
        
}