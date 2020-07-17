
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ChatLog{
       public dynamic _lastId;
       public dynamic _sentMessages;
       public dynamic _lastMessageTime;
       public dynamic _sentMessageIndex;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic collection(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic _renderBatch(dynamic size){return null;}//dummy return
       public dynamic renderPopout(dynamic original){return null;}//dummy return
       public dynamic deleteAll(){return null;}//dummy return
       public dynamic deleteMessage(dynamic messageId, optionsObject){return null;}//dummy return
       public dynamic notify(dynamic message){return null;}//dummy return
       public dynamic parse(dynamic message){return null;}//dummy return
       public dynamic postOne(dynamic message, dynamic notify){return null;}//dummy return
       public dynamic scrollBottom(){return null;}//dummy return
       public dynamic updateMessage(dynamic message, dynamic notify){return null;}//dummy return
       public dynamic updateTimestamps(){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic processMessage(dynamic message){return null;}//dummy return
       public dynamic _processDiceCommand(dynamic command, dynamic match, dynamic chatData, dynamic createOptions){return null;}//dummy return
       public dynamic _processWhisperCommand(dynamic command, dynamic match, dynamic chatData, dynamic createOptions){return null;}//dummy return
       public dynamic _processChatCommand(dynamic command, dynamic match, dynamic chatData, dynamic createOptions){return null;}//dummy return
       public dynamic _remember(dynamic message){return null;}//dummy return
       public dynamic _recall(dynamic increment){return null;}//dummy return
       public dynamic _contextMenu(dynamic html){return null;}//dummy return
       public dynamic _getEntryContextOptions(){return null;}//dummy return
       public dynamic _onChatKeyDown(dynamic event){return null;}//dummy return
       public dynamic _onChangeRollMode(dynamic event){return null;}//dummy return
       public dynamic _onDeleteMessage(dynamic event){return null;}//dummy return
       public dynamic _onDiceRollClick(dynamic event){return null;}//dummy return
       public dynamic _onExportLog(dynamic event){return null;}//dummy return
       public dynamic _onFlushLog(dynamic event){return null;}//dummy return
       public dynamic _onScrollLog(dynamic event){return null;}//dummy return

    }
        
}