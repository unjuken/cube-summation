using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummation.Common.POCOs
{
    public class Point
    {
        byte x;
        byte y;
        byte z;

        /// <summary>
        /// Coordinate in the X axis
        /// </summary>
        public byte X
        {
            get
            {
                return x;
            }
        }

        /// <summary>
        /// Coordinate in the Y axis
        /// </summary>
        public byte Y { get; }

        /// <summary>
        /// Coordinate in the Z axis
        /// </summary>
        public byte Z { get; }

        /// <summary>
        /// Value for the point in the given coordinate
        /// </summary>
        public int Value { get; set; }

        public Point(byte x = 0, byte y = 0, byte z = 0, int value = 0)
        {
            this.X
        }
    }
}
