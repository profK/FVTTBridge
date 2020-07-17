
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class CameraPopoutAppWrapper{
       public dynamic element;
       public dynamic userId;
       public dynamic view;
       public dynamic position(){return null;}//dummy return
       public dynamic setPosition(optionsObject){return null;}//dummy return
       public dynamic _onResize(dynamic event){return null;}//dummy return
       public dynamic displayToFront(){return null;}//dummy return

    }
        
}