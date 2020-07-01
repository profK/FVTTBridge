using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge.Bindings
{

    public class Actor
    {
        protected ActorGlue Glue {get; private set;}

        public Actor(ActorGlue glue)
        {
            Glue = glue;
        }

        public virtual dynamic PrepareData(dynamic data)
        {
            return data;
        }

        public Item getOwnedItem(object v)
        {
            return Glue.getOwnedItem(v);
        }

        public void DeleteOwnedItem(object v)
        {
            Glue.DeleteOwnedItem(v);
        }
    }
}
