using System.Numerics;

namespace ShapesLibrary
{
    public class Rectangle : Shape2D
    {
        public override float Circumference { get; }
        public override Vector3 Center { get; }
        public override float Area { get; }
        public bool IsSquare { get; }

        public Rectangle(Vector2 center, Vector2 size) 
        {
            Center = new Vector3(center, 0f);
            Circumference = (size.X * 2) + (size.Y * 2);
            Area = size.X * size.Y;
            IsSquare = size.X == size.Y;
            var shape = IsSquare ? "Square" : "Rectangle";
            stringRepresentation = $"“{shape} @({center.X}, {center.Y}): w = {size.X}, h = {size.Y}” ";
        }

        public Rectangle(Vector2 center, float width) : this(center, new Vector2(width))
        {
            
        }

        
    }
}
