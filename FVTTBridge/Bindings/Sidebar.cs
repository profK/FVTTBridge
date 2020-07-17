
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Sidebar{
       public dynamic apps;
       public dynamic _collapsed;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic activeTab(){return null;}//dummy return
       public dynamic popouts(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic activateTab(dynamic tabName){return null;}//dummy return
       public dynamic expand(){return null;}//dummy return
       public dynamic collapse(){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onChangeTab(dynamic event, dynamic tabs, dynamic active){return null;}//dummy return
       public dynamic _onRightClickTab(dynamic event){return null;}//dummy return
       public dynamic _onToggleCollapse(dynamic event){return null;}//dummy return

    }
        
}