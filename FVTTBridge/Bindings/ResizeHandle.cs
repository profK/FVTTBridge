
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ResizeHandle{
       public dynamic offset;
       public dynamic refresh(dynamic bounds){return null;}//dummy return
       public dynamic updateDimensions(dynamic current, dynamic origin, dynamic destination, dynamic optionsObject){return null;}//dummy return

    }
        
}