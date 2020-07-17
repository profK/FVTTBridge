
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Die{
       public dynamic rolls;
       public dynamic sides;
       public dynamic faces;
       public dynamic options;
       public dynamic results(){return null;}//dummy return
       public dynamic total(){return null;}//dummy return
       public dynamic _getFaces(dynamic f){return null;}//dummy return
       public dynamic _roll(){return null;}//dummy return
       public dynamic roll(dynamic nd){return null;}//dummy return
       public dynamic reroll(dynamic targets){return null;}//dummy return
       public dynamic explode(dynamic range){return null;}//dummy return
       public dynamic keepHighest(dynamic n){return null;}//dummy return
       public dynamic keepLowest(dynamic n){return null;}//dummy return
       public dynamic countSuccess(dynamic target, dynamic operator){return null;}//dummy return
       public dynamic _getTooltip(dynamic result){return null;}//dummy return
       public dynamic fromFormula(dynamic formula){return null;}//dummy return
       public dynamic applyModifiers(dynamic query){return null;}//dummy return
       public dynamic _applyReroll(dynamic option){return null;}//dummy return
       public dynamic _applyExplode(dynamic option){return null;}//dummy return
       public dynamic _applyKeepDrop(dynamic option){return null;}//dummy return
       public dynamic _applySuccess(dynamic option){return null;}//dummy return

    }
        
}