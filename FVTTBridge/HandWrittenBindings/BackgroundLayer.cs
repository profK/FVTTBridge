using Bridge;
using Bridge.Html5;
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
    public class BackgroundLayer:CanvasLayer
    {
        #region fields
        public static dynamic layerOptions;
        public PIXI.Sprite img;
        public bool isVideo;
        public HTMLElement source;
        #endregion

        #region Methods
        public static string createThumbnail(string texture)
        {
            //dummy
            return null;
        }

        public virtual void activate()
        {
            //dummy
        }

        public override Promise draw()
        {
            //dummy
            return null;
        }

        public override void tearDown()
        {
            //dummy
           
        }
        #endregion
    }
}
