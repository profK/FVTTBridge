
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ControlsLayer{
       public ControlsLayer(){}//dummy body
       public dynamic _cursors;
       public dynamic select;
       public dynamic cursors;
       public dynamic rulers;
       public dynamic _rulers;
       public dynamic doors;
       public dynamic effects;
       public dynamic ruler(){return null;}//dummy return
       public dynamic getRulerForUser(dynamic userId){return null;}//dummy return
       public dynamic draw(){return null;}//dummy return
       public dynamic drawCursors(){return null;}//dummy return
       public dynamic drawDoors(){return null;}//dummy return
       public dynamic drawRulers(){return null;}//dummy return
       public dynamic drawSelect(dynamic optionsObject){return null;}//dummy return
       public dynamic deactivate(){return null;}//dummy return
       public dynamic _onMoveCursor(dynamic evt){return null;}//dummy return
       public dynamic drawCursor(dynamic user){return null;}//dummy return
       public dynamic updateCursor(dynamic user, dynamic position){return null;}//dummy return
       public dynamic updateRuler(dynamic user, dynamic rulerData){return null;}//dummy return

    }
        
}