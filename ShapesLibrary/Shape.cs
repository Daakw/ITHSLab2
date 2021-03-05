using System;
using System.Numerics;

namespace ShapesLibrary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
        public override string ToString() => stringRepresentation;
        protected string stringRepresentation;
        private static Random rand = new Random();

        public static Shape GenerateShape()
        {
            return GenerateShape(new Vector3(rand.Next(100), rand.Next(100), rand.Next(100)));
            
        }

        public static Shape GenerateShape(Vector3 center) 
        {
            switch (rand.Next(7))
            {
                case 0:
                    return new Cuboid(center, new Vector3(rand.Next(100), rand.Next(100), rand.Next(100)));
                case 1:
                    return new Cuboid(center, rand.Next(100));//Cube
                case 2:
                    return new Sphere(center, rand.Next(100));
                case 3:
                    return new Circle(new Vector2(center.X, center.Y), rand.Next(100));
                case 4:
                    var p1 = new Vector2(rand.Next(100), rand.Next(100));
                    var p2 = new Vector2(rand.Next(100), rand.Next(100));

                    while (p1 == p2)
                    {
                        p2 = new Vector2(rand.Next(100),rand.Next(100)); 
                    }

                    Vector2 p3 = (new Vector2(center.X, center.Y) * 3f - p1 - p2);
                    return new Triangle(p1, p2, p3); 
                case 5:
                    return new Rectangle(new Vector2(center.X, center.Y), new Vector2(rand.Next(100), rand.Next(100)));
                case 6:
                    return new Rectangle(new Vector2(center.X, center.Y), rand.Next(100));//Square
                default:
                    throw new ArgumentOutOfRangeException();
                    
            }
            

            
        
        }


       

    }
}
