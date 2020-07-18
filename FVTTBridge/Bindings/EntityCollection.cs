
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class EntityCollection{
       public EntityCollection(dynamic data){}//dummy body
       public dynamic apps;
       public dynamic _source;
       public dynamic _initialize(dynamic data){return null;}//dummy return
       public dynamic entities(){return null;}//dummy return
       public dynamic render(params dynamic[] args){return null;}//dummy return
       public dynamic name(){return null;}//dummy return
       public dynamic instance(){return null;}//dummy return
       public dynamic directory(){return null;}//dummy return
       [Name("object")]
       public dynamic jsobject(){return null;}//dummy return
       public dynamic entity(){return null;}//dummy return
       public dynamic getName(dynamic name, dynamic optionsObject){return null;}//dummy return
       public dynamic insert(dynamic entity){return null;}//dummy return
       public dynamic remove(dynamic id){return null;}//dummy return
       public dynamic importFromCollection(dynamic collection, dynamic entryId, dynamic updateData, dynamic options){return null;}//dummy return
       public dynamic fromCompendium(dynamic data){return null;}//dummy return

    }
        
}