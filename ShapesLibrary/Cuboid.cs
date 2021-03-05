using System.Numerics;

namespace ShapesLibrary
{
    public class Cuboid : Shape3D
    {
         public override float Volume { get; }
        public override Vector3 Center { get; }
        public override float Area { get; }
        public bool IsCube { get; }

        public Cuboid(Vector3 center, Vector3 size)
        {
            Center = center;
            Volume = size.X * size.Y * size.Z;
            Area = ((size.X * size.Y) + (size.X * size.Z) + (size.Y * size.Z)) * 2;
            IsCube = size.X == size.Y && size.X == size.Z;
            var shape = IsCube ? "Cube" : "Cuboid";
            
            stringRepresentation = $"“{shape} @({center.X}, {center.Y}, {center.Z}): w = {size.X}, h = {size.Y}, l = {size.Z}”";
        }

        public Cuboid(Vector3 center, float width) : this(center, new Vector3(width))
        {

        }
        

    }
}
