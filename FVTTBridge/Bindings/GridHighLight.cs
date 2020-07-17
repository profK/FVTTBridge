
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class GridHighlight{
       public dynamic name;
       public dynamic positions;
       public dynamic highlight(dynamic x, dynamic y){return null;}//dummy return
       public dynamic clear(params dynamic[] args){return null;}//dummy return
       public dynamic destroy(params dynamic[] args){return null;}//dummy return

    }
        
}