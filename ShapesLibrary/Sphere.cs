using System;
using System.Numerics;

namespace ShapesLibrary
{
    public class Sphere : Shape3D
    {
        public override float Volume { get; }
        public override Vector3 Center { get; }
        public override float Area { get; }


        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            Area = 4 * (radius * radius) * MathF.PI;
            Volume = (4 * (radius * radius * radius) * MathF.PI) / 3;
            stringRepresentation = $"“Sphere @({center.X}, {center.Y}, {center.Z}): r = {radius}”";
        }
    }
}
