
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Actor{
       public Actor(params dynamic[] args){}//dummy body
       public dynamic _tokenImages;
       public dynamic token;
       public dynamic config(){return null;}//dummy return
       public dynamic prepareData(){return null;}//dummy return
       public dynamic prepareEmbeddedEntities(){return null;}//dummy return
       public dynamic img(){return null;}//dummy return
       public dynamic itemTypes(){return null;}//dummy return
       public dynamic isPC(){return null;}//dummy return
       public dynamic isToken(){return null;}//dummy return
       public dynamic fromToken(dynamic token){return null;}//dummy return
       public dynamic createTokenActor(dynamic baseActor, dynamic token){return null;}//dummy return
       public dynamic getActiveTokens(dynamic linked){return null;}//dummy return
       public dynamic getRollData(){return null;}//dummy return
       public dynamic getTokenImages(){return null;}//dummy return
       public dynamic modifyTokenAttribute(dynamic attribute, dynamic value, dynamic isDelta, dynamic isBar){return null;}//dummy return
       public dynamic update(dynamic data, dynamic options){return null;}//dummy return
       public dynamic delete(dynamic options){return null;}//dummy return
       public dynamic createEmbeddedEntity(params dynamic[] args){return null;}//dummy return
       public dynamic updateEmbeddedEntity(params dynamic[] args){return null;}//dummy return
       public dynamic deleteEmbeddedEntity(params dynamic[] args){return null;}//dummy return
       public dynamic _onUpdate(dynamic data, dynamic options, dynamic userId, dynamic context){return null;}//dummy return
       public dynamic _onCreateEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onUpdateEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic updateData, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onDeleteEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic importItemFromCollection(dynamic collection, dynamic entryId){return null;}//dummy return
       public dynamic getOwnedItem(dynamic itemId){return null;}//dummy return
       public dynamic createOwnedItem(dynamic itemData, dynamic options){return null;}//dummy return
       public dynamic updateOwnedItem(dynamic itemData, dynamic options){return null;}//dummy return
       public dynamic deleteOwnedItem(dynamic itemId, dynamic options){return null;}//dummy return

    }
        
}