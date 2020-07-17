
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class ChatBubbles{
       public dynamic _panned;
       public dynamic template;
       public dynamic bubbles;
       public dynamic container(){return null;}//dummy return
       public dynamic say(dynamic token, dynamic message, optionsObject){return null;}//dummy return
       public dynamic _clearBubble(dynamic token){return null;}//dummy return
       public dynamic _renderHTML(dynamic data){return null;}//dummy return
       public dynamic _getMessageDimensions(dynamic message){return null;}//dummy return
       public dynamic _setPosition(dynamic token, dynamic html, dynamic dimensions){return null;}//dummy return
       public dynamic _getDuration(dynamic html){return null;}//dummy return

    }
        
}