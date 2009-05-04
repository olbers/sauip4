using System;
using System.Collections.Generic;
using System.Text;

namespace NRM.OO
{
    public class WiiData
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Value { get; set; }
        public WiiData()
        {
            X = Y = Z = Value = 0;
        }
        public WiiData(float mX, float mY, float mZ)
        {
            X = mX;
            Y = mY;
            Z = mZ;
            Value = CalculateValue(X, Y, Z);
        }

        private float CalculateValue(float mX, float mY, float mZ)
        {
            return Math.Abs(mX) + Math.Abs(mY) + Math.Abs(mZ);
        }

    }
}
