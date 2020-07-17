
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class CombatTracker{
       public dynamic combat;
       public dynamic _highlighted;
       public dynamic trackedResources;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic createPopout(){return null;}//dummy return
       public dynamic initialize(optionsObject){return null;}//dummy return
       public dynamic updateTrackedResources(){return null;}//dummy return
       public dynamic scrollToTurn(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onCombatCreate(dynamic event){return null;}//dummy return
       public dynamic _onCombatDelete(dynamic event){return null;}//dummy return
       public dynamic _onCombatCycle(dynamic event){return null;}//dummy return
       public dynamic _onCombatControl(dynamic event){return null;}//dummy return
       public dynamic _onCombatantControl(dynamic event){return null;}//dummy return
       public dynamic _onCombatantMouseDown(dynamic event){return null;}//dummy return
       public dynamic _onCombatantHover(dynamic event){return null;}//dummy return
       public dynamic _onCombatantHoverOut(dynamic event){return null;}//dummy return
       public dynamic _contextMenu(dynamic html){return null;}//dummy return
       public dynamic _getEntryContextOptions(){return null;}//dummy return
       public dynamic _showModifyCombatantInitiativeContext(dynamic li){return null;}//dummy return

    }
        
}