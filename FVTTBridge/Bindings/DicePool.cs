
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class DicePool{
       public dynamic rolls;
       public dynamic modifiers;
       public dynamic total;
       public dynamic dice;
       public dynamic roll(){return null;}//dummy return
       public dynamic _parseModifiers(dynamic modifiers){return null;}//dummy return
       public dynamic _keepOrDrop(dynamic results, dynamic mod){return null;}//dummy return
       public dynamic _countSuccess(dynamic results, dynamic mod){return null;}//dummy return
       public dynamic fromFormula(dynamic formula){return null;}//dummy return
       public dynamic toJSON(){return null;}//dummy return
       public dynamic fromData(dynamic data){return null;}//dummy return
       public dynamic fromJSON(dynamic json){return null;}//dummy return

    }
        
}