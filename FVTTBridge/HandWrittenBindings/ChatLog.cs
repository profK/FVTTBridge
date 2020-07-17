using Bridge;
using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Retyped.es2015_core;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class ChatLog:SidebarTab
    {
        public static new dynamic defaultOptions;

        public Messages collection;
        public string tabName;

        public Array<dynamic> parse(string message)
        {
            //dummy
            return null;
        }

        public virtual void activateListeners(jQuery html) { }

        public override SidebarTab createPopout()
        {
            //dummy
            return null;
        }

        public void deleteAll() { }

        public void deleteMessage(string messageId) { }

        public virtual dynamic getData()
        {
            //dummy
            return null;
        }

        public virtual void notify() { }

        public virtual Promise postOne(string message, bool notifyopt = false)
        {
            //dummy
            return null;
        }

        public override void renderPopout() { }

        public void updateMessage(ChatMessage message, bool notify = false) { }



    }
}
