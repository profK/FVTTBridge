
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class User{
       public dynamic viewedScene;
       public dynamic targets;
       public dynamic active;
       public dynamic config(){return null;}//dummy return
       public dynamic avatar(){return null;}//dummy return
       public dynamic character(){return null;}//dummy return
       public dynamic permissions(){return null;}//dummy return
       public dynamic isTrusted(){return null;}//dummy return
       public dynamic isGM(){return null;}//dummy return
       public dynamic isSelf(){return null;}//dummy return
       public dynamic can(dynamic permission){return null;}//dummy return
       public dynamic hasPermission(dynamic permission){return null;}//dummy return
       public dynamic hasRole(dynamic role){return null;}//dummy return
       public dynamic isRole(dynamic role){return null;}//dummy return
       public dynamic setPermission(dynamic permission, dynamic allowed){return null;}//dummy return
       public dynamic broadcastActivity(dynamic activityData){return null;}//dummy return
       public dynamic assignHotbarMacro(dynamic macro, dynamic slot, optionsObject){return null;}//dummy return
       public dynamic getHotbarMacros(dynamic page){return null;}//dummy return
       public dynamic updateTokenTargets(dynamic targetIds){return null;}//dummy return
       public dynamic _onCreate(params dynamic[] args){return null;}//dummy return
       public dynamic _onUpdate(dynamic data, params dynamic[] args){return null;}//dummy return

    }
        
}