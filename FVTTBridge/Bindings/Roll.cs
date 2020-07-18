
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Roll{
       public Roll(dynamic formula, dynamic data){}//dummy body
       public dynamic parts;
       public dynamic _result;
       public dynamic formula;
       public dynamic rgx;
       public dynamic _dice;
       public dynamic _formula;
       public dynamic data;
       public dynamic _total;
       public dynamic _rolled;
       public dynamic _replaceData(dynamic formula){return null;}//dummy return
       public dynamic result(){return null;}//dummy return
       public dynamic total(){return null;}//dummy return
       public dynamic dice(){return null;}//dummy return
       public dynamic diceRgx(){return null;}//dummy return
      // public dynamic rgx(){return null;}//dummy return
       public dynamic arithmeticOperators(){return null;}//dummy return
       public dynamic roll(){return null;}//dummy return
       public dynamic reroll(){return null;}//dummy return
       public dynamic _evalParentheticalTerms(dynamic formula){return null;}//dummy return
       public dynamic _evalPoolTerms(dynamic formula){return null;}//dummy return
       public dynamic _expandArithmeticTerms(dynamic terms){return null;}//dummy return
       public dynamic _replacePool(dynamic term, dynamic rgx){return null;}//dummy return
       public dynamic _validateResult(dynamic result){return null;}//dummy return
       public dynamic _safeEval(dynamic expression){return null;}//dummy return
       public dynamic render(dynamic chatOptions){return null;}//dummy return
       public dynamic getTooltip(){return null;}//dummy return
       public dynamic toMessage(dynamic messageData, dynamic optionsObject){return null;}//dummy return
       public dynamic alter(dynamic add, dynamic multiply){return null;}//dummy return
       public dynamic cleanFormula(dynamic formula){return null;}//dummy return
       public dynamic minimize(dynamic formula){return null;}//dummy return
       public dynamic maximize(dynamic formula){return null;}//dummy return
       public dynamic simulate(dynamic formula, dynamic n){return null;}//dummy return
       public dynamic toJSON(){return null;}//dummy return
       public dynamic fromJSON(dynamic json){return null;}//dummy return
       public dynamic fromData(dynamic data){return null;}//dummy return

    }
        
}