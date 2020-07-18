
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class TabsV2{
       public TabsV2(dynamic optionsObject){}//dummy body
       public dynamic callback;
       public dynamic _navSelector;
       public dynamic _contentSelector;
       public dynamic _nav;
       public dynamic _content;
       public dynamic active;
       public dynamic bind(dynamic html){return null;}//dummy return
       public dynamic activate(dynamic tabName, dynamic optionsObject){return null;}//dummy return
       public dynamic _onClickNav(dynamic evt){return null;}//dummy return

    }
        
}