
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class InstallPackage{
       public dynamic setup;
       public dynamic packages;
       public dynamic _filterTimeout;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic getData(){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _onClickPackageTitle(dynamic evt){return null;}//dummy return
       public dynamic _onClickPackageInstall(dynamic evt){return null;}//dummy return
       public dynamic _onFilterResults(dynamic evt){return null;}//dummy return

    }
        
}