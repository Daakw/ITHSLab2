using System;
using System.Numerics;

namespace ShapesLibrary
{
    public class Circle : Shape2D
    {
        public override float Circumference { get; }
        public override Vector3 Center { get; }
        public override float Area { get; }

        public Circle(Vector2 center, float radius)
        {
            Center = new Vector3(center, 0f);
            Area = radius * radius * MathF.PI;
            Circumference = radius * 2 * MathF.PI;
            stringRepresentation = $"“Circle @({center.X}, {center.Y}): r = {radius}”";
        }

        
    }
}
