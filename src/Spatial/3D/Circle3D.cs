﻿namespace MathNet.Spatial
{
    using System;

    [Serializable]
    public struct Circle3D
    {
        public readonly Point3D CenterPoint;
        public readonly UnitVector3D Axis;
        public readonly double Radius;

        public Circle3D(Point3D centerPoint, UnitVector3D axis, double radius)
        {
            this.CenterPoint = centerPoint;
            this.Axis = axis;
            this.Radius = radius;
        }
    }
}
