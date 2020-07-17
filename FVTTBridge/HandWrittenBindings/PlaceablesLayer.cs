using Bridge;
using Bridge.jQuery2;
using Retyped;
using static Retyped.es2015_core;
using static Retyped.pixi_js;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class PlaceablesLayer
    {
        #region Fields
        public static string dataArray;
        public static PlaceablesLayer instance;
        public static dynamic layerOptions;
        public static PIXI.Container placeableClass;
        public PlaceableObject[] controlled;
        public float gridPrecision;
        public dynamic[] history;
        public BasePlaceableHUD hud;
        public PIXI.Container objects;
        public dynamic options;
        public PlaceableObject[] placeables;
        public dynamic preview;
        #endregion

        #region Methods
        public void activate() { }
        public PlaceableObject[] copyObjects() {
            //dummy
            return new PlaceableObject[0];
        }

        public Promise createMany(dynamic[] data, dynamic options)
        {
            //dummy
            return null;
        }

        public Promise createObject()
        {
            //dummy
            return null;
        }
        public virtual void deactivate() { }
        public void deleteAll() { }
        public Promise deleteMany(string[] ids, dynamic options)
        {
            //dummy
            return null;
        }

        public virtual void draw() { }

        public PlaceableObject get(string objectId)
        {
            //dummy
            return null;
        }

        public dynamic getDragDestination(PlaceableObject obj, dynamic destination, bool snap)
        {
            //dummy
            return null;
        }

        public Promise moveMany(float dx, float dy, bool rotate, Array<string> ids)
        {
            //dummy
            return null;
        }

        public Promise pasteObjects()
        {
            //dummy
            return null;
        }

        public float releaseAll() {
            //dummy
            return -1;
        }

        public Promise rotateMany(float angle, float delta, float snap, Array<string> ids)
        {
            //dummy
            return null;
        }

        public bool selectObjects(float x, float y, float width, float height, dynamic releaseOptions, dynamic controlOptions)
        {
            //dummy
            return false;
        }

        public bool storeHistory(string type, dynamic data)
        {
            //dummy
            return false;
        }

        public virtual void tearDown() { }

        public Promise undoHistory()
        {
            //dummy
            return null;
        }

        public Promise updateMany(Array<dynamic> data, dynamic options)
        {
            //dummy
            return null;
        }


    #endregion



    }
}