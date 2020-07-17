
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class JournalEntry{
       public dynamic config(){return null;}//dummy return
       public dynamic visible(){return null;}//dummy return
       public dynamic sceneNote(){return null;}//dummy return
       public dynamic _onUpdate(dynamic data, params dynamic[] args){return null;}//dummy return
       public dynamic _onDelete(params dynamic[] args){return null;}//dummy return
       public dynamic show(dynamic mode, dynamic force){return null;}//dummy return
       public dynamic panToNote(dynamic optionsObject){return null;}//dummy return

    }
        
}