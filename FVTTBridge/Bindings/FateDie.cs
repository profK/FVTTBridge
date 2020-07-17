
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class FateDie{
       public dynamic sides;
       public dynamic _getTooltip(dynamic result){return null;}//dummy return

    }
        
}