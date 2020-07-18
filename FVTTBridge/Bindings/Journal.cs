
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Journal{
       [Name("object")]
       public dynamic jsobject(){return null;}//dummy return
       public dynamic socketListeners(dynamic socket){return null;}//dummy return
       public dynamic _showEntry(dynamic entryId, dynamic mode, dynamic force){return null;}//dummy return

    }
        
}