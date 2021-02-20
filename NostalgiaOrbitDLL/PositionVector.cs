using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class PositionVector
    {
        public float Position_X { get; set; }
        public float Position_Y { get; set; }

        public PositionVector(float position_X, float position_Y)
        {
            Position_X = position_X;
            Position_Y = position_Y;
        }
    }
}