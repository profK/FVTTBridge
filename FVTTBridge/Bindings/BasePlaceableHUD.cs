
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class BasePlaceableHUD{
       public dynamic object;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic layer(){return null;}//dummy return
       public dynamic bind(dynamic object){return null;}//dummy return
       public dynamic clear(){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic setPosition(dynamic options){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onToggleVisibility(dynamic event){return null;}//dummy return
       public dynamic _onToggleLocked(dynamic event){return null;}//dummy return
       public dynamic _onSort(dynamic up, dynamic event){return null;}//dummy return

    }
        
}