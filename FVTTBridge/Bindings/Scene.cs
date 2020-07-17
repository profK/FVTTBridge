
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Scene{
       public dynamic _view;
       public dynamic _viewPosition;
       public dynamic config(){return null;}//dummy return
       public dynamic prepareEmbeddedEntities(){return null;}//dummy return
       public dynamic img(){return null;}//dummy return
       public dynamic active(){return null;}//dummy return
       public dynamic isView(){return null;}//dummy return
       public dynamic journal(){return null;}//dummy return
       public dynamic playlist(){return null;}//dummy return
       public dynamic view(){return null;}//dummy return
       public dynamic activate(){return null;}//dummy return
       public dynamic clone(dynamic createData, dynamic options){return null;}//dummy return
       public dynamic update(dynamic data, dynamic options){return null;}//dummy return
       public dynamic _onCreate(dynamic data, params dynamic[] args){return null;}//dummy return
       public dynamic _onUpdate(dynamic data, dynamic options, dynamic userId, dynamic context){return null;}//dummy return
       public dynamic _onDelete(params dynamic[] args){return null;}//dummy return
       public dynamic _onActivate(dynamic active){return null;}//dummy return
       public dynamic _onCreateEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onUpdateEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic updateData, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onDeleteEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onModifyEmbeddedEntity(params dynamic[] args){return null;}//dummy return
       public dynamic _handleCreateEmbeddedEntity(dynamic optionsObject){return null;}//dummy return
       public dynamic _handleUpdateEmbeddedEntity(dynamic optionsObject){return null;}//dummy return
       public dynamic _handleDeleteEmbeddedEntity(dynamic optionsObject){return null;}//dummy return
       public dynamic toCompendium(){return null;}//dummy return

    }
        
}