
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Collection{
       public dynamic this[int i]{get;set;}
       public dynamic entries(){return null;}//dummy return
       public dynamic find(dynamic condition){return null;}//dummy return
       public dynamic filter(dynamic condition){return null;}//dummy return
       public dynamic get(dynamic key, optionsObject){return null;}//dummy return
       public dynamic map(dynamic transformer){return null;}//dummy return
       public dynamic reduce(dynamic evaluator, dynamic initial){return null;}//dummy return

    }
        
}