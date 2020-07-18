
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class CombatTracker{
       public CombatTracker(dynamic options){}//dummy body
       public dynamic _highlighted;
       public dynamic trackedResources;
       public dynamic combat;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic createPopout(){return null;}//dummy return
       public dynamic initialize(dynamic optionsObject){return null;}//dummy return
       public dynamic updateTrackedResources(){return null;}//dummy return
       public dynamic scrollToTurn(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onCombatCreate(dynamic evt){return null;}//dummy return
       public dynamic _onCombatDelete(dynamic evt){return null;}//dummy return
       public dynamic _onCombatCycle(dynamic evt){return null;}//dummy return
       public dynamic _onCombatControl(dynamic evt){return null;}//dummy return
       public dynamic _onCombatantControl(dynamic evt){return null;}//dummy return
       public dynamic _onCombatantMouseDown(dynamic evt){return null;}//dummy return
       public dynamic _onCombatantHover(dynamic evt){return null;}//dummy return
       public dynamic _onCombatantHoverOut(dynamic evt){return null;}//dummy return
       public dynamic _contextMenu(dynamic html){return null;}//dummy return
       public dynamic _getEntryContextOptions(){return null;}//dummy return
       public dynamic _showModifyCombatantInitiativeContext(dynamic li){return null;}//dummy return

    }
        
}