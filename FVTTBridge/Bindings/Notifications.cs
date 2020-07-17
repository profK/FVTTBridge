
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Notifications{
       public dynamic active;
       public dynamic queue;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic initialize(){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic notify(dynamic message, dynamic type, dynamic optionsObject){return null;}//dummy return
       public dynamic info(dynamic message, dynamic options){return null;}//dummy return
       public dynamic warn(dynamic message, dynamic options){return null;}//dummy return
       public dynamic error(dynamic message, dynamic options){return null;}//dummy return
       public dynamic fetch(){return null;}//dummy return

    }
        
}