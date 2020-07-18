
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Combat{
       public Combat(params dynamic[] args){}//dummy body
       public dynamic _soundPlaying;
       public dynamic previous;
       public dynamic current;
       public dynamic config(){return null;}//dummy return
       public dynamic prepareEmbeddedEntities(){return null;}//dummy return
       public dynamic combatants(){return null;}//dummy return
       public dynamic combatant(){return null;}//dummy return
       public dynamic round(){return null;}//dummy return
       public dynamic turn(){return null;}//dummy return
       public dynamic scene(){return null;}//dummy return
       public dynamic settings(){return null;}//dummy return
       public dynamic started(){return null;}//dummy return
       public dynamic activate(){return null;}//dummy return
       public dynamic setupTurns(){return null;}//dummy return
       public dynamic startCombat(){return null;}//dummy return
       public dynamic nextTurn(){return null;}//dummy return
       public dynamic previousTurn(){return null;}//dummy return
       public dynamic nextRound(){return null;}//dummy return
       public dynamic previousRound(){return null;}//dummy return
       public dynamic resetAll(){return null;}//dummy return
       public dynamic endCombat(){return null;}//dummy return
       public dynamic getCombatant(dynamic id){return null;}//dummy return
       public dynamic getCombatantByToken(dynamic tokenId){return null;}//dummy return
       public dynamic setInitiative(dynamic id, dynamic value){return null;}//dummy return
       public dynamic rollInitiative(dynamic ids, dynamic formula, dynamic messageOptions){return null;}//dummy return
       public dynamic _getInitiativeFormula(dynamic combatant){return null;}//dummy return
       public dynamic _getInitiativeRoll(dynamic combatant, dynamic formula){return null;}//dummy return
       public dynamic rollNPC(params dynamic[] args){return null;}//dummy return
       public dynamic rollAll(params dynamic[] args){return null;}//dummy return
       public dynamic createCombatant(dynamic data, dynamic options){return null;}//dummy return
       public dynamic updateCombatant(dynamic data, dynamic options){return null;}//dummy return
       public dynamic deleteCombatant(dynamic id, dynamic options){return null;}//dummy return
       public dynamic _onCreate(params dynamic[] args){return null;}//dummy return
       public dynamic _onUpdate(dynamic data, params dynamic[] args){return null;}//dummy return
       public dynamic _onDelete(params dynamic[] args){return null;}//dummy return
       public dynamic _onDeleteEmbeddedEntity(dynamic embeddedName, dynamic child, dynamic options, dynamic userId){return null;}//dummy return
       public dynamic _onModifyEmbeddedEntity(params dynamic[] args){return null;}//dummy return

    }
        
}