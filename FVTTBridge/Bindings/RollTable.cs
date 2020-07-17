
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class RollTable{
       public dynamic config(){return null;}//dummy return
       public dynamic prepareEmbeddedEntities(){return null;}//dummy return
       public dynamic results(){return null;}//dummy return
       public dynamic toMessage(dynamic results, optionsObject){return null;}//dummy return
       public dynamic draw(optionsObject){return null;}//dummy return
       public dynamic drawMany(dynamic number, optionsObject){return null;}//dummy return
       public dynamic normalize(){return null;}//dummy return
       public dynamic reset(){return null;}//dummy return
       public dynamic roll(optionsObject){return null;}//dummy return
       public dynamic _getResultsForRoll(dynamic value){return null;}//dummy return
       public dynamic _getResultChatText(dynamic result){return null;}//dummy return
       public dynamic getTableResult(dynamic id){return null;}//dummy return
       public dynamic _onCreateEmbeddedEntity(params dynamic[] args){return null;}//dummy return
       public dynamic _onDeleteEmbeddedEntity(params dynamic[] args){return null;}//dummy return
       public dynamic toCompendium(){return null;}//dummy return

    }
        
}