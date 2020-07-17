
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class PlayerList{
       public dynamic _showOffline;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic render(dynamic force, dynamic context){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _getUserContextOptions(){return null;}//dummy return
       public dynamic _onToggleOfflinePlayers(dynamic evt){return null;}//dummy return

    }
        
}