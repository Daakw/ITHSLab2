using ShapesLibrary;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace RunLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Vill du ange en mittpunkt för samtliga figurer?\nJa/Nej: ");

            var inPut = Console.ReadLine().ToLower();
            while (inPut != "ja" && inPut != "nej")
            {
                Console.WriteLine($"\nOgiltigt val! Testa igen");
                Console.Write($"\nVill du ange en mittpunkt för samtliga figurer?\nJa/Nej: "); 
                inPut = Console.ReadLine().ToLower();
            }

            var shapes = new List<Shape>();


            if (inPut == "ja")
            {
                Console.WriteLine($"\nVänligen fyll i dina parametrar för mittpunkten\n");
                Console.Write("Position X = ");
                var positionX = int.Parse(Console.ReadLine());
                Console.Write("Position Y = ");
                var positionY = int.Parse(Console.ReadLine());
                Console.Write("Position Z = ");
                var positionZ = int.Parse(Console.ReadLine());
                Console.WriteLine();

                while (shapes.Count < 20)
                {
                    shapes.Add(Shape.GenerateShape(new Vector3(positionX, positionY, positionZ)));

                }
                foreach (var shape in shapes)
                {
                    Console.WriteLine(shape.ToString());
                }
                
            }
            else if (inPut == "nej")
            {
                Console.WriteLine($"\nSamtliga parametrar är slumpade\n");
                while (shapes.Count < 20)
                {
                    shapes.Add(Shape.GenerateShape());

                }
                foreach (var shape in shapes)
                {
                    Console.WriteLine(shape.ToString());
                    if (shape is Triangle) //(shape is Triangle triangle) funkar också
                    {
                        var triangle = shape as Triangle;
                        var counter = 1;

                        foreach (var points in triangle)
                        {
                            Console.WriteLine($"P{counter++} = {points}");
                            
                        }
                    }
                }
                
            }

            var triangleCircumference = shapes.OfType<Triangle>().Sum(triangle => triangle.Circumference); //// räknar ut summan av alla omkrets på trianglarna.
            var shapesArea = shapes.Average(shape => shape.Area); ///räknar ut genomsnittliga arean av alla shapes
            var shape3DMaxVolume = shapes.OfType<Shape3D>().Max(shape3D => shape3D.Volume); ///räknar ut shape med störst volym av alla shape3d.
            var p = shapes.OfType<Shape3D>().First(x => x.Volume == shape3DMaxVolume);///skriver ut den shape i listan med störst volym.

            Console.WriteLine($"\nSumman av omkretsen på alla trianglar: {triangleCircumference}");
            Console.WriteLine($"Genomsnittliga arean av samtliga shapes: {shapesArea}");
            Console.WriteLine($"Shape3D med störst volym är: {p}, summa = {shape3DMaxVolume}");




            Console.ReadKey();
       
        
        
        }

        
    } 


}
