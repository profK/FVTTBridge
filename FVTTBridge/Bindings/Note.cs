
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Note{
       public Note(params dynamic[] args){}//dummy body
       public dynamic entry;
       public dynamic embeddedName(){return null;}//dummy return
       public dynamic text(){return null;}//dummy return
       public dynamic size(){return null;}//dummy return
       public dynamic draw(){return null;}//dummy return
       public dynamic _drawControlIcon(){return null;}//dummy return
       public dynamic _drawTooltip(){return null;}//dummy return
       public dynamic _getTextStyle(){return null;}//dummy return
       public dynamic refresh(){return null;}//dummy return
       public dynamic _onUpdate(dynamic data){return null;}//dummy return
       public dynamic _canHover(dynamic user){return null;}//dummy return
       public dynamic _canView(dynamic user){return null;}//dummy return
       public dynamic _onHoverIn(dynamic evt, dynamic options){return null;}//dummy return
       public dynamic _onHoverOut(dynamic evt){return null;}//dummy return
       public dynamic _onClickLeft2(dynamic evt){return null;}//dummy return

    }
        
}