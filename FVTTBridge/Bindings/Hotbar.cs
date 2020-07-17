
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Hotbar{
       public dynamic page;
       public dynamic _hover;
       public dynamic _collapsed;
       public dynamic macros;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic _getMacrosByPage(dynamic page){return null;}//dummy return
       public dynamic collapse(){return null;}//dummy return
       public dynamic expand(){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _contextMenu(dynamic html){return null;}//dummy return
       public dynamic _onClickMacro(dynamic event){return null;}//dummy return
       public dynamic _onHoverMacro(dynamic event){return null;}//dummy return
       public dynamic _onClickPageControl(dynamic event){return null;}//dummy return
       public dynamic _canDragStart(dynamic selector){return null;}//dummy return
       public dynamic _onDragStart(dynamic event){return null;}//dummy return
       public dynamic _canDragDrop(dynamic selector){return null;}//dummy return
       public dynamic _onDrop(dynamic event){return null;}//dummy return
       public dynamic _getDropMacro(dynamic data){return null;}//dummy return
       public dynamic _onToggleBar(dynamic event){return null;}//dummy return

    }
        
}