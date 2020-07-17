
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SidebarTab{
       public dynamic _original;
       public dynamic tabName;
       public dynamic _popout;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic _renderInner(dynamic data){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic activate(){return null;}//dummy return
       public dynamic close(){return null;}//dummy return
       public dynamic createPopout(){return null;}//dummy return
       public dynamic renderPopout(){return null;}//dummy return
       public dynamic _onLazyLoadImage(dynamic entries, dynamic observer){return null;}//dummy return

    }
        
}