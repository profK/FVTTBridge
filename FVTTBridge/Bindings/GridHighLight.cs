
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class GridHighlight{
       public GridHighlight(dynamic name, params dynamic[] args){}//dummy body
       public dynamic positions;
       public dynamic name;
       public dynamic highlight(dynamic x, dynamic y){return null;}//dummy return
       public dynamic clear(params dynamic[] args){return null;}//dummy return
       public dynamic destroy(params dynamic[] args){return null;}//dummy return

    }
        
}