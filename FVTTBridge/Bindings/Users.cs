
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Users{
       public dynamic current;
       public dynamic _initialize(dynamic data){return null;}//dummy return
       public dynamic object(){return null;}//dummy return
       public dynamic players(){return null;}//dummy return
       public dynamic socketListeners(dynamic socket){return null;}//dummy return
       public dynamic _handleUserActivity(dynamic userId, dynamic activityData){return null;}//dummy return

    }
        
}