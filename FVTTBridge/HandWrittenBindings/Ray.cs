using Bridge;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class Ray
    {
        public float angle;
        public float distance;
        public float normAngle;
        public float slope;

        public void intersectSegment() { } // TODO docs seem wrong?
        public dynamic project(float distanceOnRay)
        {
            //dummy
            return null;
        }


    }
}