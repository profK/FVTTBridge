
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SceneNavigation{
       public dynamic _collapsed;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic scenes(){return null;}//dummy return
       public dynamic render(dynamic force, dynamic context){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic expand(){return null;}//dummy return
       public dynamic collapse(){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _getContextMenuOptions(){return null;}//dummy return
       public dynamic _onClickScene(dynamic event){return null;}//dummy return
       public dynamic _onDragStart(dynamic event){return null;}//dummy return
       public dynamic _onDrop(dynamic event){return null;}//dummy return
       public dynamic _onToggleNav(dynamic event){return null;}//dummy return
       public dynamic _onLoadProgress(dynamic context, dynamic pct){return null;}//dummy return

    }
        
}