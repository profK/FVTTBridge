
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SetupConfigurationForm{
       public dynamic _tab;
       public dynamic modules;
       public dynamic _progressButton;
       public dynamic currentWorld;
       public dynamic worlds;
       public dynamic systems;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic tagPackageAvailability(dynamic pkg){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _post(dynamic data){return null;}//dummy return
       public dynamic _reload(){return null;}//dummy return
       public dynamic _onSubmitButton(dynamic event){return null;}//dummy return
       public dynamic _onSaveAdmin(dynamic event){return null;}//dummy return
       public dynamic _onWorldConfig(dynamic event){return null;}//dummy return
       public dynamic _onInstallPackageDialog(dynamic event){return null;}//dummy return
       public dynamic _onInstallPackage(dynamic packageType, dynamic manifestURL){return null;}//dummy return
       public dynamic _onUpdatePackage(dynamic event){return null;}//dummy return
       public dynamic _updateCheckOne(dynamic type, dynamic name, dynamic button){return null;}//dummy return
       public dynamic _updateDownloadOne(dynamic type, dynamic name, dynamic button){return null;}//dummy return
       public dynamic _onUninstallPackage(dynamic event){return null;}//dummy return
       public dynamic _onUpdatePackages(dynamic event){return null;}//dummy return
       public dynamic _onCoreUpdate(dynamic event){return null;}//dummy return
       public dynamic activateSocketListeners(){return null;}//dummy return
       public dynamic _updateProgressBar(dynamic data){return null;}//dummy return
       public dynamic _updateProgressButton(dynamic data){return null;}//dummy return

    }
        
}