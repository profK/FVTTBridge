
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class BasePlaceableHUD{
       [Name("object")]
       public dynamic jsobject;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic layer(){return null;}//dummy return
       public dynamic bind(dynamic jsobject){return null;}//dummy return
       public dynamic clear(){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic setPosition(dynamic options){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onToggleVisibility(dynamic evt){return null;}//dummy return
       public dynamic _onToggleLocked(dynamic evt){return null;}//dummy return
       public dynamic _onSort(dynamic up, dynamic evt){return null;}//dummy return

    }
        
}