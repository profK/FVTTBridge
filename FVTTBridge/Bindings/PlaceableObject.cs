using Bridge;
using Bridge.jQuery2;
using Retyped;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Retyped.pixi_js;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class PlaceableObject:PIXI.Container
    {
        #region fields
        public static string embeddedName;
        public static PlaceablesLayer layer;
        public PIXI.Point center;
        public ControlIcon controlIcon;
        public dynamic data;
        public float dimRadius;
        public PIXI.Polygon fov;
        public string id;
        public PIXI.Polygon los;
        public MouseInteractionManager mouseInteractionManager;
        public Scene scene;
        public FormApplication sheet;
        public string uuid;
        public dynamic vision;
        #endregion

        #region methods
        public PlaceableObject create()
        {
            //dummy
            return null;
        }

       

        public virtual bool can(User user, string action)
        {
            //dummy
            return false;
        }

        public virtual PlaceableObject clear()
        {
            //dummy
            return null;
        }

        public virtual PlaceableObject clone()
        {
            //dummy
            return null;
        }

        public virtual  bool control(dynamic options)
        {
            //dummy
            return false;
        }

        public virtual void delete() { }

        

        public virtual dynamic getFlag(string scope, string key)
        {
            //dummy
            return null;
        }

       

        public virtual bool release(dynamic options)
        {
            //dummy
            return false;
        }

        public virtual Promise rotate(float angle, float snap)
        {
            //dummy
            return null;
        }

        public virtual Promise setFlag(string scope, string key, dynamic value)
        {
            //dummy
            return null;
        }

        public virtual Promise unsetFlag(string scope, string key)
        {
            //dummy
            return null;
        }


        public virtual void update() { }

        #endregion

        #region callbacks
        public virtual void activateListeners() { }

        public virtual PlaceableObject draw()
        {
            //dummy
            return null;
        }

        public virtual PlaceableObject refresh()
        {
            //dummy
            return null;
        }
        #endregion
    }
}
