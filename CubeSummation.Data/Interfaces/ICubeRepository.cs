using CubeSummation.Common.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSummation.Data.Interfaces
{
    public interface ICubeRepository
    {
        /// <summary>
        /// Object that represents the cube
        /// </summary>
        IList<Point> Cube { get; }

        /// <summary>
        /// Sets a value inside the cube for a given coordinate
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        /// <param name="value">Value for the given coordinate</param>
        void SetPointValue(byte x, byte y, byte z, int value);

        /// <summary>
        /// Creates a cube of sizeXsizeXsize
        /// </summary>
        /// <param name="size">The size of the cube</param>
        void CreateCube(byte size);
    }
}
