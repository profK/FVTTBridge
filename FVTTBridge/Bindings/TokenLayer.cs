
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class TokenLayer{
       public dynamic _tabIndex;
       public dynamic _tabCycle;
       public dynamic _lastWildcard;
       public dynamic layerOptions(){return null;}//dummy return
       public dynamic hud(){return null;}//dummy return
       public dynamic ownedTokens(){return null;}//dummy return
       public dynamic tearDown(){return null;}//dummy return
       public dynamic deactivate(){return null;}//dummy return
       public dynamic dropActor(dynamic actor, dynamic tokenData){return null;}//dummy return
       public dynamic releaseAll(){return null;}//dummy return
       public dynamic selectObjects(optionsObject){return null;}//dummy return
       public dynamic targetObjects(optionsObject, optionsObject){return null;}//dummy return
       public dynamic cycleTokens(dynamic forwards, dynamic reset){return null;}//dummy return
       public dynamic _getCycleOrder(){return null;}//dummy return
       public dynamic concludeAnimation(){return null;}//dummy return
       public dynamic getDragDestination(dynamic object, dynamic destination, dynamic snap){return null;}//dummy return
       public dynamic _onDropActorData(dynamic event, dynamic data){return null;}//dummy return

    }
        
}