using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3_14._10
{//Завдання 3
//    Створіть інтерфейс ICalc2.У ньому мають бути два
//    методи:
//■ int CountDistinct() — повертає кількість унікальних
//значень у контейнері даних;
//■ int EqualToValue(int valueToCompare) — повертає кіль-
//кість значень, рівних valueToCompare.
    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);

    }
}
