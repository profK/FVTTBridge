
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ChatMessage{
       public dynamic _roll;
       public dynamic user;
       public dynamic config(){return null;}//dummy return
       public dynamic alias(){return null;}//dummy return
       public dynamic visible(){return null;}//dummy return
       public dynamic isAuthor(){return null;}//dummy return
       public dynamic isRoll(){return null;}//dummy return
       public dynamic isContentVisible(){return null;}//dummy return
       public dynamic roll(){return null;}//dummy return
       public dynamic render(dynamic force, dynamic options){return null;}//dummy return
       public dynamic create(dynamic data, dynamic options){return null;}//dummy return
       public dynamic _preprocessCreateData(dynamic data, dynamic optionsObject){return null;}//dummy return
       public dynamic _onCreate(dynamic data, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onUpdate(dynamic data, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onDelete(params dynamic[] args){return null;}//dummy return
       public dynamic export(){return null;}//dummy return
       public dynamic getWhisperRecipients(dynamic name){return null;}//dummy return
       public dynamic getWhisperIDs(dynamic name){return null;}//dummy return
       public dynamic getSpeaker(dynamic optionsObject){return null;}//dummy return
       public dynamic _getSpeakerFromToken(dynamic optionsObject){return null;}//dummy return
       public dynamic _getSpeakerFromActor(dynamic optionsObject){return null;}//dummy return
       public dynamic _getSpeakerFromUser(dynamic optionsObject){return null;}//dummy return
       public dynamic getRollData(){return null;}//dummy return
       public dynamic getSpeakerActor(dynamic speaker){return null;}//dummy return

    }
        
}