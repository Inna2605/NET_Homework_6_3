//Створіть інтерфейс IOutput2. У ньому мають бути два методи:
//■ void ShowEven() — відображає парні значення контейнера з даними;
//■ void ShowOdd() — відображає непарні значення контейнера з даними.
//Клас, створений раніше у практичному завданні Array, має імплементувати інтерфейс IOutput2.
//Метод ShowEven — відображає парні значення з масиву.
//Метод ShowOdd — відображає непарні значення масиву.
//Напишіть код для тестування отриманої функціональності.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_6_3
{
    internal interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
}
