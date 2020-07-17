
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class FormApplication{
       public dynamic editors;
       public dynamic jsobject;
       public dynamic filepickers;
       public dynamic form;
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic isEditable(){return null;}//dummy return
       public dynamic getData(dynamic options){return null;}//dummy return
       public dynamic _render(params dynamic[] args){return null;}//dummy return
       public dynamic _renderInner(params dynamic[] args){return null;}//dummy return
       public dynamic _getFormData(dynamic form){return null;}//dummy return
       public dynamic activateListeners(dynamic html){return null;}//dummy return
       public dynamic _disableFields(dynamic form){return null;}//dummy return
       public dynamic _onSubmit(dynamic evt, dynamic optionsObject){return null;}//dummy return
       public dynamic _onChangeInput(dynamic evt){return null;}//dummy return
       public dynamic _onChangeColorPicker(dynamic evt){return null;}//dummy return
       public dynamic _onChangeRange(dynamic evt){return null;}//dummy return
       public dynamic _updateObject(dynamic evt, dynamic formData){return null;}//dummy return
       public dynamic _activateEditor(dynamic div){return null;}//dummy return
       public dynamic _createEditor(dynamic target, dynamic editorOptions, dynamic initialContent){return null;}//dummy return
       public dynamic _onEditorSave(dynamic target, dynamic element, dynamic content){return null;}//dummy return
       public dynamic _activateFilePicker(dynamic button){return null;}//dummy return
       public dynamic close(dynamic options){return null;}//dummy return
       public dynamic submit(dynamic options){return null;}//dummy return

    }
        
}