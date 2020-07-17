using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class BaseGrid
    {
        public float h;
        public FieldOffsetAttribute w;
        public dynamic highlight;
        public float[] getCenter() {
            //dummy
            return new float[] { 0, 0 };
        }

        public float[,] getNeighbors() {
            //dummy
            return new float[0,2];
        }

        public float[] getPixelsFromGridPosition(float x, float y)
        {
            //dummy
            return new float[] { 0, 0 };
        }

        public dynamic getSnappedPosition(float x, float y, float interval)
        {
            //dummy
            return null;
        }

        public float[] getTopLeft()
        {
            //dummy
            return new float[] { 0, 0 };
        }

        public void highlightGridPosition(GridHighLight layer, float x, float y, float color, float border, float alpha) { }

        public float[] measureDistances(dynamic[] segments, dynamic options)
        {
            //dummy
            return new float[0];
        }

        public void shiftPosition(float x, float y, float dx, float dy) { }


    }
}
