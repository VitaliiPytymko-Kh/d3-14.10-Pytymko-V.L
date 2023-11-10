using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3_14._10
{//РЕАЛІЗУВАТИ КЛАС POINT (ВЛАСТИВОСТІ КООРДИНАТИ X.Y.),МЕТОД TOSTRING ДЛЯ ВИВОДА КООРДИНАТ ТОЧКИ, КОНСТРУКТРОР.
//    РЕАЛІЗУВАТИ КЛАС TRIANGLE(властивості: масив poin[3] ), конструктор
//    клас triangle реализувати інтерфейс iEnumerator
//B main протестіть роботу foreach для об'єкта типу Triangle
    public class Point
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
