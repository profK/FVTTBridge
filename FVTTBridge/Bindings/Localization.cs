
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Localization{
       public Localization(){}//dummy body
       public dynamic translations;
       public dynamic _fallback;
       public dynamic lang;
       public dynamic initialize(){return null;}//dummy return
       public dynamic _discoverLanguages(){return null;}//dummy return
       public dynamic _getTranslations(dynamic lang){return null;}//dummy return
       public dynamic _loadTranslationFile(dynamic src){return null;}//dummy return
       public dynamic setLanguage(dynamic lang){return null;}//dummy return
       public dynamic localize(dynamic stringId){return null;}//dummy return
       public dynamic format(dynamic stringId, dynamic data){return null;}//dummy return

    }
        
}