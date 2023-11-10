using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3_14._10
{
    public class Triangle : IEnumerator,ICalc,IOutput2,ICalc2
    { private Point[] points=new Point[3];
        private int position = -1;
        public Triangle(Point p0, Point p1,Point p2) 
        {
            points[0] = p0;
            points[1] = p1;
            points[2] = p2;
               
        }
        
        public object Current
        {
            get 
            {
                if (position == -1 || position >= points.Length)
                    throw new InvalidOperationException();
                return points[position];         
            }
        }

      
        public IEnumerator GetEnumerator()
        {
            return points.GetEnumerator();
        }
    
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public int Greater(int valueToCompare)
        {

            int count = 0;
            foreach (Point p in points)
            {
                if (p.X > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (Point p in points)
            {
                if (p.X < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public void ShowEven()
        {

            Console.WriteLine(" void ShowEven() ");
            foreach (Point p in points) {
                if (p.X % 2 == 0 && p.Y % 2 == 0) {
                    Console.WriteLine(p.ToString());
                }
            
            }

        }

       public  void ShowOdd()
        {
            Console.WriteLine(" void ShowOdd() ");
            foreach (Point p in points)
            {
                if (p.X % 2 != 0 || p.Y % 2 != 0)
                {
                    Console.WriteLine(p.ToString());
                }

            }
        }

        public int CountDistinct()
        {
            HashSet<Point> uniquePoints = new HashSet<Point>(points);
            return uniquePoints.Count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (Point p in points)
            {
                if (p.X == valueToCompare || p.Y==valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
