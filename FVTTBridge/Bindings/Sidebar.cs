
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Sidebar{
       public Sidebar(params dynamic[] args){}//dummy body
       public dynamic _collapsed;
       public dynamic apps;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic activeTab(){return null;}//dummy return
       public dynamic popouts(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic activateTab(dynamic tabName){return null;}//dummy return
       public dynamic expand(){return null;}//dummy return
       public dynamic collapse(){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onChangeTab(dynamic evt, dynamic tabs, dynamic active){return null;}//dummy return
       public dynamic _onRightClickTab(dynamic evt){return null;}//dummy return
       public dynamic _onToggleCollapse(dynamic evt){return null;}//dummy return

    }
        
}