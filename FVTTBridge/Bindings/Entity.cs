
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Entity{
       public dynamic compendium;
       public dynamic apps;
       public dynamic data;
       public dynamic options;
       public dynamic config(){return null;}//dummy return
       public dynamic uuid(){return null;}//dummy return
       public dynamic initialize(){return null;}//dummy return
       public dynamic prepareData(){return null;}//dummy return
       public dynamic prepareEmbeddedEntities(){return null;}//dummy return
       public dynamic _constructEmbeddedEntity(dynamic embeddedName, dynamic data){return null;}//dummy return
       public dynamic getEmbeddedCollection(dynamic embeddedName){return null;}//dummy return
       public dynamic render(dynamic force, dynamic context){return null;}//dummy return
       public dynamic collection(){return null;}//dummy return
       public dynamic collection(){return null;}//dummy return
       public dynamic entity(){return null;}//dummy return
       public dynamic entity(){return null;}//dummy return
       public dynamic id(){return null;}//dummy return
       public dynamic _id(){return null;}//dummy return
       public dynamic name(){return null;}//dummy return
       public dynamic sheet(){return null;}//dummy return
       public dynamic _sheetClass(){return null;}//dummy return
       public dynamic folder(){return null;}//dummy return
       public dynamic permission(){return null;}//dummy return
       public dynamic owner(){return null;}//dummy return
       public dynamic visible(){return null;}//dummy return
       public dynamic limited(){return null;}//dummy return
       public dynamic hasPerm(dynamic user, dynamic permission, dynamic exact){return null;}//dummy return
       public dynamic can(dynamic user, dynamic action, dynamic target){return null;}//dummy return
       public dynamic can(dynamic user, dynamic action){return null;}//dummy return
       public dynamic activateSocketListeners(dynamic socket){return null;}//dummy return
       public dynamic create(dynamic data, dynamic options){return null;}//dummy return
       public dynamic _handleCreate(optionsObject){return null;}//dummy return
       public dynamic _onCreate(dynamic data, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic update(dynamic data, dynamic options){return null;}//dummy return
       public dynamic _handleUpdate(optionsObject){return null;}//dummy return
       public dynamic _onUpdate(dynamic data, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic update(dynamic data, dynamic options){return null;}//dummy return
       public dynamic delete(dynamic data, dynamic options){return null;}//dummy return
       public dynamic _handleDelete(optionsObject){return null;}//dummy return
       public dynamic _onDelete(dynamic options, dynamic userId){return null;}//dummy return
       public dynamic delete(dynamic options){return null;}//dummy return
       public dynamic getEmbeddedEntity(dynamic embeddedName, dynamic id, optionsObject){return null;}//dummy return
       public dynamic createEmbeddedEntity(dynamic embeddedName, dynamic data, dynamic options){return null;}//dummy return
       public dynamic _handleCreateEmbeddedEntity(optionsObject){return null;}//dummy return
       public dynamic _onCreateEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic updateEmbeddedEntity(dynamic embeddedName, dynamic data, dynamic options){return null;}//dummy return
       public dynamic _handleUpdateEmbeddedEntity(optionsObject){return null;}//dummy return
       public dynamic _onUpdateEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic updateData, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic deleteEmbeddedEntity(dynamic embeddedName, dynamic data, dynamic options){return null;}//dummy return
       public dynamic _handleDeleteEmbeddedEntity(optionsObject){return null;}//dummy return
       public dynamic _onDeleteEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onModifyEmbeddedEntity(dynamic embeddedName, dynamic changes, dynamic options, dynamic userId, dynamic context){return null;}//dummy return
       public dynamic getFlag(dynamic scope, dynamic key){return null;}//dummy return
       public dynamic setFlag(dynamic scope, dynamic key, dynamic value){return null;}//dummy return
       public dynamic unsetFlag(dynamic scope, dynamic key){return null;}//dummy return
       public dynamic sortRelative(optionsObject){return null;}//dummy return
       public dynamic clone(dynamic createData, dynamic options){return null;}//dummy return
       public dynamic toJSON(){return null;}//dummy return
       public dynamic exportToJSON(){return null;}//dummy return
       public dynamic importFromJSON(dynamic json){return null;}//dummy return
       public dynamic importFromJSONDialog(){return null;}//dummy return
       public dynamic toCompendium(){return null;}//dummy return

    }
        
}