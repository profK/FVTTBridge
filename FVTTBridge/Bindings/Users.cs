
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Users{
       public Users(params dynamic[] args){}//dummy body
       public dynamic current;
       public dynamic _initialize(dynamic data){return null;}//dummy return
       [Name("object")]
       public dynamic jsobject(){return null;}//dummy return
       public dynamic players(){return null;}//dummy return
       public dynamic socketListeners(dynamic socket){return null;}//dummy return
       public dynamic _handleUserActivity(dynamic userId, dynamic activityData){return null;}//dummy return

    }
        
}