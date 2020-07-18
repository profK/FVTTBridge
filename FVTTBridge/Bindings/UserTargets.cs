
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class UserTargets{
       public UserTargets(dynamic user){}//dummy body
       public dynamic user;
       public dynamic ids(){return null;}//dummy return
       public dynamic add(dynamic token){return null;}//dummy return
       public dynamic clear(){return null;}//dummy return
       public dynamic delete(dynamic token){return null;}//dummy return
       public dynamic _hook(dynamic token, dynamic targeted){return null;}//dummy return

    }
        
}