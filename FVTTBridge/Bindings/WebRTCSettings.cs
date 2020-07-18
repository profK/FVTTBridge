
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class WebRTCSettings{
       public WebRTCSettings(){}//dummy body
       public dynamic _previousWorldSettings;
       public dynamic _debounceId;
       public dynamic _clientSettings;
       public dynamic _previousUsersEntitySettings;
       public dynamic _previousClientSettings;
       public dynamic _worldSettings;
       public dynamic getDefaultWorldSettings(){return null;}//dummy return
       public dynamic getDefaultClientSettings(){return null;}//dummy return
       public dynamic getDefaultUserSettings(){return null;}//dummy return
       public dynamic getClientSetting(dynamic key){return null;}//dummy return
       public dynamic setClientSetting(dynamic key, dynamic value){return null;}//dummy return
       public dynamic getWorldSetting(dynamic key){return null;}//dummy return
       public dynamic setWorldSetting(dynamic key, dynamic value){return null;}//dummy return
       public dynamic getUserSetting(dynamic userId, dynamic key){return null;}//dummy return
       public dynamic setUserSetting(dynamic userId, dynamic key, dynamic value){return null;}//dummy return
       public dynamic mode(){return null;}//dummy return
       public dynamic mode(dynamic value){return null;}//dummy return
       public dynamic worldSettings(){return null;}//dummy return
       public dynamic worldSettings(dynamic value){return null;}//dummy return
       public dynamic clientSettings(){return null;}//dummy return
       public dynamic clientSettings(dynamic value){return null;}//dummy return
       public dynamic debug(){return null;}//dummy return
       public dynamic debug(dynamic value){return null;}//dummy return
       public dynamic debugClient(){return null;}//dummy return
       public dynamic debugClient(dynamic value){return null;}//dummy return
       public dynamic onSettingsChanged(){return null;}//dummy return
       public dynamic _onSettingsChangedDebounced(){return null;}//dummy return
       public dynamic _dotNotationToUpperCase(dynamic name){return null;}//dummy return
       public dynamic _getAllUsersEntitySettings(){return null;}//dummy return
       public dynamic _createProperties(){return null;}//dummy return
       public dynamic _createGettersAndSetters(dynamic obj, dynamic settings, dynamic getter, dynamic setter){return null;}//dummy return
       public dynamic _createProxy(dynamic obj, dynamic getter, dynamic setter){return null;}//dummy return
       public dynamic users(){return null;}//dummy return
       public dynamic users(dynamic value){return null;}//dummy return
       public dynamic _getUserProxy(dynamic userId){return null;}//dummy return
       public dynamic _setUserObject(dynamic userId, dynamic value){return null;}//dummy return

    }
        
}