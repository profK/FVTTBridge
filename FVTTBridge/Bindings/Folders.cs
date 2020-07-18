
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Folders{
       public Folders(params dynamic[] args){}//dummy body
       public dynamic _expanded;
       [Name("object")]
       public dynamic jsobject(){return null;}//dummy return
       public dynamic render(dynamic force, dynamic context){return null;}//dummy return

    }
        
}