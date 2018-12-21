using System;
using System.Collections.Generic;

namespace Polygons
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            List<Point> points = new List<Point>();
/*            points.Add(new Point(1,2));
            points.Add(new Point(3,4));
            points.Add(new Point(5,6));
            points.Add(new Point(1,2));*/
            points.Add(new Point(3,5));
            points.Add(new Point(6,6));
            points.Add(new Point(6,9));
            points.Add(new Point(3,5));
/*            for (int i = 0; i < 10; i++)
            {
                points.Add(new Point(random.Next(1, 10), random.Next(1, 10)));
            }*/

            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine($"Point {i+1} x: {points[i].X} y: {points[i].Y}");
            }
            
            float sum = 0;
            
            for (int i = 0; i < points.Count; i++)
            {
                
                Point p1 = points[i];
                Point p2;
                float pole;
                if (!(i < points.Count - 1))
                {
                    p2 = points[0];
                    pole = PolygonField.CalculateField(p1, p2);
                    sum += pole;
                    Console.WriteLine($"Pole dla Point {i+1} x: {points[i].X} y: {points[i].Y}" +
                                      $" oraz Point {1} x: {points[0].X} y: {points[0].Y} = {pole}");
                    Console.WriteLine($"Suma: {sum} Suma(ABS): {Math.Abs(sum)}");
                    continue;
                }
                p2 = points[i+1];
                pole = PolygonField.CalculateField(p1, p2);
                sum += pole;
                Console.WriteLine($"Pole dla Point {i+1} x: {points[i].X} y: {points[i].Y}" +
                                  $" oraz Point {i+2} x: {points[i+1].X} y: {points[i+1].Y} = {pole}");
            }
        }
    }
}