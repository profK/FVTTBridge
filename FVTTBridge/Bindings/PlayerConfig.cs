
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class PlayerConfig{
       public PlayerConfig(dynamic user, dynamic options){}//dummy body
       public dynamic user;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic title(){return null;}//dummy return
       public dynamic getData(){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onEditAvatar(dynamic evt){return null;}//dummy return
       public dynamic _updateObject(dynamic evt, dynamic formData){return null;}//dummy return

    }
        
}