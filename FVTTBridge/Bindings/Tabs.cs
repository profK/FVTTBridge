
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Tabs{
       public dynamic active;
       public dynamic tab;
       public dynamic tabs;
       public dynamic container;
       public dynamic callback;
       public dynamic group(){return null;}//dummy return
       public dynamic activateTab(dynamic tab){return null;}//dummy return

    }
        
}