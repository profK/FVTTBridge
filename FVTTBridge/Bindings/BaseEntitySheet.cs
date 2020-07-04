using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;
using Bridge.jQuery2;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class BaseEntitySheet:FormApplication
    {
        public BaseEntitySheet (object objects):base(objects) { }
        public BaseEntitySheet(object objects, object options):base(objects,options) { }
        #region fields

        public Entity entity;
       
        #endregion

        public void render(bool force = false)
        {
            //dummy not generated
        }

        public void render(bool force, dynamic opts)
        {
            //dummy not generated
        }
    }
}
