using Bridge;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class SidebarTab
    {
        public static dynamic defaultOptions;

        public string tabName;
        public void activate() { }
        public void close() { }
        public virtual SidebarTab createPopout() {
            //dummy
            return null;
        }

        public virtual void renderPopout() { }

    }
}