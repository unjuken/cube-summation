namespace CubeSummation.Common.POCOs
{
    public class Point
    {
        private byte x;
        private byte y;
        private byte z;

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
        public byte Y
        {
            get
            {
                return y;
            }
        }

        /// <summary>
        /// Coordinate in the Z axis
        /// </summary>
        public byte Z
        {
            get
            {
                return z;
            }
        }

        /// <summary>
        /// Value for the point in the given coordinate
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Point constructor
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        /// <param name="value">Value for the point in the ginve coordinate</param>
        public Point(byte x = 0, byte y = 0, byte z = 0, int value = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.Value = value;
        }
    }
}
