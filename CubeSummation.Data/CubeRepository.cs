using CubeSummation.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeSummation.Common.POCOs;

namespace CubeSummation.Data
{
    public class CubeRepository : ICubeRepository
    {
        private IList<Point> cube;

        /// <summary>
        /// Object that represents the cube
        /// </summary>
        public IList<Point> Cube
        {
            get
            {
                return this.cube;
            }
        }

        /// <summary>
        /// Creates a cube of sizeXsizeXsize
        /// </summary>
        /// <param name="size">The size of the cube</param>
        public void CreateCube(byte size)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a value inside the cube for a given coordinate
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        /// <param name="value">Value for the given coordinate</param>
        public void SetPointValue(byte x, byte y, byte z, int value)
        {
            throw new NotImplementedException();
        }
    }
}
