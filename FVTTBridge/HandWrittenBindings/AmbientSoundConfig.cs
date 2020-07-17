using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge.Bindings
{
    public class AmbientSoundConfig:FormApplication
    {
        public new static dynamic defaultOptions;
        public AmbientSoundConfig(AmbientSound sound, object options):base(sound,options) { }



        #region members
        public override Promise close()
        {
            //dummy
            return base.close();
        }


        #endregion
    }
}
