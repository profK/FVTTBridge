
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SceneControls{
       public dynamic activeControl;
       public dynamic controls;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic control(){return null;}//dummy return
       public dynamic activeTool(){return null;}//dummy return
       public dynamic tool(){return null;}//dummy return
       public dynamic isRuler(){return null;}//dummy return
       public dynamic initialize(optionsObject){return null;}//dummy return
       public dynamic _getControlButtons(){return null;}//dummy return
       public dynamic getData(){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onClickLayer(dynamic event){return null;}//dummy return
       public dynamic _onClickTool(dynamic event){return null;}//dummy return

    }
        
}