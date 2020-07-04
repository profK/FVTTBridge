using Bridge;
using System.Runtime.InteropServices;
using static Retyped.es2015_collection;
using static Retyped.pixi_js;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class Token: PlaceableObject
    {
        #region  Fields
        public new static string embeddedName;
        public Actor actor;
        public float brightLightRadius;
        public float brightRadius;
        public float dimLightRadius;
        public float dimRadius;
        public bool emitsLight;
        public PIXI.Polygon fov;
        public float h;
        public bool hasActiveHUD;
        public bool hasLimitedVisionAngle;
        public bool hasSight;
        public bool inCombat;
        public bool isTargeted;
        public bool isVisible;
        public bool owner;
        public Set<User> targeted;
        public float w;
        #endregion

        #region Methods
        public void animateMovement(Ray ray) { }
        #endregion
    }
}