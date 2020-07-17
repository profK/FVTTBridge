using Bridge;
using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Retyped.howler;
using static Retyped.pixi_js;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class AmbientSound:PlaceableObject
    {
     

        #region fields
     
        public Howl howl;
        public float howlId;
        public new string id;

        public float radius;
      
        public Type type;
      
        #endregion

        #region region
        public override void activateListeners()
        {
            //dummy
            base.activateListeners();
        }

        public override bool can(User user, string action)
        {
            //dummy
            return base.can(user, action);
        }

        public override PlaceableObject clear()
        {
            //dummy
            return base.clear();)
        }

        public override PlaceableObject clone()
        {
            //dummy
            return base.clone();
        }

        public dynamic computeFOV()
        {
            //dummy
            return null;
        }

        public override bool control(dynamic options)
        {
            //dummy
            return false;
        }

        public override void delete()
        {
            //dummy
            base.delete();
        }

        public PlaceableObject draw()
        {
            //dummy
            return null;
        }

        public override dynamic getFlag(string scope, string key)
        {
            //dummy
            return base.getFlag(scope, key);
        }

        public void Play(bool isAudible,float volume) { }

        public override PlaceableObject refresh()
        {
            //dummy
            return base.refresh();
        }

        public override bool release(dynamic options)
        {
            //dummy
            return false;
        }

        public override Promise rotate(float angle, float snap)
        {
            //dummy
            return base.rotate(angle, snap);
        }

        public override Promise setFlag(string scope, string key, dynamic value)
        {
            //dummy
            return null; 
        }

        public override Promise unsetFlag(string scope, string key)
        {
            //dummy
            return base.unsetFlag(scope, key);
        }

        public override void update()
        {
            //dummy
            base.update();
        }
        #endregion
    }
}
