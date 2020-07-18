
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class CombatEncounters{
       public CombatEncounters(params dynamic[] args){}//dummy body
       public dynamic settings;
       [Name("object")]
       public dynamic jsobject(){return null;}//dummy return
       public dynamic combats(){return null;}//dummy return
       public dynamic active(){return null;}//dummy return
       public dynamic viewed(){return null;}//dummy return
       public dynamic instance(){return null;}//dummy return
       public dynamic _onDeleteToken(dynamic sceneId, dynamic tokenId){return null;}//dummy return

    }
        
}