
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SocketInterface{
       public dynamic dispatch(dynamic eventName, dynamic request){return null;}//dummy return
       public dynamic _handleError(dynamic err){return null;}//dummy return

    }
        
}