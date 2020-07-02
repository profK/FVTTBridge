using Bridge;
using Bridge.Html5;
using Bridge.jQuery2;
using Retyped.Primitive;

namespace FVTTBridge.Bindings
{
    public class FormApplication:Application
    {
        public FormApplication(object objects) { }
        public FormApplication(object objects, object options) { }


        #region 
        public new static dynamic defaultOptions;

        public new float appId;
        public dynamic editors;
        public new jQuery element;
        public jQuery[] filepickers;
        public HTMLElement form;
        public new string id;
        public Boolean isEditable;
        [Name("object")]
        public dynamic targetObj;
        public new dynamic options;
        public new Boolean popOut;
        public new dynamic position;
        public new Boolean rendered;
        public new string template;
        public new string title;
        #endregion

        #region methods
        public override void activateListeners(jQuery html)
        {
            //dummy
            base.activateListeners(html);
        }

        public override Promise close()
        {
            //dummy
            return base.close();
        }

        public override Promise getData()
        {
            //dummy
            return base.getData();
        }

        public override Promise maximize()
        {
            //dummy
            return base.maximize();
        }

        public override Promise minimize()
        {
            //dummy
            return base.minimize();
        }

        public override void render(bool force, dynamic options) { }

        public override dynamic setPosition(float left, float top, float width, float height, float scale)
        {
            //dummy
            return base.setPosition(left, top, width, height, scale);
        }

        public virtual FormApplication submit(dynamic options)
        {
            //dummy
            return null;
        }

        #endregion

    }
}