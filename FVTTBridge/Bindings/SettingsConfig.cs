
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SettingsConfig{
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onClickSubmenu(dynamic evt){return null;}//dummy return
       public dynamic _onResetDefaults(dynamic evt){return null;}//dummy return
       public dynamic _updateObject(dynamic evt, dynamic formData){return null;}//dummy return

    }
        
}