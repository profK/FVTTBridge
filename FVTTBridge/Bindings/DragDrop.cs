
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class DragDrop{
       public dynamic callbacks;
       public dynamic permissions;
       public dynamic dragSelector;
       public dynamic dropSelector;
       public dynamic bind(dynamic html){return null;}//dummy return
       public dynamic callback(dynamic evt, dynamic action){return null;}//dummy return
       public dynamic can(dynamic action, dynamic selector){return null;}//dummy return
       public dynamic _handleDragStart(dynamic evt){return null;}//dummy return
       public dynamic _handleDragOver(dynamic evt){return null;}//dummy return
       public dynamic _handleDrop(dynamic evt){return null;}//dummy return
       public dynamic createDragImage(dynamic img, dynamic width, dynamic height){return null;}//dummy return

    }
        
}