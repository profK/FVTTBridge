
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Playlist{
       public dynamic audio;
       public dynamic playbackOrder;
       public dynamic config(){return null;}//dummy return
       public dynamic prepareEmbeddedEntities(){return null;}//dummy return
       public dynamic _createAudio(dynamic sound){return null;}//dummy return
       public dynamic _onEnd(dynamic soundId){return null;}//dummy return
       public dynamic _getPlaybackOrder(){return null;}//dummy return
       public dynamic _getNextSound(dynamic soundId){return null;}//dummy return
       public dynamic sounds(){return null;}//dummy return
       public dynamic mode(){return null;}//dummy return
       public dynamic playing(){return null;}//dummy return
       public dynamic playSound(dynamic sound){return null;}//dummy return
       public dynamic playAll(){return null;}//dummy return
       public dynamic stopAll(){return null;}//dummy return
       public dynamic cycleMode(){return null;}//dummy return
       public dynamic _onUpdate(dynamic response){return null;}//dummy return
       public dynamic _onCreateEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onUpdateEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic updateData, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onDeleteEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onModifyEmbeddedEntity(params dynamic[] args){return null;}//dummy return
       public dynamic toCompendium(){return null;}//dummy return

    }
        
}