using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3_14._10
{//Завдання 1
//    Створіть інтерфейс ICalc.У ньому мають бути два
//    методи:
//■ int Less(int valueToCompare) — повертає кількість
//менших значень, ніж valueToCompare;
//■ int Greater(intvalueToCompare) — повертає кількість
//більших значень, ніж valueToCompare.
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
     
    }

    
}
