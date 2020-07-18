
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class GridConfig{
       public GridConfig(dynamic scene, dynamic sheet, params dynamic[] args){}//dummy body
       public dynamic sheet;
       public dynamic _keyHandler;
       public dynamic _wheelHandler;
       public dynamic _dimensions;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic close(dynamic options){return null;}//dummy return
       public dynamic _onKeyDown(dynamic evt){return null;}//dummy return
       public dynamic _onWheel(dynamic evt){return null;}//dummy return
       public dynamic _onReset(dynamic evt){return null;}//dummy return
       public dynamic _scaleBackgroundSize(dynamic delta){return null;}//dummy return
       public dynamic _scaleGridSize(dynamic delta){return null;}//dummy return
       public dynamic _shiftBackground(dynamic optionsObject){return null;}//dummy return
       public dynamic _refresh(dynamic optionsObject){return null;}//dummy return
       public dynamic _onChangeInput(dynamic evt){return null;}//dummy return
       public dynamic _updateObject(dynamic evt, dynamic formData){return null;}//dummy return

    }
        
}