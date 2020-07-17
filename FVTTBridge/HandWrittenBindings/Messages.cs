using Bridge;
using System;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class Messages
    {
        [Name("object")]
        public Type typeObj; //? docs unclear

        public void flush() { }
        public void render(bool force) { }


    }
}