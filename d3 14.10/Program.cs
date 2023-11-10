using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3_14._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p0=new Point(5,9);
            Point p1=new Point(12,3);
            Point p2=new Point(2,8);

            Triangle triangle=new Triangle(p0,p1,p2);

            Console.WriteLine(triangle);
            Console.WriteLine("Координати triangle (foreach) ");
            foreach (Point point in triangle)
            {
                Console.WriteLine(point.ToString());
            }

            int lessCount = triangle.Less(8);
            int greaterCount = triangle.Greater(5);

            Console.WriteLine($"\n triangle.Less(8) points with X less than 8: {lessCount}");
            Console.WriteLine($"triangle.Greater(5)  points with X greater than 5: {greaterCount}");

           triangle.ShowEven();
           triangle.ShowOdd();

            Console.WriteLine($"CountDistinct()= {triangle.CountDistinct()}");
            int valueToCompare = 3;
            Console.WriteLine( $"EqualToValue {valueToCompare}= {triangle.EqualToValue(valueToCompare)}");
           

            Console.WriteLine();

           












        }

        
    }
}
