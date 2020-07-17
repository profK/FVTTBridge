using Bridge;
using System.Runtime.InteropServices;
using static Retyped.es2015_collection;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class GridHighLight
    {
        public string name;
        public Set<float[]> positions;

        public void clear(params float[] args) { } //param guess

        public bool highlight(float x, float y) {
            //dummy
            return false;
        }



    }
}