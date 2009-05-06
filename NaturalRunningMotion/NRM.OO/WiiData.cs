using System;
using System.Collections.Generic;
using System.Text;

namespace NRM.OO
{
    /// <summary>
    /// Class that represents a single record of a wii device's accelerometer data
    /// </summary>
    public class WiiData
    {
        /// <summary>
        /// Public properties of the acceleration values
        /// </summary>
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        
        //public float Value { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public WiiData()
        {
            X = Y = Z = 0;
            //Value = 0;
        }
        /// <summary>
        /// Constructor that recieves the values of the acceleration on all axys
        /// </summary>
        /// <param name="mX">X acceleration</param>
        /// <param name="mY">Y acceleration</param>
        /// <param name="mZ">Z acceleration</param>
        public WiiData(float mX, float mY, float mZ)
        {
            X = mX;
            Y = mY;
            Z = mZ;
            //Value = CalculateValue(X, Y, Z);
        }

        //private float CalculateValue(float mX, float mY, float mZ)
        //{
        //    return Math.Abs(mX) + Math.Abs(mY) + Math.Abs(mZ);
        //}

    }
}
