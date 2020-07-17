
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class TextEditor{
       public dynamic create(dynamic options, dynamic content){return null;}//dummy return
       public dynamic enrichHTML(dynamic content, optionsObject){return null;}//dummy return
       public dynamic previewHTML(dynamic content, dynamic length){return null;}//dummy return
       public dynamic _preloadCompendiumIndices(dynamic matches){return null;}//dummy return
       public dynamic _replaceContentLinks(dynamic match, dynamic entityType, dynamic id, dynamic name){return null;}//dummy return
       public dynamic _replaceCompendiumLink(dynamic match, dynamic id, dynamic name){return null;}//dummy return
       public dynamic _replaceEntityLink(dynamic match, dynamic entityType, dynamic id, dynamic name){return null;}//dummy return
       public dynamic _replaceHyperlinks(dynamic match, dynamic start, dynamic url){return null;}//dummy return
       public dynamic _replaceInlineRolls(dynamic match, dynamic command, dynamic formula, params dynamic[] args){return null;}//dummy return
       public dynamic activateListeners(){return null;}//dummy return
       public dynamic _onClickEntityLink(dynamic event){return null;}//dummy return
       public dynamic _onClickInlineRoll(dynamic event){return null;}//dummy return
       public dynamic _onDragEntityLink(dynamic event){return null;}//dummy return
       public dynamic _onDragStart(dynamic event){return null;}//dummy return
       public dynamic _onDropEditorData(dynamic event, dynamic editor){return null;}//dummy return

    }
        
}