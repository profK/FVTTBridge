
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class MouseInteractionManager{
       public MouseInteractionManager(dynamic jsobject, dynamic layer, dynamic permissions, dynamic callbacks, dynamic options){}//dummy body
       public dynamic permissions;
       public dynamic _dragRight;
       public dynamic handlers;
       public dynamic callbacks;
       public dynamic jsobject;
       public dynamic state;
       public dynamic options;
       public dynamic lcTime;
       public dynamic rcTime;
       public dynamic layer;
       public dynamic dragTime;
       public dynamic target(){return null;}//dummy return
       public dynamic activate(){return null;}//dummy return
       public dynamic can(dynamic action, dynamic evt){return null;}//dummy return
       public dynamic callback(dynamic action, dynamic evt){return null;}//dummy return
       public dynamic states(){return null;}//dummy return
       public dynamic _activateHoverEvents(){return null;}//dummy return
       public dynamic _activateClickEvents(){return null;}//dummy return
       public dynamic _deactivateClickEvents(){return null;}//dummy return
       public dynamic _activateDragEvents(){return null;}//dummy return
       public dynamic _deactivateDragEvents(){return null;}//dummy return
       public dynamic _handleMouseOver(dynamic evt){return null;}//dummy return
       public dynamic _handleMouseOut(dynamic evt){return null;}//dummy return
       public dynamic _handleMouseDown(dynamic evt){return null;}//dummy return
       public dynamic _handleClickLeft(dynamic evt){return null;}//dummy return
       public dynamic _handleClickLeft2(dynamic evt){return null;}//dummy return
       public dynamic _handleRightDown(dynamic evt){return null;}//dummy return
       public dynamic _handleClickRight(dynamic evt){return null;}//dummy return
       public dynamic _handleClickRight2(dynamic evt){return null;}//dummy return
       public dynamic _handleMouseMove(dynamic evt){return null;}//dummy return
       public dynamic _handleDragStart(dynamic evt){return null;}//dummy return
       public dynamic _handleDragMove(dynamic evt){return null;}//dummy return
       public dynamic _handleMouseUp(dynamic evt){return null;}//dummy return
       public dynamic _handleDragDrop(dynamic evt){return null;}//dummy return
       public dynamic _handleDragCancel(dynamic evt){return null;}//dummy return

    }
        
}