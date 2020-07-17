
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SetupConfiguration{
       public dynamic setupURL(){return null;}//dummy return
       public dynamic checkPackage(dynamic optionsObject){return null;}//dummy return
       public dynamic getPackages(dynamic optionsObject){return null;}//dummy return
       public dynamic installPackage(dynamic optionsObject){return null;}//dummy return
       public dynamic uninstallPackage(dynamic optionsObject){return null;}//dummy return
       public dynamic getPackageScopes(){return null;}//dummy return
       public dynamic post(dynamic body){return null;}//dummy return

    }
        
}