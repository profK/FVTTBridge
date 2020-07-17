
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Dialog{
       public dynamic data;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic title(){return null;}//dummy return
       public dynamic getData(){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onClickButton(dynamic event){return null;}//dummy return
       public dynamic _onKeyDown(dynamic event){return null;}//dummy return
       public dynamic submit(dynamic button){return null;}//dummy return
       public dynamic close(){return null;}//dummy return
       public dynamic confirm(optionsObject, dynamic options){return null;}//dummy return

    }
        
}