using System;
using System.Numerics;
using System.Collections;

namespace ShapesLibrary
{
    public class Triangle : Shape2D, IEnumerable, IEnumerator
    {
        public override Vector3 Center { get; }
        public override float Circumference { get; }
        public override float Area { get; }
        private Vector2[] list;
        private int pos;

        public object Current 
        {
            get
            {
                try
                {
                    return list[pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            list = new Vector2[3];
            list[0] = p1;
            list[1] = p2;
            list[2] = p3;
            Center = new Vector3((p1.X + p2.X + p3.X) / 3.0f, (p1.Y + p2.Y + p3.Y) / 3.0f,  0);
            Circumference = (p1 - p2).Length() + (p2 - p3).Length() + (p3 - p1).Length();
            Area = (p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2f;
            
            stringRepresentation = $"“Triangle @({Center.X}, {Center.Y}): p1 = {p1}, p2 = {p2}, p3 = {p3}”"; 
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public bool MoveNext()
        {
            pos++;
            return pos < list.Length;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}
