
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Item{
       public dynamic config(){return null;}//dummy return
       public dynamic uuid(){return null;}//dummy return
       public dynamic prepareData(){return null;}//dummy return
       public dynamic actor(){return null;}//dummy return
       public dynamic img(){return null;}//dummy return
       public dynamic type(){return null;}//dummy return
       public dynamic limited(){return null;}//dummy return
       public dynamic isOwned(){return null;}//dummy return
       public dynamic hasPerm(params dynamic[] args){return null;}//dummy return
       public dynamic update(dynamic data, dynamic options){return null;}//dummy return
       public dynamic delete(dynamic options){return null;}//dummy return
       public dynamic createOwned(dynamic itemData, dynamic actor){return null;}//dummy return

    }
        
}