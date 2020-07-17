
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class SetupConfiguration{
       public dynamic setupURL(){return null;}//dummy return
       public dynamic checkPackage(optionsObject){return null;}//dummy return
       public dynamic getPackages(optionsObject){return null;}//dummy return
       public dynamic installPackage(optionsObject){return null;}//dummy return
       public dynamic uninstallPackage(optionsObject){return null;}//dummy return
       public dynamic getPackageScopes(){return null;}//dummy return
       public dynamic post(dynamic body){return null;}//dummy return

    }
        
}