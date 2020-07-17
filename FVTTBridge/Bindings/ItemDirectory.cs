
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ItemDirectory{
       public dynamic entity(){return null;}//dummy return
       public dynamic collection(){return null;}//dummy return
       public dynamic _canDragStart(dynamic selector){return null;}//dummy return
       public dynamic _canDragDrop(dynamic selector){return null;}//dummy return
       public dynamic _getEntryContextOptions(){return null;}//dummy return

    }
        
}