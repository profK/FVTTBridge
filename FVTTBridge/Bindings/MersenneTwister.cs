
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class MersenneTwister{
       public MersenneTwister(dynamic seed){}//dummy body
       public dynamic mt;
       public dynamic mti;
       public dynamic seed(dynamic seed){return null;}//dummy return
       public dynamic seedArray(dynamic vector){return null;}//dummy return
       [Name("int")]
       public dynamic integer(){return null;}//dummy return
       public dynamic int31(){return null;}//dummy return
       public dynamic real(){return null;}//dummy return
       public dynamic realx(){return null;}//dummy return
       public dynamic rnd(){return null;}//dummy return
       public dynamic random(){return null;}//dummy return
       public dynamic rndHiRes(){return null;}//dummy return

    }
        
}