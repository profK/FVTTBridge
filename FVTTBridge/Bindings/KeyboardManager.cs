
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class KeyboardManager{
       public dynamic _moveKeys;
       public dynamic _downKeys;
       public dynamic _handled;
       public dynamic _wheelTime;
       public dynamic _moveTime;
       public dynamic _tabState;
       public dynamic _reset(){return null;}//dummy return
       public dynamic isDown(dynamic code){return null;}//dummy return
       public dynamic isCtrl(dynamic evt){return null;}//dummy return
       public dynamic getKey(dynamic evt){return null;}//dummy return
       public dynamic moveKeys(){return null;}//dummy return
       public dynamic digitKeys(){return null;}//dummy return
       public dynamic zoomKeys(){return null;}//dummy return
       public dynamic hasFocus(){return null;}//dummy return
       public dynamic _onKeyDown(dynamic evt){return null;}//dummy return
       public dynamic _onKeyUp(dynamic evt){return null;}//dummy return
       public dynamic _handleKeys(dynamic evt, dynamic key, dynamic up){return null;}//dummy return
       public dynamic _onCompositionEnd(dynamic evt){return null;}//dummy return
       public dynamic _onWheel(dynamic evt){return null;}//dummy return
       public dynamic _onTab(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onEscape(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onSpace(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onAlt(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onMovement(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _handleMovement(dynamic evt, dynamic layer){return null;}//dummy return
       public dynamic _handleCanvasPan(){return null;}//dummy return
       public dynamic _onDigit(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onKeyZ(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onKeyC(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onKeyV(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onKeyZoom(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return
       public dynamic _onDelete(dynamic evt, dynamic up, dynamic modifiers){return null;}//dummy return

    }
        
}