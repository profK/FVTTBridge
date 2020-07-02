using Bridge;
using Bridge.jQuery2;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class Application
    {
        #region fields
        public static dynamic defaultOptions;

        public float appId;
        public jQuery element;
        public string id;
        public dynamic options;
        public bool popOut;
        public dynamic position;
        public bool rendered;
        public string template;
        public string title;
        #endregion

        #region methods
        public virtual void activateListeners(jQuery html) { }

        public virtual Promise close()
        {
            //dummy
            return null;
        }
        public virtual Promise getData() {
            //dummy
            return null;
        }

        public virtual  Promise maximize()
        {
            //dummy
            return null;
        }

        public virtual Promise minimize()
        {
            //dummy
            return null;
        }

        public virtual void render(bool force, dynamic options) { }

        public virtual dynamic setPosition(float left, float top, float width, float height, float scale)
        {
            //dummy

            return null;
        }


        #endregion
    }
}