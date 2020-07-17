
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class KeyboardManager{
       public dynamic _tabState;
       public dynamic _moveTime;
       public dynamic _wheelTime;
       public dynamic _moveKeys;
       public dynamic _handled;
       public dynamic _downKeys;
       public dynamic _reset(){return null;}//dummy return
       public dynamic isDown(dynamic code){return null;}//dummy return
       public dynamic isCtrl(dynamic event){return null;}//dummy return
       public dynamic getKey(dynamic event){return null;}//dummy return
       public dynamic moveKeys(){return null;}//dummy return
       public dynamic digitKeys(){return null;}//dummy return
       public dynamic zoomKeys(){return null;}//dummy return
       public dynamic hasFocus(){return null;}//dummy return
       public dynamic _onKeyDown(dynamic event){return null;}//dummy return
       public dynamic _onKeyUp(dynamic event){return null;}//dummy return
       public dynamic _handleKeys(dynamic event, dynamic key, dynamic up){return null;}//dummy return
       public dynamic _onCompositionEnd(dynamic event){return null;}//dummy return
       public dynamic _onWheel(dynamic event){return null;}//dummy return
       public dynamic _onTab(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onEscape(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onSpace(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onAlt(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onMovement(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _handleMovement(dynamic event, dynamic layer){return null;}//dummy return
       public dynamic _handleCanvasPan(){return null;}//dummy return
       public dynamic _onDigit(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onKeyZ(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onKeyC(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onKeyV(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onKeyZoom(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onDelete(dynamic event, dynamic up, dynamic modifiers){return null;}//dummy return

    }
        
}